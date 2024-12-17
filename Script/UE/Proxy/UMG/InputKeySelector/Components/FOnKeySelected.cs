using System;
using Script.CoreUObject;
using Script.Library;
using Script.Slate;

namespace Script.UMG.InputKeySelector
{
	public class FOnKeySelected : FMulticastDelegate<Action<FInputChord>>
	{
		public FOnKeySelected() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnKeySelected() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FInputChord SelectedKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SelectedKey?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
