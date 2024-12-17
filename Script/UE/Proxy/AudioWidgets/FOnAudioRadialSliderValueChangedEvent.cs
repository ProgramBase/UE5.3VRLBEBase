using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.AudioWidgets
{
	public class FOnAudioRadialSliderValueChangedEvent : FMulticastDelegate<Action<float>>
	{
		public FOnAudioRadialSliderValueChangedEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnAudioRadialSliderValueChangedEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Value;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
