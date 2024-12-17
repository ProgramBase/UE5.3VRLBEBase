using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnTimelineVector : FDelegate<Action<FVector>>
	{
		public FOnTimelineVector() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnTimelineVector() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(FVector Output)
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
