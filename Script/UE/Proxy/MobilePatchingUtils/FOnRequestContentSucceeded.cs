using System;
using Script.CoreUObject;
using Script.Library;
using Script.MobilePatchingUtils;

namespace Script.MobilePatchingUtils
{
	public class FOnRequestContentSucceeded : FDelegate<Action<UMobilePendingContent>>
	{
		public FOnRequestContentSucceeded() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnRequestContentSucceeded() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(UMobilePendingContent MobilePendingContent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MobilePendingContent?.GarbageCollectionHandle ?? nint.Zero;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
