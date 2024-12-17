using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Engine.PlatformGameInstance
{
	public class FPlatformScreenOrientationChangedDelegate : FMulticastDelegate<Action<EScreenOrientation>>
	{
		public FPlatformScreenOrientationChangedDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FPlatformScreenOrientationChangedDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(EScreenOrientation inScreenOrientation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)inScreenOrientation;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
