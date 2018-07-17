namespace GTP_BulkRepositories
{
    /// <summary>
    /// 用户类别
    /// </summary>
    public enum UserCategory
    {
        /// <summary>
        /// 缺省值
        /// </summary>
        None = 0,
        
        /// <summary>
        /// 独立车主
        /// </summary>
        IndependentOwners = 1,

        /// <summary>
        ///合作车主 
        /// </summary>
        CooperationOwners = 2,
        
        /// <summary>
        /// 零担车主
        /// </summary>
        LclOwners = 3,

        /// <summary>
        /// 飓风员工
        /// </summary>
        JFEmployees = 4
    }
}
