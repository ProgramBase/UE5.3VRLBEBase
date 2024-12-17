using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnTimelineLinearColor : FDelegate<Action<FLinearColor>>
	{
		public FOnTimelineLinearColor() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnTimelineLinearColor() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(FLinearColor Output)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Output?.GarbageCollectionHandle ?? nint.Zero;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
