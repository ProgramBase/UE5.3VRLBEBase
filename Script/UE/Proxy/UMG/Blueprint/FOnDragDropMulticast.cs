using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	public class FOnDragDropMulticast : FMulticastDelegate<Action<UDragDropOperation>>
	{
		public FOnDragDropMulticast() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnDragDropMulticast() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UDragDropOperation Operation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Operation?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
