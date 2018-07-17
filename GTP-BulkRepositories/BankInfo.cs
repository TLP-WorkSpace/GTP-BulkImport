using Sino.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GTP_BulkRepositories
{
    /// <summary>
    /// 银行实体
    /// </summary>
    public class BankInfo : Entity<string>
    {
        public BankInfo()
        {
            BankId = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// 主键
        /// </summary>
        public string BankId { get; set; }

        /// <summary>
        /// 银行Code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 银行名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 银行Logo
        /// </summary>
        public string LogoKey { get; set; }
    }
}
