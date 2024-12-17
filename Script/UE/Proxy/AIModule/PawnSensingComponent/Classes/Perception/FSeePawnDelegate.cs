using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AIModule.PawnSensingComponent
{
	public class FSeePawnDelegate : FMulticastDelegate<Action<APawn>>
	{
		public FSeePawnDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FSeePawnDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(APawn Pawn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Pawn?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
