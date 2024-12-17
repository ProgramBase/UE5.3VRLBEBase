using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.MobilePatchingUtils
{
	public class FOnContentInstallFailed : FDelegate<Action<FText, int>>
	{
		public FOnContentInstallFailed() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnContentInstallFailed() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

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
