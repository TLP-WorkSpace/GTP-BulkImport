using System;
using System.Collections.Generic;
using System.Text;

namespace GTP_BulkRepositories
{
    public enum RealState
    {
        /// <summary>
        /// 缺省值
        /// </summary>
        None = 0,

        /// <summary>
        /// 未认证
        /// </summary>
        Not = 1,

        /// <summary>
        /// 认证失败
        /// </summary>
        Fail = 2,

        /// <summary>
        /// 认证成功
        /// </summary>
        Success = 3
    }
}
