using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnForceFeedbackFinished : FMulticastDelegate<Action<UForceFeedbackComponent>>
	{
		public FOnForceFeedbackFinished() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnForceFeedbackFinished() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UForceFeedbackComponent ForceFeedbackComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ForceFeedbackComponent?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
