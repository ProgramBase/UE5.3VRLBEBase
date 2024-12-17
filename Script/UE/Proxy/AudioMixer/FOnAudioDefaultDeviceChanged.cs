using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.AudioMixer
{
	public class FOnAudioDefaultDeviceChanged : FMulticastDelegate<Action<EAudioDeviceChangedRole, FString>>
	{
		public FOnAudioDefaultDeviceChanged() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnAudioDefaultDeviceChanged() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(EAudioDeviceChangedRole AudioDeviceRole, FString DeviceId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(byte*)(__InBuffer) = (byte)AudioDeviceRole;

				*(nint*)(__InBuffer + 1) = DeviceId?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
