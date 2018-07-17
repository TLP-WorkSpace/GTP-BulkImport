using Sino.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GTP_BulkRepositories
{
    /// <summary>
    /// 用户长运路线实体
    /// </summary>
    public class CommonTransportLinkageInfo : Entity<string>
    {
        public CommonTransportLinkageInfo()
        {
            CommonTransportLinkageId = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// 主键
        /// </summary>
        public string CommonTransportLinkageId { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime? OperationTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// 线路ID
        /// </summary>
        public string TransportLinkageId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDelete { get; set; } = false;

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
        /// 线路外键
        /// </summary>
        //public TransportLinkageInfo TransportLinkageInfo { get; set; }

        /// <summary>
        /// 用户外键
        /// </summary>
        public Aspnetusers UserInfo { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        public long TimeStamp { get; set; }
    }
}
