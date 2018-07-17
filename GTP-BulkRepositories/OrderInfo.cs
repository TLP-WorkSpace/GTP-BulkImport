using Sino.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GTP_BulkRepositories
{
    /// <summary>
    /// 订单实体
    /// </summary>
    public class Orders : Entity<string>
    {
        public Orders()
        {
            Id = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// 数量
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 数量单位
        /// </summary>
        public string AmountUnit { get; set; }

        /// <summary>
        /// 到货时间
        /// </summary>
        public DateTime ArrivalTime { get; set; }

        /// <summary>
        /// 车长
        /// </summary>
        public string CarLength { get; set; }

        /// <summary>
        /// 承运单
        /// </summary>
        public string CarrierOrderId { get; set; }

        /// <summary>
        /// 货物类别
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// 联系人ID
        /// </summary>
        public string ContactChatId { get; set; }

        /// <summary>
        /// 联系人名称
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// 联系人手机号码
        /// </summary>
        public string ContactPhoneNumber { get; set; }

        /// <summary>
        /// 发货时间
        /// </summary>
        public DateTime DeliveryTime { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderNumber { get; set; }

        ///// <summary>
        ///// 价格
        ///// </summary>
        //public string Price { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        public OrderStatus State { get; set; }

        ///// <summary>
        ///// 订单类型
        ///// </summary>
        //public OrderType Type { get; set; }

        ///// <summary>
        ///// 用户ID
        ///// </summary>
        //public string UserId { get; set; }


        /// <summary>
        /// 起始地点代码 
        /// </summary>
        public string StartingPlaceCode { get; set; }


        /// <summary>
        /// 起始地点名称 
        /// </summary>
        public string StartingPlaceName { get; set; }

        /// <summary>
        /// 起始地详细地址
        /// </summary>
        public string StartPlaceDetailName { get; set; }

        /// <summary>
        /// 目的地代码 
        /// </summary>
        public string DestinationPlaceCode { get; set; }

        /// <summary>
        /// 目的地名称 
        /// </summary>

        public string DestinationPlaceName { get; set; }

        /// <summary>
        /// 目的地详细地址
        /// </summary>
        public string DestinationPlaceDetailName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }

        public bool IsDelete { get; set; }

        /// <summary>
        /// 是否关注 伪列
        /// </summary>
        public bool IsFocus { get; set; }

        /// <summary>
        /// 红包数
        /// </summary>
        public int RedNum { get; set; }

        public CarrierOrder CarrierOrder { get; set; }

        /// <summary>
        /// 客服图像
        /// </summary>
        public string DispatcherHead { get; set; }

        /// <summary>
        /// 车型
        /// </summary>
        public VehicleType VehicleType { get; set; }

        /// <summary>
        /// 货源地址GEO哈希值
        /// </summary>
        public string Distance { get; set; }

    }
}
