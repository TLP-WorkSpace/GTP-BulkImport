namespace GTP_BulkRepositories
{
    /// <summary>
    /// 订单状态
    /// </summary>
    public enum OrderState
    {
        /// <summary>
        /// 缺省值
        /// </summary>
        None = 0, 
        /// <summary>
        /// 待运
        /// </summary>
        Waiting = 1,
        /// <summary>
        /// 在途
        /// </summary>
        Shipping = 2,
        /// <summary>
        /// 已送达
        /// </summary>
        Completed = 3052,
        /// <summary>
        /// 已结算
        /// </summary>
        Settled = 4
    }
}
