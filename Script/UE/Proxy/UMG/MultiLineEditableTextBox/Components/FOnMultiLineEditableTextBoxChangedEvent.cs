using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG.MultiLineEditableTextBox
{
	public class FOnMultiLineEditableTextBoxChangedEvent : FMulticastDelegate<Action<FText>>
	{
		public FOnMultiLineEditableTextBoxChangedEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnMultiLineEditableTextBoxChangedEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FText Text)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Text?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
