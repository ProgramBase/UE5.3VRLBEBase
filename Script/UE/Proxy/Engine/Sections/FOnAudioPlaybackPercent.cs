using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnAudioPlaybackPercent : FMulticastDelegate<Action<USoundWave, float>>
	{
		public FOnAudioPlaybackPercent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnAudioPlaybackPercent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(USoundWave PlayingSoundWave, float PlaybackPercent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = PlayingSoundWave?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = PlaybackPercent;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
