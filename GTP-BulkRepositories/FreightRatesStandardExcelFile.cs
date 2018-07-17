using Sino.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GTP_BulkRepositories
{
    /// <summary>
    /// 运价标准文件
    /// </summary>
    public class FreightRatesStandardExcelFile : Entity<string>
    {
        public FreightRatesStandardExcelFile()
        {
            Id = Guid.NewGuid().ToString();
        }
        /// <summary>
        /// 文件名
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// 文件大小
        /// </summary>
        public string FileSize { get; set; }

        /// <summary>
        /// 导入时间
        /// </summary>
        public DateTime ImportTime { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        public DateTime? TakeEffectTime { get; set; }
    }
}
