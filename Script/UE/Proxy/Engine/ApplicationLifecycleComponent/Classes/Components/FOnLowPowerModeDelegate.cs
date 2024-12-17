using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine.ApplicationLifecycleComponent
{
	public class FOnLowPowerModeDelegate : FMulticastDelegate<Action<bool>>
	{
		public FOnLowPowerModeDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnLowPowerModeDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(bool bInLowPowerMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInLowPowerMode;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
