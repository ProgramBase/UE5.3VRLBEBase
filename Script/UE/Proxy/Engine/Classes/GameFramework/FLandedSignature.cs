using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FLandedSignature : FMulticastDelegate<Action<FHitResult>>
	{
		public FLandedSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FLandedSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FHitResult Hit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Hit?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
