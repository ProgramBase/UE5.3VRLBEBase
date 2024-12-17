using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.MobilePatchingUtils
{
	public class FOnRequestContentFailed : FDelegate<Action<FText, int>>
	{
		public FOnRequestContentFailed() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnRequestContentFailed() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(FText ErrorText, int ErrorCode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = ErrorText?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = ErrorCode;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
