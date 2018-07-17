using System;
using System.Collections.Generic;
using System.Text;

namespace GTP_BulkRepositories
{
    public class QuotationRateInfo
    {

        /// <summary>
        /// 主键
        /// </summary>
        public string QuotationId { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public float Price { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 报价成功率
        /// </summary>
        public double QuotationRate { get; set; }
    }
}
