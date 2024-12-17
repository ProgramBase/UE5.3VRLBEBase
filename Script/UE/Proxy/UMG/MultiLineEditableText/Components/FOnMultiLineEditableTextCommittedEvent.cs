using System;
using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;

namespace Script.UMG.MultiLineEditableText
{
	public class FOnMultiLineEditableTextCommittedEvent : FMulticastDelegate<Action<FText, ETextCommit>>
	{
		public FOnMultiLineEditableTextCommittedEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnMultiLineEditableTextCommittedEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

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
