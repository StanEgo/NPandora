﻿using System;

namespace Codesophy.Code.Sql
{
    /// <summary>
    /// TODO:
    /// </summary>
    public class SqlFunctionExpression
        : SqlExpression
        , IFunctionExpression
    {
        /// <summary>
        /// TODO:
        /// </summary>
        ISignatureExpression IFunctionExpression.Signature => throw new NotImplementedException();
    }
}
