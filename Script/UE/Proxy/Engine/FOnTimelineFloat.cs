using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnTimelineFloat : FDelegate<Action<float>>
	{
		public FOnTimelineFloat() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnTimelineFloat() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(float Output)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Output;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
