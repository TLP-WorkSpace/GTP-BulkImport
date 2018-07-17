using System.ComponentModel;

namespace GTP_BulkRepositories
{
    /// <summary>
    /// 车长
    /// </summary>
    public enum CarLength
    {
        /// <summary>
        /// 缺省值
        /// </summary>
        [Description("缺省值")]
        None = 0,
        /// <summary>
        /// 4.2米
        /// </summary>
        [Description("4.2米")]
        L42 = 1,
        /// <summary>
        /// 5.8米
        /// </summary>
        [Description("5.8米")]
        L58 = 2,
        /// <summary>
        /// 6.0米
        /// </summary>
        [Description("6.0米")]
        L60 = 3,
        /// <summary>
        /// 6.2米
        /// </summary>
        [Description("6.2米")]
        L62 = 4,
        /// <summary>
        /// 6.5米
        /// </summary>
        [Description("6.5米")]
        L65 = 5,
        /// <summary>
        /// 6.8米
        /// </summary>
        [Description("6.8米")]
        L68 = 6,
        /// <summary>
        /// 7.6米
        /// </summary>
        [Description("7.6米")]
        L76 = 7,
        /// <summary>
        /// 8.6米
        /// </summary>
        [Description("8.6米")]
        L86 = 8,
        /// <summary>
        /// 8.7米
        /// </summary>
        [Description("8.7米")]
        L87 = 9,
        /// <summary>
        /// 9.6米
        /// </summary>
        [Description("9.6米")]
        L96 = 10,
        /// <summary>
        /// 13米
        /// </summary>
        [Description("13米")]
        L130 = 11,
        /// <summary>
        /// 13.5米
        /// </summary>
        [Description("13.5米")]
        L135 = 12,
        /// <summary>
        /// 16米
        /// </summary>
        [Description("16米")]
        L160 = 13,
        /// <summary>
        /// 17.5米
        /// </summary>
        [Description("17.5米")]
        L175 = 14,
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        Other = 15
    }
}
