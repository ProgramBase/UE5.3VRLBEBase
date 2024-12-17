using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.TakesCore.TakesCoreBlueprintLibrary
{
	public class FOnTakeRecorderSlateChanged : FDelegate<Action<FString>>
	{
		public FOnTakeRecorderSlateChanged() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnTakeRecorderSlateChanged() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(FString Slate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Slate?.GarbageCollectionHandle ?? nint.Zero;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
