using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.NavigationSystem
{
	public class FOnNavigationPathUpdated : FMulticastDelegate<Action<UNavigationPath, ENavPathEvent>>
	{
		public FOnNavigationPathUpdated() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnNavigationPathUpdated() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UNavigationPath AffectedPath, ENavPathEvent PathEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = AffectedPath?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)PathEvent;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
