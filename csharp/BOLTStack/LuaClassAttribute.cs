﻿using System;

namespace BOLTStack
{
    public enum CreatePolicy { Factory, Singleton }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class LuaClassAttribute : Attribute
    {
        public CreatePolicy CreatePolicy { get; private set; }

        public LuaClassAttribute(CreatePolicy policy)
        {
            CreatePolicy = policy;
        }
    }
}