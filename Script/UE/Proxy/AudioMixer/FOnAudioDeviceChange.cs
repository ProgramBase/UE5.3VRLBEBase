using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.AudioMixer
{
	public class FOnAudioDeviceChange : FMulticastDelegate<Action<FString>>
	{
		public FOnAudioDeviceChange() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnAudioDeviceChange() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FString DeviceId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DeviceId?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
