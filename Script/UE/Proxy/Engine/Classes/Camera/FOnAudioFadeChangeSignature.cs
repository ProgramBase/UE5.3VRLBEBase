using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnAudioFadeChangeSignature : FMulticastDelegate<Action<bool, float>>
	{
		public FOnAudioFadeChangeSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnAudioFadeChangeSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(bool bFadeOut, float FadeTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(bool*)(__InBuffer) = bFadeOut;

				*(float*)(__InBuffer + 1) = FadeTime;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
