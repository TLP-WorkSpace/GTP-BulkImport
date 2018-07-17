namespace GTP_BulkRepositories
{
    /// <summary>
    /// 订单类型
    /// </summary>
    public enum OrderType
    {
        /// <summary>
        /// 缺省值
        /// </summary>
        None = 0,
        /// <summary>
        /// 整单
        /// </summary>
        Bulk = 1,
        /// <summary>
        /// 零担
        /// </summary>
        Breakbulk = 2,
        /// <summary>
        /// 子订单
        /// </summary>
        Suborder = 3
    }
}
