using Sino.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GTP_BulkRepositories
{
    public class UserRatingConfiguration : Entity<string>
    {
        public UserRatingConfiguration()
        {
            Id = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// 导入Excel文件Id
        /// </summary>
        public string ExcelFileId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 评分
        /// </summary>
        public decimal Score { get; set; }

        /// <summary>
        /// 数据索引（用于排序）
        /// </summary>
        public int DataIndex { get; set; }
    }
}
