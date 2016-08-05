﻿using System;

namespace EntityFramework
{
    public class UsageData
    {
        public int UsageDataId { get; set; }
        public DateTime? Time { get; set; }
        public int CpuUsage { get; set; }
        public int RamUsage { get; set; }
        public int AvailableDiskSpaceGb { get; set; }
        public int AverageDiskQueueLength { get; set; }
    }
}
