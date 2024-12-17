using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnUserInputDeviceConnectionChange : FMulticastDelegate<Action<EInputDeviceConnectionState, FPlatformUserId, FInputDeviceId>>
	{
		public FOnUserInputDeviceConnectionChange() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnUserInputDeviceConnectionChange() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(EInputDeviceConnectionState NewConnectionState, FPlatformUserId PlatformUserId, FInputDeviceId InputDeviceId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(byte*)(__InBuffer) = (byte)NewConnectionState;

				*(nint*)(__InBuffer + 1) = PlatformUserId?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 9) = InputDeviceId?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
