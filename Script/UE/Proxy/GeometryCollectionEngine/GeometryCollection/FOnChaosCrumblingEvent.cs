using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.GeometryCollectionEngine
{
	public class FOnChaosCrumblingEvent : FMulticastDelegate<Action<FChaosCrumblingEvent>>
	{
		public FOnChaosCrumblingEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnChaosCrumblingEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FChaosCrumblingEvent CrumbleEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = CrumbleEvent?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
