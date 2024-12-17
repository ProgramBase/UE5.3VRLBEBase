using System;
using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;

namespace Script.UMG.ComboBoxKey
{
	public class FOnSelectionChangedEvent : FMulticastDelegate<Action<FName, ESelectInfo>>
	{
		public FOnSelectionChangedEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnSelectionChangedEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FName SelectedItem, ESelectInfo SelectionType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = SelectedItem?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)SelectionType;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
