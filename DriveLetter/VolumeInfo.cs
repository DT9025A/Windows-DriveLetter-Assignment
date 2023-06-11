using System;
using System.Management;

namespace DriveLetter
{
    internal class VolumeInfo
    {
        private char volumeLetter;
        private String volumeLabel = "";
        private String volumeFileSystem;
        private UInt64 volumeCapacity;
        private UInt64 volumeFreeSpace;

        private ManagementObject volume;

        /// <summary>
        /// 驱动器号
        /// </summary>
        public char VolumeLetter { get => volumeLetter; set => volumeLetter = value; }

        /// <summary>
        /// 驱动器卷标
        /// </summary>
        public string VolumeLabel { get => volumeLabel; /* set => volumeLabel = value; */}

        /// <summary>
        /// 驱动器文件系统
        /// </summary>
        public string VolumeFileSystem { get => volumeFileSystem; }

        /// <summary>
        /// 总大小
        /// </summary>
        public UInt64 VolumeCapacity { get => volumeCapacity; }

        /// <summary>
        /// 可用大小
        /// </summary>
        public UInt64 VolumeFreeSpace { get => volumeFreeSpace; }

        /// <summary>
        /// 卷管理对象
        /// </summary>
        public ManagementObject Volume { get => volume; }

        /// <summary>
        /// 构造一个对象
        /// </summary>
        /// <param name="_v">卷管理对象</param>
        /// <param name="_l">驱动器号</param>
        public VolumeInfo(ManagementObject _v, char _l)
        {
            volume = _v;
            volumeLetter = _l;
            volumeLabel = volume["Label"] == null ? "(无卷标)" : volume["Label"].ToString();
            volumeFileSystem = volume["FileSystem"]?.ToString();
            volumeCapacity = (UInt64)volume["Capacity"];
            volumeFreeSpace = (UInt64)volume["FreeSpace"];
        }

        /// <summary>
        /// 应用更改（此处需要管理员权限）
        /// </summary>
        public void ApplyChangesToVolume()
        {
            volume.Get();
            volume["DriveLetter"] = volumeLetter + ":";
            volume.Put();
            // volume["Label"] = volumeLabel;
        }

        public String GetVolumeSpaceInfo()
        {
            ulong Gib = 1 << 30;
            ulong Mib = 1 << 20;
            if (volumeCapacity > Gib)
            {
                return String.Format("空闲{0:F2}GiB / 共{1:F2}GiB, 使用{2:F2}%",
                (double)VolumeFreeSpace / Gib,
                (double)VolumeCapacity / Gib,
                100 * (1.0 - (double)VolumeFreeSpace / VolumeCapacity));
            } else
            {
                return String.Format("空闲{0:F2}MiB / 共{1:F2}MiB, 使用{2:F2}%",
                (double)VolumeFreeSpace / Mib,
                (double)VolumeCapacity / Mib,
                100 * (1.0 - (double)VolumeFreeSpace / VolumeCapacity));
            }
        }
    }
}
