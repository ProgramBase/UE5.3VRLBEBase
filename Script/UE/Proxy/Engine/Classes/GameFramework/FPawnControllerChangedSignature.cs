using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FPawnControllerChangedSignature : FMulticastDelegate<Action<APawn, AController, AController>>
	{
		public FPawnControllerChangedSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FPawnControllerChangedSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(APawn Pawn, AController OldController, AController NewController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Pawn?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OldController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NewController?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
