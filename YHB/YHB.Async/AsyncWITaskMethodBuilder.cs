using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;

namespace YHB.Async
{
    public struct WIAsyncTaskMethodBuilder<T>
    {
        public WITaskCompletionSource<T> Tcs;

        // 1. Static Create method.
        [DebuggerHidden]
        public static WIAsyncTaskMethodBuilder<T> Create()
        {
            WIAsyncTaskMethodBuilder<T> builder = new WIAsyncTaskMethodBuilder<T>() { Tcs = new WITaskCompletionSource<T>() };
            return builder;
        }

        // 2. TaskLike Task property.
        [DebuggerHidden]
        public WITask<T> Task => this.Tcs.Task;

        // 3. SetException
        [DebuggerHidden]
        public void SetException(Exception exception)
        {
            this.Tcs.SetException(exception);
        }

        // 4. SetResult
        [DebuggerHidden]
        public void SetResult(T ret)
        {
            this.Tcs.SetResult(ret);
        }

        // 5. AwaitOnCompleted
        [DebuggerHidden]
        public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where
            TAwaiter : INotifyCompletion where TStateMachine : IAsyncStateMachine
        {
            awaiter.OnCompleted(stateMachine.MoveNext);
        }

        // 6. AwaitUnsafeOnCompleted
        [DebuggerHidden]
        [SecuritySafeCritical]
        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
        {
            awaiter.UnsafeOnCompleted(stateMachine.MoveNext);
        }

        // 7. Start
        [DebuggerHidden]
        public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
        {
            stateMachine.MoveNext();
        }

        // 8. SetStateMachine
        [DebuggerHidden]
        public void SetStateMachine(IAsyncStateMachine stateMachine)
        {
        }
    }
}
