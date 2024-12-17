using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FHardwareInputDeviceChanged : FMulticastDelegate<Action<FPlatformUserId, FInputDeviceId>>
	{
		public FHardwareInputDeviceChanged() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FHardwareInputDeviceChanged() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FPlatformUserId UserId, FInputDeviceId DeviceId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = UserId?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DeviceId?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
