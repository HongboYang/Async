using System;
using System.Collections.Generic;
using System.Text;

namespace System.Runtime.CompilerServices
{
#if !NOT_CLIENT
    public sealed class AsyncMethodBuilderAttribute : Attribute
    {
        public Type BuilderType { get; }

        public AsyncMethodBuilderAttribute(Type type)
        {
            BuilderType = type;
        }
    }
#endif
}
