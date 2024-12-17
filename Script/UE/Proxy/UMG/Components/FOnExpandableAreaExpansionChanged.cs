using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	public class FOnExpandableAreaExpansionChanged : FMulticastDelegate<Action<UExpandableArea, bool>>
	{
		public FOnExpandableAreaExpansionChanged() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnExpandableAreaExpansionChanged() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UExpandableArea Area, bool bIsExpanded)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Area?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIsExpanded;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
