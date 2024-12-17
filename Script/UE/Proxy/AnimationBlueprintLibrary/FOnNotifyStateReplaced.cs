using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimationBlueprintLibrary
{
	public class FOnNotifyStateReplaced : FDelegate<Action<UAnimNotifyState, UAnimNotifyState>>
	{
		public FOnNotifyStateReplaced() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnNotifyStateReplaced() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(UAnimNotifyState OldNotifyState, UAnimNotifyState NewNotifyState)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OldNotifyState?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewNotifyState?.GarbageCollectionHandle ?? nint.Zero;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
