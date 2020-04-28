using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CalenderScheduleMaker
{
    public partial class MainForm : Form
    {
        Functions functions = new Functions();
        CalenderSchedule calenderSchedule = new CalenderSchedule();
        UserSettings userSettings = new UserSettings();

        public MainForm()
        {
            InitializeComponent();
        }

        private void UnSavedWarn(bool unSave)
        {
            if (unSave)
            {
                this.Text = "Calender Schedule Maker *";
            }
            else
            {
                this.Text = "Calender Schedule Maker";
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initialize text encode selector
            foreach (var item in Encoding.GetEncodings())
            {
                cb_TextFormat.Items.Add(item.GetEncoding().WebName);
            }
            cb_TextFormat.SelectedIndex = 0;

            // Initialize Alarm before selector
            cb_AlarmBefore.Items.AddRange(Enum.GetNames(typeof(AlarmSet.AlarmBefores)));
            cb_AlarmBefore.SelectedIndex = 0;

            // Initialize start and stop date time picker
            dtp_StartDate.Value = DateTime.Today;
            dtp_StopDate.Value = DateTime.Today.AddMonths(6);

            // Initialize data grid view
            userSettings.EventsList.Add(new EventData());
            dgv_EventsList.DataSource = userSettings.EventsList;

            // Initialize Message window
            tb_Message.Clear();
            WriteMessage("Calender Schedule Maker Ver. " + this.ProductVersion.ToString());

            UnSavedWarn(false);
        }

        private void btn_SaveSettings_Click(object sender, EventArgs e)
        {
            DialogResult res = sfd_SaveSettings.ShowDialog();
            if (res == DialogResult.OK)
            {
                functions.ExportUserSettings(sfd_SaveSettings.FileName, userSettings);

                WriteMessage("Setting File Saved");

                UnSavedWarn(false);
            }
        }

        private void btn_ImportSettings_Click(object sender, EventArgs e)
        {
            DialogResult res = ofd_ImportSettings.ShowDialog();
            if (res == DialogResult.OK)
            {
                userSettings = functions.ImportUserSettings(ofd_ImportSettings.FileName);

                dtp_StartDate.Value = userSettings.Startdate;
                dtp_StopDate.Value = userSettings.Stopdate;
                cb_TextFormat.Text = userSettings.TextEncoding;
                dgv_EventsList.DataSource = userSettings.EventsList;

                WriteMessage("Setting File Imported");

                UnSavedWarn(false);
            }
        }

        private void btn_AddColumn_Click(object sender, EventArgs e)
        {
            userSettings.EventsList.Add(new EventData());
            dgv_EventsList.DataSource = null;
            dgv_EventsList.DataSource = userSettings.EventsList;

            WriteMessage("Column Added");

            UnSavedWarn(true);
        }

        private void btn_DelColumn_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgv_EventsList.CurrentCell.RowIndex;
            userSettings.EventsList.RemoveAt(selectedIndex);
            dgv_EventsList.DataSource = null;
            dgv_EventsList.DataSource = userSettings.EventsList;

            WriteMessage("Column Deleted");

            UnSavedWarn(true);
        }

        private void btn_ExportFile_Click(object sender, EventArgs e)
        {
            DialogResult res = sfd_SaveFile.ShowDialog();
            if (res == DialogResult.OK)
            {
                userSettings.FileName = sfd_SaveFile.FileName;
                calenderSchedule.FileName = userSettings.FileName;
                calenderSchedule.TextEncoding = Encoding.GetEncoding(userSettings.TextEncoding);
                calenderSchedule.Startdate = userSettings.Startdate;
                calenderSchedule.Stopdate = userSettings.Stopdate;
                calenderSchedule.AlarmEnable = userSettings.AlarmEnable;
                calenderSchedule.AlarmBefore = userSettings.AlarmBefore;
                calenderSchedule.EventsList = userSettings.EventsList;

                string msg = calenderSchedule.GenerateCalData();
                WriteMessage(msg);
            }
        }

        private void dgv_EventsList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            WriteMessage("EventsList Changed");
            userSettings.EventsList = (List<EventData>)dgv_EventsList.DataSource;
            UnSavedWarn(true);
        }

        private void dgv_EventsList_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dgv_EventsList.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dtp_StartDate_ValueChanged(object sender, EventArgs e)
        {
            userSettings.Startdate = dtp_StartDate.Value;
            WriteMessage("StartDate Changed");

            UnSavedWarn(true);
        }

        private void dtp_StopDate_ValueChanged(object sender, EventArgs e)
        {
            userSettings.Stopdate = dtp_StopDate.Value;
            WriteMessage("StopDate Changed");

            UnSavedWarn(true);
        }

        private void cb_TextFormat_TextChanged(object sender, EventArgs e)
        {
            userSettings.TextEncoding = cb_TextFormat.Text;
            WriteMessage("TextFormat Changed");

            UnSavedWarn(true);
        }

        private void chkb_AlarmEnable_CheckedChanged(object sender, EventArgs e)
        {
            userSettings.AlarmEnable = chkb_AlarmEnable.Checked;
            WriteMessage("AlarmEnable Changed");

            UnSavedWarn(true);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Text.Contains("*"))
            {
                DialogResult res = MessageBox.Show("", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (res == DialogResult.Yes)
                {
                    DialogResult res_save = sfd_SaveSettings.ShowDialog();
                    if (res_save == DialogResult.OK)
                    {
                        functions.ExportUserSettings(sfd_SaveSettings.FileName, userSettings);
                        UnSavedWarn(false);
                        e.Cancel = false;
                    }
                    else if (res_save == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
                else if (res == DialogResult.No)
                {
                    e.Cancel = false;
                }
                else if (res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
        private void WriteMessage(string msg)
        {
            tb_Message.AppendText(DateTime.Now.ToShortTimeString() + " | " + msg + Environment.NewLine);
        }

    }
}
