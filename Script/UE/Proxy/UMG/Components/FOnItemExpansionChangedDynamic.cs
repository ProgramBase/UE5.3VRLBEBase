using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	public class FOnItemExpansionChangedDynamic : FMulticastDelegate<Action<UObject, bool>>
	{
		public FOnItemExpansionChangedDynamic() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnItemExpansionChangedDynamic() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UObject Item, bool bIsExpanded)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Item?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIsExpanded;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
