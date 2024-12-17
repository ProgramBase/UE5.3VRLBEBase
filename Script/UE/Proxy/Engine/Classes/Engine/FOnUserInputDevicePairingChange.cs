using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnUserInputDevicePairingChange : FMulticastDelegate<Action<FInputDeviceId, FPlatformUserId, FPlatformUserId>>
	{
		public FOnUserInputDevicePairingChange() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnUserInputDevicePairingChange() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FInputDeviceId InputDeviceId, FPlatformUserId NewUserPlatformId, FPlatformUserId OldUserPlatformId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InputDeviceId?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewUserPlatformId?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OldUserPlatformId?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
