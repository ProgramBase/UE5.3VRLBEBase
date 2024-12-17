using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FPhysicsVolumeChanged : FMulticastDelegate<Action<APhysicsVolume>>
	{
		public FPhysicsVolumeChanged() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FPhysicsVolumeChanged() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(APhysicsVolume NewVolume)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewVolume?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
