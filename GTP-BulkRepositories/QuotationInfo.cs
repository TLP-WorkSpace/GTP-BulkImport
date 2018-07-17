using Sino.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GTP_BulkRepositories
{
    /// <summary>
    /// 抢单实体
    /// </summary>
    public class QuotationInfo : Entity<string>
    {
        public QuotationInfo()
        {
            QuotationId = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// 主键
        /// </summary>
        public string QuotationId { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public float Price { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// 价格单位
        /// </summary>
        public PriceUnit Unit { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 用户外键
        /// </summary>
        public virtual Aspnetusers UserInfo { get; set; }

        /// <summary>
        /// 订单外键
        /// </summary>
        //public virtual OrderInfo OrderInfo { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// 线路ID
        /// </summary>
        public string TransportLinkageId { get; set; }

        /// <summary>
        /// 订单备注
        /// </summary>
        public string OrderRemarks { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        public OrderType Type { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        public OrderState State { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// 数量单位
        /// </summary>
        public string AmountUnit { get; set; }

        /// <summary>
        /// 类别
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// 到达时间
        /// </summary>
        public DateTime ArrivalTime { get; set; }

        /// <summary>
        /// 交付时间
        /// </summary>
        public DateTime DeliveryTime { get; set; }

        /// <summary>
        /// 车长
        /// </summary>
        public string CarLength { get; set; }

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
        /// 起始地点代码
        /// </summary>
        public string StartingPlaceCode { get; set; }

        /// <summary>
        /// 起始地点名称
        /// </summary>
        public string StartingPlaceName { get; set; }

        /// <summary>
        /// 目的地代码
        /// </summary>
        public string DestinationPlaceCode { get; set; }

        /// <summary>
        /// 目的地名称
        /// </summary>

        public string DestinationPlaceName { get; set; }

        /// <summary>
        /// 承运单
        /// </summary>
        public string CarrierOrderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Orders Orders { get; set; }

        /// <summary>
        /// 是否最低报价
        /// </summary>
        public int IsLowerQuotation { get; set; }
        /// <summary>
        /// 是否有效报价  0:有效 1:无效
        /// </summary>
        public int IsInvalid { get; set; }

        /// <summary>
        /// 报价成功率
        /// </summary>
        public double QuotationRate { get; set; }
    }
}
