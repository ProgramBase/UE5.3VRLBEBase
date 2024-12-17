using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimationBlueprintLibrary
{
	public class FOnNotifyReplaced : FDelegate<Action<UAnimNotify, UAnimNotify>>
	{
		public FOnNotifyReplaced() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnNotifyReplaced() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(UAnimNotify OldNotify, UAnimNotify NewNotify)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OldNotify?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewNotify?.GarbageCollectionHandle ?? nint.Zero;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
