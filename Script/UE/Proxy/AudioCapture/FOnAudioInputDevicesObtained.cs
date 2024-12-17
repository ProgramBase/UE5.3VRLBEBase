using System;
using Script.CoreUObject;
using Script.Library;
using Script.AudioCapture;

namespace Script.AudioCapture
{
	public class FOnAudioInputDevicesObtained : FDelegate<Action<TArray<FAudioInputDeviceInfo>>>
	{
		public FOnAudioInputDevicesObtained() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnAudioInputDevicesObtained() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(TArray<FAudioInputDeviceInfo> AvailableDevices)
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
