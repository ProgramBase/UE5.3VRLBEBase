using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnAudioSingleEnvelopeValue : FMulticastDelegate<Action<USoundWave, float>>
	{
		public FOnAudioSingleEnvelopeValue() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnAudioSingleEnvelopeValue() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(USoundWave PlayingSoundWave, float EnvelopeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = PlayingSoundWave?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = EnvelopeValue;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
