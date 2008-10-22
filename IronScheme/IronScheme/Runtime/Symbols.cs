#region License
/* ****************************************************************************
 * Copyright (c) Llewellyn Pritchard. 
 *
 * This source code is subject to terms and conditions of the Microsoft Public License. 
 * A copy of the license can be found in the License.html file at the root of this distribution. 
 * By using this source code in any fashion, you are agreeing to be bound by the terms of the 
 * Microsoft Public License.
 *
 * You must not remove this notice, or any other, from this software.
 * ***************************************************************************/
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Scripting.Math;
using System.Reflection;
using Microsoft.Scripting.Utils;
using System.Collections;
using Microsoft.Scripting;
using System.IO;

namespace IronScheme.Runtime
{
  public partial class Builtins
  {
    [Builtin("symbol?")]
    public static object IsSymbol(object obj)
    {
      return GetBool(obj is SymbolId);
    }

    [Builtin("symbol->string")]
    public static string SymbolToString(object obj)
    {
      SymbolId s = RequiresNotNull<SymbolId>(obj);
      return SymbolTable.IdToString(s);
    }

    [Builtin("string->symbol")]
    public static object StringToSymbol(object obj)
    {
      string s = RequiresNotNull<string>(obj);
      return SymbolTable.StringToId(s);
    }

  }
}
