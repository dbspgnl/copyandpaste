using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyAndPaste
{
    public partial class Form1 : Form
    {
        CGlobalKeyboardHook _kbdHook = new CGlobalKeyboardHook();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Version oVersion = Assembly.GetEntryAssembly().GetName().Version;
            this.Text = string.Format("{0} Ver.{1}.{2} / Build Time ({3})", "Copy&Paste", oVersion.Major, oVersion.Minor, GetBuildDataTime(oVersion));

            _kbdHook.hook();
            _kbdHook.KeyDown += _kbdHook_KeyDown;
        }

        // Build Time을 변환
        public DateTime GetBuildDataTime(Version oVersion)
        {
            string strVerstion = oVersion.ToString();

            // 날짜 등록
            int iDays = Convert.ToInt32(strVerstion.Split('.')[2]);
            DateTime refData = new DateTime(2000, 1, 1);
            DateTime dtBuildDate = refData.AddDays(iDays);

            // 초 등록
            int iSeconds = Convert.ToInt32(strVerstion.Split('.')[3]);
            iSeconds = iSeconds * 2;
            dtBuildDate = dtBuildDate.AddSeconds(iSeconds);

            // 시차 조정
            DaylightTime daylighttime = TimeZone.CurrentTimeZone.GetDaylightChanges(dtBuildDate.Year);

            if (TimeZone.IsDaylightSavingTime(dtBuildDate, daylighttime))
            {
                dtBuildDate = dtBuildDate.Add(daylighttime.Delta);
            }


            return dtBuildDate;
        }

        private void _kbdHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C && cboxactivation.Checked)
            {
                Thread.Sleep(400);
                lboxTextSave.Items.Add(Clipboard.GetData(System.Windows.Forms.DataFormats.UnicodeText).ToString());
            }
        }

        private void lboxTextSave_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lboxTextSave.SelectedIndex != -1)
            {
                Clipboard.SetData(System.Windows.Forms.DataFormats.UnicodeText, lboxTextSave.SelectedItem.ToString());
            }
        }

        private void trackBar1_Scroll_Change(object sender, EventArgs e)
        {
            this.Opacity = trackBar1.Value / 10.0;
        }

        private void btnlbtextadd_Click(object sender, EventArgs e)
        {
            DataSave();
        }

        private void txtlbtextadd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                DataSave();
            }
        }

        private void DataSave()
        {
            String strText = txtlbtextadd.Text;
            if (!String.IsNullOrEmpty(strText) && !lboxTextSave.Items.Contains(strText))
            {
                lboxTextSave.Items.Add(strText);
                txtlbtextadd.Text = "";
            }
        }

        private void cboxactivation_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxactivation.Checked)
            {
                lblactivation.Text = "활성화 상태";
                lblactivation.Enabled = true;

                txtlbtextadd.Enabled = true;
                btnlbtextadd.Enabled = true;
            }
            else
            {
                lblactivation.Text = "비활성화 상태";
                lblactivation.Enabled = false;

                txtlbtextadd.Enabled = false;
                btnlbtextadd.Enabled = false;
            }
        }

        private void lblactivation_Click(object sender, EventArgs e)
        {

        }

        private void lboxTextSave_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if(lboxTextSave.SelectedItems.Count > 0)
                {
                    lboxTextSave.Items.RemoveAt(lboxTextSave.SelectedIndex);
                }
            }
        }

        #region : menu strip

        private void 저장하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fFileSave();
        }

        private void 불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fFileLoad();
        }

        private void 공백제거ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fEmptyDelete();
        }

        private void 모두삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAlldDelete();
        }

        private void 정보StripMenuItem1_Click(object sender, EventArgs e)
        {
            fProgramInfo();
        }

        #endregion

        #region : context menu

        private void 공백제거ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fEmptyDelete();
        }

        private void 저장하기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fFileSave();
        }

        private void 불러오기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fFileLoad();
        }

        private void 모두삭제ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fAlldDelete();
        }

        private void 프로그램정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fProgramInfo();
        }

        #endregion

        #region : function

        private void fEmptyDelete()
        {
            int iCount = lboxTextSave.Items.Count;

            for (int i = 0; i < iCount; i++)
            {
                lboxTextSave.Items[i] = lboxTextSave.Items[i].ToString().Trim();
            }
        }

        private void fAlldDelete()
        {
            if(DialogResult.Yes == MessageBox.Show("등록되어 있는 Data를 초기화 합니다.", "ListBox Item Clear", MessageBoxButtons.YesNo))
            {
                lboxTextSave.Items.Clear();
            }
        }

        private void fFileSave()
        {
            SaveFileDialog SFDialog = new SaveFileDialog();

            int ilbCount = lboxTextSave.Items.Count;
            string strFilePath = string.Empty;

            SFDialog.InitialDirectory = Application.StartupPath;
            SFDialog.FileName = "*.txt";
            SFDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            try
            {
                if (SFDialog.ShowDialog() == DialogResult.OK)
                {
                    strFilePath = SFDialog.FileName;
                    StreamWriter swSFDialog = new StreamWriter(strFilePath);

                    for (int i = 0; i < ilbCount; i++)
                    {
                        swSFDialog.WriteLine(lboxTextSave.Items[i].ToString());
                    }
                    swSFDialog.Close();
                    MessageBox.Show("저장이 완료 되었습니다.");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        private void fFileLoad()
        {
            OpenFileDialog OFDialog = new OpenFileDialog();

            string strFilePath = string.Empty;

            OFDialog.InitialDirectory = Application.StartupPath;
            OFDialog.FileName = "*.txt";
            OFDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            try
            {
                if (OFDialog.ShowDialog() == DialogResult.OK)
                {
                    strFilePath = OFDialog.FileName;
                    StreamReader srOFDialog = new StreamReader(strFilePath, Encoding.UTF8, true);

                    while (srOFDialog.EndOfStream == false)
                    {
                        lboxTextSave.Items.Add(srOFDialog.ReadLine());
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void fProgramInfo()
        {
            string strProgramInfo = "Copy&Paste C# Program Reference Doridori";
            MessageBox.Show(strProgramInfo);
        }

        #endregion

    }
}
