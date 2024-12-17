using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	public class FOnItemIsHoveredChangedDynamic : FMulticastDelegate<Action<UObject, bool>>
	{
		public FOnItemIsHoveredChangedDynamic() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnItemIsHoveredChangedDynamic() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UObject Item, bool bIsHovered)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Item?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIsHovered;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
