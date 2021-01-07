using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace YHB.Async
{
    [AsyncMethodBuilder(typeof(WIAsyncTaskMethodBuilder<>))]
    public struct WITask<T>
    {
        private readonly WITaskCompletionSource<T> _awaiter;

        [DebuggerHidden]
        public WITask(WITaskCompletionSource<T> awaiter)
        {
            _awaiter = awaiter;
        }

        [DebuggerHidden]
        public WITaskCompletionSource<T> GetAwaiter()
        {
            return _awaiter;
        }

    }
}
