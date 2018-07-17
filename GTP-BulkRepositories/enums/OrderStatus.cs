using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GTP_BulkRepositories
{
    /// <summary>
    /// 订单状态
    /// </summary>
    public enum OrderStatus
    {

        /// <summary>
        /// 缺省值
        /// </summary>
        None = 0,

        /// <summary>
        /// 派车中
        /// </summary>
        ITC = 1,

        /// <summary>
        /// 退回下单
        /// </summary>
        RTTO = 2,

        /// <summary>
        /// 已派车
        /// </summary>
        HSC = 3,

        /// <summary>
        /// 退回派车
        /// </summary>
        BTS = 4,

        /// <summary>
        /// 待发货
        /// </summary>
        WFTD = 5,

        /// <summary>
        /// 已发货
        /// </summary>
        SHIP = 6,

        /// <summary>
        /// 货已送达
        /// </summary>
        TCHBD = 7,

        /// <summary>
        /// 订单终结
        /// </summary>
        OEND = 8
    }
}
