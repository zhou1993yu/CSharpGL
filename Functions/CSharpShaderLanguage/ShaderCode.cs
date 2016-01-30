﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShaderLanguage
{
    /// <summary>
    /// 所有CSSL都共有的内容。
    /// </summary>
    public abstract partial class ShaderCode
    {

        /// <summary>
        /// 每个shader都必须实现自己的main函数。
        /// </summary>
        public abstract void main();

    }
}
