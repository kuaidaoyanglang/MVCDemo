﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCDemo.Models;

namespace MVCDemo.IDAL
{
    /// <summary>
    /// 文章接口
    /// <remarks>
    /// 创建：2015.04.07
    /// </remarks>
    /// </summary>
    public interface InterfaceArticleRepository :InterfaceBaseRepository<Article>
    {
    }
}
