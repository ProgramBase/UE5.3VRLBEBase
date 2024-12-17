using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Synthesis
{
	public class FOnEnvelopeFollowerUpdate : FMulticastDelegate<Action<float>>
	{
		public FOnEnvelopeFollowerUpdate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnEnvelopeFollowerUpdate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

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
