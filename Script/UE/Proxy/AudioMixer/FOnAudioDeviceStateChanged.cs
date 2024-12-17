using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.AudioMixer
{
	public class FOnAudioDeviceStateChanged : FMulticastDelegate<Action<FString, EAudioDeviceChangedState>>
	{
		public FOnAudioDeviceStateChanged() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnAudioDeviceStateChanged() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FString DeviceId, EAudioDeviceChangedState NewState)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = DeviceId?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)NewState;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
