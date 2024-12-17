using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnAudioMultiEnvelopeValue : FMulticastDelegate<Action<float, float, int>>
	{
		public FOnAudioMultiEnvelopeValue() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnAudioMultiEnvelopeValue() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(float AverageEnvelopeValue, float MaxEnvelope, int NumWaveInstances)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = AverageEnvelopeValue;

				*(float*)(__InBuffer + 4) = MaxEnvelope;

				*(int*)(__InBuffer + 8) = NumWaveInstances;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
