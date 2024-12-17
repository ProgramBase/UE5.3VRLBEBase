using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG.SpinBox
{
	public class FOnSpinBoxValueChangedEvent : FMulticastDelegate<Action<float>>
	{
		public FOnSpinBoxValueChangedEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnSpinBoxValueChangedEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(float InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InValue;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
