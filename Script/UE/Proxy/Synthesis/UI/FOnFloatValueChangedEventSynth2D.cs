using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Synthesis
{
	public class FOnFloatValueChangedEventSynth2D : FMulticastDelegate<Action<float>>
	{
		public FOnFloatValueChangedEventSynth2D() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnFloatValueChangedEventSynth2D() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

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
