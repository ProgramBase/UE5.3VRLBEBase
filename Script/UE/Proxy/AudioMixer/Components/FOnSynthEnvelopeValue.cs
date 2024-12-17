using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.AudioMixer
{
	public class FOnSynthEnvelopeValue : FMulticastDelegate<Action<float>>
	{
		public FOnSynthEnvelopeValue() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnSynthEnvelopeValue() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(float EnvelopeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = EnvelopeValue;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
