using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Engine
{
	public class FOnQuartzCommandEventBP : FDelegate<Action<EQuartzCommandDelegateSubType, FName>>
	{
		public FOnQuartzCommandEventBP() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnQuartzCommandEventBP() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(EQuartzCommandDelegateSubType EventType, FName Name)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(byte*)(__InBuffer) = (byte)EventType;

				*(nint*)(__InBuffer + 1) = Name?.GarbageCollectionHandle ?? nint.Zero;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
