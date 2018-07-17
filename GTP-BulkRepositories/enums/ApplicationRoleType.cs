using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GTP_BulkRepositories
{
    public enum ApplicationRoleType
    {
        /// <summary>
        /// 缺省值
        /// </summary>
        None,

        /// <summary>
        /// 承运商
        /// </summary>
        Carrier,

        /// <summary>
        /// 系统管理员
        /// </summary>
        Administator,

        /// <summary>
        /// 司机
        /// </summary>
        Driver
    }
}
