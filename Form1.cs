using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
    }
}
