using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace DriveLetter
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// 更新UI的托管
        /// </summary>
        /// <param name="component">要更新的元素</param>
        /// <param name="value">要更新的值</param>
        private delegate void UpdateUIDelegate(UI_Component component, object value);

        /// <summary>
        /// 卷信息管理对象
        /// </summary>
        VolumeUtils volumeUtils = new VolumeUtils();

        /// <summary>
        /// 卷信息
        /// </summary>
        List<VolumeInfo> volumeInfoList;

        enum UI_Component
        {
            DRIVE_VOULME_LIST,
            DRIVE_VOULME_LABEL,
            DRIVE_FILE_SYSTEM_LABEL,
            DRIVE_SPACE_INFO_LABEL,
            USEABLE_DRIVE_VOLUME_LABEL_LIST
        } ;

        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 更新UI
        /// </summary>
        /// <param name="component">要更新的元素</param>
        /// <param name="value">要更新的值</param>
        void UpdateUI(UI_Component component, object value)
        {
            if (InvokeRequired)
            {
                Invoke(new UpdateUIDelegate(UpdateUI), new object[] {component, value});
            }
            else
            {
                switch (component)
                {
                    case UI_Component.DRIVE_VOULME_LIST:
                        comboBox_DriveVolume.Items.Clear();
                        comboBox_DriveVolume.Items.AddRange((object[])value);
                        comboBox_DriveVolume.SelectedIndex = 0;
                        break;
                    case UI_Component.DRIVE_VOULME_LABEL:
                        label_VolumeLabel.Text = value.ToString();
                        break;
                    case UI_Component.DRIVE_FILE_SYSTEM_LABEL:
                        label_FileSystem.Text = value.ToString();
                        break;
                    case UI_Component.DRIVE_SPACE_INFO_LABEL:
                        label_SpaceInfo.Text = value.ToString();
                        break;
                    case UI_Component.USEABLE_DRIVE_VOLUME_LABEL_LIST:
                        comboBox_AvailableLetter.Items.Clear();
                        comboBox_AvailableLetter.Items.AddRange((object[])value);
                        comboBox_AvailableLetter.SelectedIndex = 0;
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// 更新卷信息
        /// </summary>
        void LoadVolumeInfo()
        {
            List<String> volumeList = new List<String>();
            
            volumeUtils.EnumrateVolumes();
            volumeInfoList = volumeUtils.GetVolumes();
            foreach (VolumeInfo item in volumeInfoList)
            {
                volumeList.Add(String.Format("{0}: {1} ({2})" ,
                    item.VolumeLetter.ToString(), item.VolumeLabel, item.VolumeFileSystem));
            }
            UpdateUI(UI_Component.DRIVE_VOULME_LIST, volumeList.ToArray());
            UpdateUI(UI_Component.USEABLE_DRIVE_VOLUME_LABEL_LIST, volumeUtils.GetAvailableDriveLetters());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new Thread(LoadVolumeInfo).Start();
        }

        /// <summary>
        /// 更新可操作状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_AssignNewVolumeLabel_CheckedChanged(object sender, EventArgs e)
        {
            button_Apply.Enabled = comboBox_AvailableLetter.Enabled = checkBox_AssignNewVolumeLabel.Checked;
        }

        /// <summary>
        /// 更新显示的卷信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_DriveVolume_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI(UI_Component.DRIVE_VOULME_LABEL, volumeInfoList[comboBox_DriveVolume.SelectedIndex].VolumeLabel);
            UpdateUI(UI_Component.DRIVE_FILE_SYSTEM_LABEL, volumeInfoList[comboBox_DriveVolume.SelectedIndex].VolumeFileSystem);
            UpdateUI(UI_Component.DRIVE_SPACE_INFO_LABEL, volumeInfoList[comboBox_DriveVolume.SelectedIndex].GetVolumeSpaceInfo());
        }

        /// <summary>
        /// 应用更改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Apply_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(String.Format("确定要将驱动器号 “{0}:” 分配给驱动器 “{1}” 吗?",
                comboBox_AvailableLetter.SelectedItem, comboBox_DriveVolume.SelectedItem), "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                volumeInfoList[comboBox_DriveVolume.SelectedIndex].VolumeLetter = comboBox_AvailableLetter.SelectedItem.ToString()[0];
                volumeInfoList[comboBox_DriveVolume.SelectedIndex].ApplyChangesToVolume();
                checkBox_AssignNewVolumeLabel.Checked = false;
                new Thread(LoadVolumeInfo).Start();
            }
        }

        private void button_RefreshVolume_Click(object sender, EventArgs e)
        {
            //Thread.Sleep(10000);
            new Thread(LoadVolumeInfo).Start();
        }
    }
}
