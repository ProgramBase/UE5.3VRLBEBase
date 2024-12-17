using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.AndroidPermission
{
	public class FAndroidPermissionDynamicDelegate : FMulticastDelegate<Action<TArray<FString>, TArray<bool>>>
	{
		public FAndroidPermissionDynamicDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FAndroidPermissionDynamicDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(TArray<FString> Permissions, TArray<bool> GrantResults)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Permissions?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = GrantResults?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
