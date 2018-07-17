namespace GTP_BulkRepositories
{
    /// <summary>
    /// 实名认证状态
    /// </summary>
    public enum CertificationStatus
    {
        /// <summary>
        /// 缺省值
        /// </summary>
        None = 0,
        /// <summary>
        /// 未提交
        /// </summary>
        Uncommitted = 1,
        /// <summary>
        /// 审核中
        /// </summary>
        Pending = 2,
        /// <summary>
        /// 已通过
        /// </summary>
        Passed = 3,
        /// <summary>
        /// 未通过
        /// </summary>
        Rejected = 4
    }
}