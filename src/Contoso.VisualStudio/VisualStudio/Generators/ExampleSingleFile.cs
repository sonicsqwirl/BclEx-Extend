﻿using System;
using System.CodeDom;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Contoso.VisualStudio.Generators
{
    /// <summary>
    /// ExampleSingleFile
    /// </summary>
    [ComVisible(true)]
    [Guid("52A7B6C6-E3DA-4bfa-A27C-8F1CEFA3DDC8")]
    public class ExampleSingleFile : VsSingleFileGeneratorWithSite
    {
        /// <summary>
        /// Generates the content.
        /// </summary>
        /// <param name="inputFileName">Name of the input file.</param>
        /// <param name="inputFileContent">Content of the input file.</param>
        /// <returns></returns>
        protected override byte[] GenerateContent(string inputFileName, string inputFileContent)
        {
            return Encoding.ASCII.GetBytes("Example:" + inputFileName);
            //var code = new CodeCompileUnit();
            //var codeNamespace = new CodeNamespace(DefaultNamespace);
            //code.Namespaces.Add(codeNamespace);
            //codeNamespace.Imports.Add(new CodeNamespaceImport("System"));
            //codeNamespace.Comments.Add(new CodeCommentStatement { Comment = new CodeComment { Text = "TEST" } });
            //using (var w = new StringWriter())
            //{
            //    CodeProvider.GenerateCodeFromCompileUnit(code, w, null);
            //    return Encoding.ASCII.GetBytes(w.ToString());
            //}
        }
    }
}
