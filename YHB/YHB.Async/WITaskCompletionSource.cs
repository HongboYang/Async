using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace YHB.Async
{
    public class WITaskCompletionSource<T> : ICriticalNotifyCompletion
    {
        public WITask<T> Task => new WITask<T>();
        public void OnCompleted(Action continuation)
        {
        }

        public void UnsafeOnCompleted(Action continuation)
        {
        }

        public void SetException(Exception e)
        {

        }

        public void SetResult(T ret)
        {

        }
    }
}
