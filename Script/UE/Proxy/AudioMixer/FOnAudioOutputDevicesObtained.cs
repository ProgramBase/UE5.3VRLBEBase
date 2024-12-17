using System;
using Script.CoreUObject;
using Script.Library;
using Script.AudioMixer;

namespace Script.AudioMixer
{
	public class FOnAudioOutputDevicesObtained : FDelegate<Action<TArray<FAudioOutputDeviceInfo>>>
	{
		public FOnAudioOutputDevicesObtained() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnAudioOutputDevicesObtained() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(TArray<FAudioOutputDeviceInfo> AvailableDevices)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AvailableDevices?.GarbageCollectionHandle ?? nint.Zero;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
