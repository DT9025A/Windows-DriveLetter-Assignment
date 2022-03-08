using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management;

namespace DriveLetter
{
    internal class VolumeUtils
    {
        /// <summary>
        /// 卷Hash表
        /// </summary>
        private Hashtable volumes;

        /// <summary>
        /// 卷信息表
        /// </summary>
        private List<VolumeInfo> volumeList;

        /// <summary>
        /// 枚举计算机中具有驱动器号的卷
        /// </summary>
        public void EnumrateVolumes()
        {
            ManagementObjectSearcher disks = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Volume");
            char Lbl;

            volumes = new Hashtable();
            volumeList = new List<VolumeInfo>();

            foreach (ManagementObject disk in disks.Get())
            {
                // reference: https://docs.microsoft.com/en-us/previous-versions/windows/desktop/legacy/aa394515(v=vs.85)?redirectedfrom=MSDN#examples
                if (disk["DriveLetter"] != null)
                {
                    Lbl = disk["DriveLetter"].ToString()[0];
                    volumes.Add(Lbl, disk);
                    volumeList.Add(new VolumeInfo(disk, Lbl));
                }
            }
            volumeList.OrderBy(x => { return x.VolumeLetter; });
        }

        /// <summary>
        /// 获取卷枚举结果
        /// </summary>
        /// <returns></returns>
        public List<VolumeInfo> GetVolumes()
        {
            return volumeList;
        }

        /// <summary>
        /// 获取可用的驱动器号
        /// </summary>
        /// <returns></returns>
        public String[] GetAvailableDriveLetters()
        {
            List<String> availableDriveLetters = new List<string>();
            for(char letter = 'A'; letter <= 'Z'; letter = (char)(letter + 1))
            {
                if (!volumes.ContainsKey(letter))
                {
                    availableDriveLetters.Add(letter.ToString());
                }
            }
            return availableDriveLetters.ToArray();
        }
    }
}
