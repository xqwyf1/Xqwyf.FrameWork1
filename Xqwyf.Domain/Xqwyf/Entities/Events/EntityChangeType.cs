﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Xqwyf.Domain.Entities.Events
{

    /// <summary>
    /// 实体变更类型
    /// </summary>
    public enum EntityChangeType : byte
    {
        Created = 0,

        Updated = 1,

        Deleted = 2
    }
}
