
//------------------------------------------------------------------------------
// This code was generated by a tool.
//
//   Tool : Bond Compiler 0.4.1.0
//   File : StackFrame_types.cs
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// <auto-generated />
//------------------------------------------------------------------------------


// suppress "Missing XML comment for publicly visible type or member"
#pragma warning disable 1591


#region ReSharper warnings
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable UnusedParameter.Local
// ReSharper disable RedundantUsingDirective
#endregion

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.External
{
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    
    
    [System.CodeDom.Compiler.GeneratedCode("gbc", "0.4.1.0")]
    internal partial class StackFrame
    {
        
        
        public int level { get; set; }

        
        
        
        public string method { get; set; }

        
        
        
        public string assembly { get; set; }

        
        
        
        public string fileName { get; set; }

        
        
        public int line { get; set; }

        public StackFrame()
            : this("AI.StackFrame", "StackFrame")
        {}

        protected StackFrame(string fullName, string name)
        {
            method = "";
            assembly = "";
            fileName = "";
        }
    }
} // AI