using System;
using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;

namespace Script.UMG.EditableTextBox
{
	public class FOnEditableTextBoxCommittedEvent : FMulticastDelegate<Action<FText, ETextCommit>>
	{
		public FOnEditableTextBoxCommittedEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnEditableTextBoxCommittedEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FText Text, ETextCommit CommitMethod)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Text?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)CommitMethod;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
