using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnPawnControllerChanged : FMulticastDelegate<Action<APawn, AController>>
	{
		public FOnPawnControllerChanged() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnPawnControllerChanged() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(APawn Pawn, AController Controller)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Pawn?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Controller?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
