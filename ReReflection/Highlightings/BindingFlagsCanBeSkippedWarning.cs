﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using JetBrains.DocumentModel;
using JetBrains.ReSharper.Daemon;
using JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.CSharp.Tree;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.TextControl.DocumentMarkup;

namespace ReReflection.Highlightings
{
    [StaticSeverityHighlighting(Severity.SUGGESTION, "Reflection")]
    public class BindingFlagsCanBeSkippedWarning : ReflectionHighlightingBase, IHighlighting
    {
        private readonly IMethod _method;
        private readonly IInvocationExpression _invocation;

        public BindingFlagsCanBeSkippedWarning(IMethod method, IInvocationExpression invocation)
        {
            _method = method;
            _invocation = invocation;
        }

        public string ToolTip
        {
            get
            {
                return string.Format("BindingFlags may be skipped.");
            }
        }

        public string ErrorStripeToolTip
        {
            get
            {
                return ToolTip;
            }
        }

        public IMethod Method
        {
            get
            {
                return _method;
            }
        }

        public IInvocationExpression Invocation
        {
            get
            {
                return _invocation;
            }
        }

        public override bool IsValid()
        {
            //Will work only for Get{Method|Property|Field}(string name, BindingFlags flags) overload
            return Invocation.IsValid() && _method.Parameters.Count == 2;
        }

        public override DocumentRange CalculateRange()
        {
            return _invocation.Arguments[1].GetDocumentRange();
        }
    }
}
