using System;
using Script.CoreUObject;
using Script.Library;
using Script.TypedElementRuntime;

namespace Script.TypedElementRuntime.TypedElementSelectionSet
{
	public class FOnChangeDynamic : FMulticastDelegate<Action<UTypedElementSelectionSet>>
	{
		public FOnChangeDynamic() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnChangeDynamic() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UTypedElementSelectionSet SelectionSet)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SelectionSet?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
