using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	public class FOnListEntryInitializedDynamic : FMulticastDelegate<Action<UObject, UUserWidget>>
	{
		public FOnListEntryInitializedDynamic() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnListEntryInitializedDynamic() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UObject Item, UUserWidget Widget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Item?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
