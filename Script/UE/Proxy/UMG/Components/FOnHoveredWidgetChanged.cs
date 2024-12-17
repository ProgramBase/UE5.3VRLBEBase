using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	public class FOnHoveredWidgetChanged : FMulticastDelegate<Action<UWidgetComponent, UWidgetComponent>>
	{
		public FOnHoveredWidgetChanged() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnHoveredWidgetChanged() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UWidgetComponent WidgetComponent, UWidgetComponent PreviousWidgetComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WidgetComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PreviousWidgetComponent?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
