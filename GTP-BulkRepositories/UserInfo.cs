using Sino.Domain.Entities;
using System;
using System.Collections.Generic;

namespace GTP_BulkRepositories
{
    /// <summary>
    /// 用户模型
    /// </summary>
    public class Aspnetusers : Entity<string>
    {
        public Aspnetusers()
        {
            Id = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// 访问失败数
        /// </summary>
        public int AccessFailedCount { get; set; } = 0;

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 虚拟密钥
        /// </summary>
        public string AvatarKey { get; set; }

        ///// <summary>
        ///// 车辆ID
        ///// </summary>
        //public string CarId { get; set; }

        /// <summary>
        /// 承载类别
        /// </summary>
        public CarriageType CarriageType { get; set; }

        /// <summary>
        /// 承运人ID
        /// </summary>
        public string CarrierCarrierId { get; set; }

        /// <summary>
        /// 真实头像状态
        /// </summary>
        public CertificationStatus CertificatePhotoCertificationState { get; set; }

        /// <summary>
        /// 真实头像URL
        /// </summary>
        public string CertificatePhotoKey { get; set; }

        /// <summary>
        /// 真实头像修改时间
        /// </summary>
        public DateTime? CertificatePhotoDate { get; set; }

        public DateTime CertificationApplicationTime { get; set; }
        public DateTime CertificationTime { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string DeviceToken { get; set; }

        /// <summary>
        /// 驾驶证URL
        /// </summary>
        public string DrivingLicenseKey { get; set; }

        /// <summary>
        /// 驾驶证状态
        /// </summary>
        public CertificationStatus DrivingLicenseKeyCertificationState { get; set; }

        /// <summary>
        /// 驾驶证修改时间
        /// </summary>
        public DateTime? DrivingLicenseDate { get; set; }

        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public long FailureTime { get; set; }

        /// <summary>
        /// 身份证状态
        /// </summary>
        public CertificationStatus IdentityCardCertificationState { get; set; }

        /// <summary>
        /// 身份证URL
        /// </summary>
        public string IdentityCardKey { get; set; }

        /// <summary>
        /// 身份证修改时间
        /// </summary>
        public DateTime? IdentityCardDate { get; set; }

        public bool LockoutEnabled { get; set; }
        public string LockoutEnd { get; set; }
        public string NormalizedEmail { get; set; }
        public string NormalizedUserName { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        public string Profile { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        public string RealName { get; set; }
        public string SecurityStamp { get; set; }
        public string Token { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public string UserName { get; set; }

        /// <summary>
        /// 用户积分
        /// </summary>
        public int Integral { get; set; } = 0;

        /// <summary>
        /// 实名认证状态
        /// </summary>
        public CertificationStatus RealNameStatus { get; set; }

        /// <summary>
        /// 添加身份证ID
        /// </summary>
        public string AddingCommitId { get; set; }

        /// <summary>
        /// 车辆吨位
        /// </summary>
        public float AssignmentOfLoad { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool? CanTargeted { get; set; }

        /// <summary>
        /// 承运人ID
        /// </summary>
        public string CarrierId { get; set; }

        /// <summary>
        /// 认证状态
        /// </summary>
        public CertificationStatus CertificationStatus { get; set; }

        /// <summary>
        /// 车牌
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// 车长
        /// </summary>
        public CarLength Length { get; set; }

        /// <summary>
        /// 发动机号
        /// </summary>
        public string EngineNumber { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        public string VehicleIdentificationNumber { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        public string Origin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Rank { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// 挂车认证状态
        /// </summary>
        public CertificationStatus TrailerLicenseCertificationStatus { get; set; }

        /// <summary>
        /// 挂车Key
        /// </summary>
        public string TrailerLicenseKey { get; set; }

        /// <summary>
        /// 挂车证件修改时间
        /// </summary>
        public DateTime? TrailerLicenseDate { get; set; }


        /// <summary>
        /// 挂车号
        /// </summary>
        public string TrailerNumber { get; set; }

        /// <summary>
        /// 挂车车架号
        /// </summary>
        public string TrailerVIN { get; set; }

        /// <summary>
        /// 车型
        /// </summary>
        public VehicleType Type { get; set; }

        /// <summary>
        /// 行驶证
        /// </summary>
        public string VehicleLicenseKey { get; set; }

        /// <summary>
        /// 行驶证修改时间
        /// </summary>
        public DateTime? VehicleLicenseDate { get; set; }

        /// <summary>
        /// 车辆照片状态
        /// </summary>
        public CertificationStatus VehiclePhotoCertificationStatus { get; set; }

        /// <summary>
        /// 车辆照片
        /// </summary>
        public string VehiclePhotoKey { get; set; }

        /// <summary>
        /// 车辆照片修改时间
        /// </summary>
        public DateTime? VehiclePhotoDate { get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        public ApplicationRoleType RoleType { get; set; }

        /// <summary>
        /// 身份证
        /// </summary>
        public string Identity { get; set; }

        /// <summary>
        /// 道路许可证
        /// </summary>
        public string RoadTransportLicence { get; set; }

        /// <summary>
        /// 所属辖区
        /// </summary>
        public string Jurisdiction { get; set; }

        /// <summary>
        /// 道路运输证字号
        /// </summary>
        public string RoadTransportName { get; set; }

        /// <summary>
        /// 道路运输证
        /// </summary>
        public string RoadTransportKey { get; set; }

        /// <summary>
        /// 道路运输证状态
        /// </summary>
        public CertificationStatus RoadTransportStatus { get; set; }

        /// <summary>
        /// 道路运输证修改时间
        /// </summary>
        public DateTime? RoadTransportKeyDate { get; set; }

        /// <summary>
        /// 道路运输经营许可证
        /// </summary>
        public string BusinessLicenseKey { get; set; }

        /// <summary>
        /// 道路运输经营许可证状态
        /// </summary>
        public CertificationStatus BusinessLicenseStatus { get; set; }

        /// <summary>
        /// 道路运输经营许可证修改时间
        /// </summary>
        public DateTime? BusinessLicenseDate { get; set; }

        /// <summary>
        /// 从业资格证
        /// </summary>
        public string QualificationKey { get; set; }

        /// <summary>
        /// 从业资格证状态
        /// </summary>
        public CertificationStatus QualificationStatus { get; set; }

        /// <summary>
        /// 从业资格证修改时间
        /// </summary>
        public DateTime QualificationDate { get; set; }

        /// <summary>
        /// 提交者
        /// </summary>
        public string Committer { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// 车辆身份外键
        /// </summary>
        //public CarAddingModerationCommitInfo AddingCommitInfo { get; set; }

        /// <summary>
        /// 用户长运路线集合
        /// </summary>
        public List<CommonTransportLinkageInfo> CommonTransportLinkages { get; set; }

        /// <summary>
        /// 银行卡集合
        /// </summary>
        public  List<BankCardInfo> BankCards { get; set; }


        /// <summary>
        /// 最后支付的订单号
        /// </summary>
        public string LastPayOrderNum { get; set; }

        /// <summary>
        /// 保证金金额
        /// </summary>
        public decimal CashdepositTotalAmount { get; set; }

        /// <summary>
        /// 是否初始化
        /// </summary>
        public bool IsInit { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        public long TimeStamp { get; set; }

        /// <summary>
        /// 是否实名
        /// </summary>
        public RealState IsReal { get; set; }

        /// <summary>
        /// 微信OpenId
        /// </summary>
        public string WXOpenId { get; set; }

        /// <summary>
        /// 发证机关代码
        /// </summary>
        public string IdentityAreaCode { get; set; }

        /// <summary>
        /// 发证机关名称
        /// </summary>
        public string IdentityAreaName { get; set; }

        /// <summary>
        /// 用户人物属性
        /// </summary>
        public UsersCharacter UsersCharacter { get; set; } = UsersCharacter.None;

        /// <summary>
        /// 用户司机类型
        /// </summary>
        public UserCategory UserCategory { get; set; }


    }
}
