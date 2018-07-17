using System.ComponentModel;

namespace GTP_BulkRepositories
{
    /// <summary>
    /// 价格单位
    /// </summary>
    public enum PriceUnit
    {
        /// <summary>
        /// 缺省值
        /// </summary>
        [Description("缺省值")]
        None = 0,

        /// <summary>
        /// 元/车
        /// </summary>
        [Description("元/车")]
        YPCar = 1,

        /// <summary>
        /// 元/吨
        /// </summary>
        [Description("元/吨")]
        YPTon = 2,

        /// <summary>
        /// 元/立方
        /// </summary>
        [Description("元/立方")]
        YPCube = 3,

        /// <summary>
        /// 元/件
        /// </summary>
        [Description("元/件")]
        YPItem = 4,

        /// <summary>
        /// 元/公里
        /// </summary>
        [Description("元/公里")]
        YPKM = 5,

        /// <summary>
        /// 元/工程
        /// </summary>
        [Description("元/工程")]
        YPProject = 6,

        /// <summary>
        /// 元/吨*公里
        /// </summary>
        [Description("元/吨*公里")]
        YPTKM = 7
    }
}
