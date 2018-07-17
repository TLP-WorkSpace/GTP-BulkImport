using Sino.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GTP_BulkRepositories
{
    /// <summary>
    /// 银行卡实体
    /// </summary>
    public class BankCardInfo : Entity<string>
    {
        public BankCardInfo()
        {
            BankCardId = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// 主键
        /// </summary>
        public string BankCardId { get; set; }

        /// <summary>
        /// 银行ID
        /// </summary>
        public string BankId { get; set; }

        /// <summary>
        /// 持有人
        /// </summary>
        public string Holder { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDelete { get; set; } = false;

        /// <summary>
        /// 新增银行卡时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 银行外键
        /// </summary>
        public BankInfo BankInfo { get; set; }

        /// <summary>
        /// 用户外键
        /// </summary>
        public Aspnetusers UserInfo { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        public int TimeStamp { get; set; }
    }
}
