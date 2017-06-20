﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Roslynator.CSharp.CodeFixes.Test
{
    internal static class AddStaticModifier
    {
        public static class Foo
        {
            public void Bar()
            {
            }

            public void Bar2()
            {
            }
        }

        private string _fieldName;

        public void MethodName()
        {
        }

        AddStaticModifier()
        {
        }

        public string PropertyName { get; set; }

        public event EventHandler EventName;

        public event EventHandler EventName2
        {
            add { }
            remove { }
        }

        private class ClassName
        {
            public void MethodName()
            {
            }
        }
    }
}