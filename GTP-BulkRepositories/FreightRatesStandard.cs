using Sino.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GTP_BulkRepositories
{
    /// <summary>
    /// 运价标准
    /// </summary>
    public class FreightRatesStandard : Entity<string>
    {
        public FreightRatesStandard()
        {
            Id = Guid.NewGuid().ToString();
        }
        /// <summary>
        /// 导入Excel文件Id
        /// </summary>
        public string ExcelFileId { get; set; }

        /// <summary>
        /// 起始地省
        /// </summary>
        public string StartingPlaceProvince { get; set; }

        /// <summary>
        /// 起始地市
        /// </summary>
        public string StartingPlaceCity { get; set; }

        /// <summary>
        /// 起始地区
        /// </summary>
        public string StartingPlaceArea { get; set; }

        /// <summary>
        /// 起始地
        /// </summary>
        public string StartingPlaceName { get; set; }

        /// <summary>
        /// 起始地code
        /// </summary>
        public string StartingPlaceCode { get; set; }

        /// <summary>
        /// 目的地省
        /// </summary>
        public string DestinationPlaceProvince { get; set; }

        /// <summary>
        /// 目的地市
        /// </summary>
        public string DestinationPlaceCity { get; set; }

        /// <summary>
        /// 目的地区
        /// </summary>
        public string DestinationPlaceArea { get; set; }

        /// <summary>
        /// 目的地
        /// </summary>
        public string DestinationPlaceName { get; set; }

        /// <summary>
        /// 目的地code
        /// </summary>
        public string DestinationPlaceCode { get; set; }

        /// <summary>
        /// 车长
        /// </summary>
        public CarLength CarLength { get; set; }

        /// <summary>
        /// 运价下限
        /// </summary>
        public decimal LowerLimitPrice { get; set; }

        /// <summary>
        /// 运价平均值
        /// </summary>
        public decimal AvgLimitPrice { get; set; }

        /// <summary>
        /// 运价上限
        /// </summary>
        public decimal UpLimitPrice { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 数据索引（用于排序）
        /// </summary>
        public int DataIndex { get; set; }

        public virtual FreightRatesStandardExcelFile FreightRatesStandardExcelFile { get; set; }

    }
}
