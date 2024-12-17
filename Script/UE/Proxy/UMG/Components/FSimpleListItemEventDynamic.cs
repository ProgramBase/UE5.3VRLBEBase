using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	public class FSimpleListItemEventDynamic : FMulticastDelegate<Action<UObject>>
	{
		public FSimpleListItemEventDynamic() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FSimpleListItemEventDynamic() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UObject Item)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Item?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
