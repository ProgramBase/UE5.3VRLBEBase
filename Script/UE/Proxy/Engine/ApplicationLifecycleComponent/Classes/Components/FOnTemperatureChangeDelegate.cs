using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Engine.ApplicationLifecycleComponent
{
	public class FOnTemperatureChangeDelegate : FMulticastDelegate<Action<ETemperatureSeverityType>>
	{
		public FOnTemperatureChangeDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnTemperatureChangeDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(ETemperatureSeverityType Severity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)Severity;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
