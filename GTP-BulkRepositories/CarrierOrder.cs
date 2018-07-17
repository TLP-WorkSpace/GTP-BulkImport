using Sino.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GTP_BulkRepositories
{

    /// <summary>
    /// 承运单
    /// </summary>
    public class CarrierOrder : Entity<string>
    {
        public CarrierOrder()
        {
            Id = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// 承运单Id
        /// </summary>
        public string CarrierOrderId { get; set; }

        /// <summary>
		/// 物流公司编号
		/// </summary>
		public string LogisticsId { get; set; }

        /// <summary>
        /// 开户银行
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// 银行卡号
        /// </summary>
        public string BankCode { get; set; }

        /// <summary>
        /// 持卡人
        /// </summary>
        public string Holder { get; set; }

        /// <summary>
        /// 账户信息
        /// </summary>
        public string BankId { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        public string CarCode { get; set; }

        /// <summary>
        /// 车辆编号
        /// </summary>
        public string CarId { get; set; }

        /// <summary>
        /// 车长
        /// </summary>
        public Int32 CarLength { get; set; }

        /// <summary>
        /// 承运商名称
        /// </summary>
        public string Carrier { get; set; }

        /// <summary>
        /// 承运商编号
        /// </summary>
        public string CarrierId { get; set; }

        /// <summary>
        /// 结算方号码
        /// </summary>
        public string CarrierPhone { get; set; }

        /// <summary>
        /// 承运商类型
        /// </summary>
        public Int32 CarrierType { get; set; }

        /// <summary>
        /// 车型
        /// </summary>
        public Int32 VehicleType { get; set; }

        /// <summary>
        /// 合同编号
        /// </summary>
        public string ContractId { get; set; }

        /// <summary>
        /// 驾驶员姓名
        /// </summary>
        public string Driver { get; set; }

        /// <summary>
        /// 驾驶员号码
        /// </summary>
        public string DriverPhone { get; set; }

        /// <summary>
        /// 应付单价
        /// </summary>
        public decimal PayablePrice { get; set; }

        /// <summary>
        /// 应付单价单位
        /// </summary>
        public Int32 PayablePriceUnit { get; set; }

        /// <summary>
        /// 应付单价说明
        /// </summary>
        public string PayableSummary { get; set; }

        /// <summary>
        /// 回单款
        /// </summary>
        public decimal? ReceiptPrice { get; set; }

        /// <summary>
        /// 回单款付款方式
        /// </summary>
        public Int32? ReceiptPriceUnit { get; set; }

        /// <summary>
        /// 承运单备注
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// 临时客服专员
        /// </summary>
        public string TempCustomerService { get; set; }

        /// <summary>
        /// 临时客服专员编号
        /// </summary>
        public long TempCustomerServiceId { get; set; }

        /// <summary>
        /// 定位状态
        /// </summary>
        public bool LocationStatus { get; set; }

        /// <summary>
        /// 道路运输许可证号
        /// </summary>
        public string PermitNumber { get; set; }

        /// <summary>
        /// 所属辖区(省)
        /// </summary>
        public string CountrySubdivisionProvinceCode { get; set; }

        /// <summary>
        /// 所属辖区(市)
        /// </summary>
        public string CountrySubdivisionCityCode { get; set; }

        /// <summary>
        /// 所属辖区(区)
        /// </summary>
        public string CountrySubdivisionCountryCode { get; set; }

        /// <summary>
        /// 道路运输证字号
        /// </summary>
        public string RoadTransportCertificateNumber { get; set; }


        #region Order
        /// <summary>
        /// 订单主键
        /// </summary>
        public string Order_Id { get; set; }

        /// <summary>
        /// Csp订单编号
        /// </summary>
        public string Order_CspOrderId { get; set; }

        /// <summary>
        /// 订单中所需车长
        /// </summary>
        public Int32 Order_CarLength { get; set; }

        /// <summary>
        /// 承运方式
        /// </summary>
        public Int32 Order_CarriageWay { get; set; }

        /// <summary>
        /// 订单中车型
        /// </summary>
        public Int32 Order_VehicleType { get; set; }

        /// <summary>
        /// 装车效果
        /// </summary>
        public string Order_LoadingEffect { get; set; }

        /// <summary>
        /// 客户单位名称
        /// </summary>
        public string Order_ClientName { get; set; }

        /// <summary>
        /// 客户单位编号
        /// </summary>
        public string Order_ClientId { get; set; }

        /// <summary>
        /// 发货计划人编号
        /// </summary>
        public string Order_ConsignorId { get; set; }

        /// <summary>
        /// 发货内容
        /// </summary>
        public string Order_Content { get; set; }

        /// <summary>
        /// 客服专员名称
        /// </summary>
        public string Order_CustomerServiceName { get; set; }

        /// <summary>
        /// 客服专员编号
        /// </summary>
        public long Order_CustomerServiceId { get; set; }

        /// <summary>
        /// 调度专员编号
        /// </summary>
        public long Order_DispatcherId { get; set; }

        /// <summary>
        /// 调度专员名称
        /// </summary>
        public string Order_DispatcherName { get; set; }

        /// <summary>
        /// 调度专员头像
        /// </summary>
        public string Order_DispatcherHead { get; set; }

        /// <summary>
        /// 调度专员号码
        /// </summary>
        public string Order_DispatcherPhoneNumber { get; set; }

        /// <summary>
        /// 可识别的订单编号
        /// </summary>
        public string Order_OrderId { get; set; }

        /// <summary>
        /// 计划专员编号
        /// </summary>
        public long Order_PlannerId { get; set; }

        /// <summary>
        /// 计划专员名称
        /// </summary>
        public string Order_PlannerName { get; set; }

        /// <summary>
        /// 商务专员编号
        /// </summary>
        public long Order_BusinessAffairsId { get; set; }

        /// <summary>
        /// 商务专员名称
        /// </summary>
        public string Order_BusinessAffairsName { get; set; }

        /// <summary>
        /// 订单备注
        /// </summary>
        public string Order_OrderRemarks { get; set; }

        /// <summary>
        /// 规定回复时间（分钟）
        /// </summary>
        public long Order_ResponseTime { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        public Int32 Order_Status { get; set; }

        /// <summary>
        /// 发货时间
        /// </summary>
        public DateTime Order_DeliveryTime { get; set; }

        /// <summary>
        /// 到货时间
        /// </summary>
        public DateTime Order_ArrivalTime { get; set; }

        /// <summary>
        /// 实际发货时间
        /// </summary>
        public DateTime? Order_RealDeliveryTime { get; set; }

        /// <summary>
        /// 实际到货时间
        /// </summary>
        public DateTime? Order_RealArrivalTime { get; set; }

        /// <summary>
        /// 货物编号
        /// </summary>
        public string Order_GoodsId { get; set; }

        /// <summary>
        /// 货物名称
        /// </summary>
        public string Order_GoodsName { get; set; }

        /// <summary>
        /// 货物类型编号
        /// </summary>
        public string Order_GoodsTypeId { get; set; }

        /// <summary>
        /// 货物类型名称
        /// </summary>
        public string Order_GoodsTypeName { get; set; }

        /// <summary>
        /// 货物数量
        /// </summary>
        public decimal Order_QuantityOfGoods { get; set; }

        /// <summary>
        /// 实际货物数量
        /// </summary>
        public decimal Order_RealQuantityOfGoods { get; set; }

        /// <summary>
        /// 货物数量单位
        /// </summary>
        public Int32 Order_GoodsUnit { get; set; }

        /// <summary>
        /// 货物数量2
        /// </summary>
        public decimal? Order_QuantityOfGoodsTwo { get; set; }

        /// <summary>
        /// 货物数量2单位
        /// </summary>
        public Int32? Order_GoodsUnitTwo { get; set; }

        /// <summary>
        /// 里程数
        /// </summary>
        public float? Order_Mileage { get; set; }

        /// <summary>
        /// 目的地省
        /// </summary>
        public string Order_DestinationProvince { get; set; }

        /// <summary>
        /// 目的地市
        /// </summary>
        public string Order_DestinationCity { get; set; }

        /// <summary>
        /// 目的地区
        /// </summary>
        public string Order_DestinationCounty { get; set; }

        /// <summary>
        /// 目的地详情
        /// </summary>
        public string Order_DestinationDetails { get; set; }

        /// <summary>
        /// 起始地省
        /// </summary>
        public string Order_OriginProvince { get; set; }

        /// <summary>
        /// 起始地市
        /// </summary>
        public string Order_OriginCity { get; set; }

        /// <summary>
        /// 起始地区
        /// </summary>
        public string Order_OriginCounty { get; set; }

        /// <summary>
        /// 起始地详情
        /// </summary>
        public string Order_OriginDetails { get; set; }

        /// <summary>
        /// 起始地名称
        /// </summary>
        public string Order_OriginAddress { get; set; }

        /// <summary>
        /// 目的地名称
        /// </summary>
        public string Order_DestinationAddress { get; set; }

        /// <summary>
        /// 目的地经度
        /// </summary>
        public float? Order_DestinationLongitude { get; set; }

        /// <summary>
        /// 起始地经度
        /// </summary>
        public float? Order_OriginLongitude { get; set; }

        /// <summary>
        /// 目的地纬度
        /// </summary>
        public float? Order_DestinationLatitude { get; set; }

        /// <summary>
        /// 起始地纬度
        /// </summary>
        public float? Order_OriginLatitude { get; set; }

        /// <summary>
        /// 途经卸货地列表(列表查询)
        /// </summary>
        public string Order_ViaList { get; set; }


        /// <summary>
        /// 途经卸货地列表(前端显示)
        /// </summary>
        public string Order_ViaAddressList { get; set; }

        /// <summary>
        /// 附件备注说明
        /// </summary>
        public string Order_AttachmentRemarks { get; set; }

        /// <summary>
        /// 吨位范围
        /// </summary>
        public string Order_TonnageRange { get; set; }

        /// <summary>
        /// 审核通过时间
        /// </summary>
        public DateTime? Order_AuditedTime { get; set; }

        /// <summary>
        /// 回单状态
        /// </summary>
        public Int32 Order_ReceiptStatus { get; set; }

        /// <summary>
        /// 回单签收时间
        /// </summary>
        public DateTime? Order_ReceiptTime { get; set; }

        /// <summary>
        /// 合同编号
        /// </summary>
        public string Order_ContractNumber { get; set; }

        #endregion


        #region Contract

        /// <summary>
        /// 收货人
        /// </summary>
        public string Contract_Consignee { get; set; }

        /// <summary>
        /// 收货人号码
        /// </summary>
        public string Contract_ConsigneePhone { get; set; }

        /// <summary>
        /// 备用电话
        /// </summary>
        public string Contract_AltermatePhone { get; set; }

        /// <summary>
        /// 辅助工具
        /// </summary>
        public string Contract_AuxiliaryTool { get; set; }

        /// <summary>
        /// 合同编号
        /// </summary>
        public string Contract_ContractNumber { get; set; }

        /// <summary>
        /// 合同状态
        /// </summary>
        public Int32? Contract_ContractStatus { get; set; }

        /// <summary>
        /// 驾驶证号
        /// </summary>
        public string Contract_DriverLicenseNumber { get; set; }

        /// <summary>
        /// 发动机号
        /// </summary>
        public string Contract_EngineNumber { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        public string Contract_FrameNumber { get; set; }

        /// <summary>
        /// 合同货物数量单位
        /// </summary>
        public Int32? Contract_GoodsUnit { get; set; }

        /// <summary>
        /// 油卡卡号
        /// </summary>
        public string Contract_OilCardNumber { get; set; }

        /// <summary>
        /// 油卡状态
        /// </summary>
        public Int32? Contract_OilCardStatus { get; set; }

        /// <summary>
        /// 合同货物数量
        /// </summary>
        public decimal? Contract_QuantityOfGoods { get; set; }

        /// <summary>
        /// 挂车车架号
        /// </summary>
        public string Contract_TrailerFrameNumber { get; set; }

        /// <summary>
        /// 挂车号
        /// </summary>
        public string Contract_TrailerNumber { get; set; }

        /// <summary>
        /// 合同日期
        /// </summary>
        public DateTime? Contract_ContractTime { get; set; }

        /// <summary>
        /// 运费总价
        /// </summary>
        public decimal? Contract_TotalPrice { get; set; }

        /// <summary>
        /// 电子合同编号
        /// </summary>
        public string Contract_ElectronicContractNumber { get; set; }

        /// <summary>
        /// 电子合同状态
        /// </summary>
        public Int32? Contract_ElectronicContractStatus { get; set; }

        /// <summary>
        /// 补充协议合同编号
        /// </summary>
        public string Contract_AgreementContractNumber { get; set; }

        /// <summary>
        /// 补充协议合同状态
        /// </summary>
        public Int32? Contract_AgreementContractStatus { get; set; }

        /// <summary>
        /// 送货单号
        /// </summary>
        public string Contract_DeliveryNumber { get; set; }

        #endregion

        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        public long TimeStamp { get; set; }
    }
}
