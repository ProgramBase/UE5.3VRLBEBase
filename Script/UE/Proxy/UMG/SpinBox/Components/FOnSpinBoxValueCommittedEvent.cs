using System;
using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;

namespace Script.UMG.SpinBox
{
	public class FOnSpinBoxValueCommittedEvent : FMulticastDelegate<Action<float, ETextCommit>>
	{
		public FOnSpinBoxValueCommittedEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnSpinBoxValueCommittedEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(float InValue, ETextCommit CommitMethod)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = InValue;

				*(byte*)(__InBuffer + 4) = (byte)CommitMethod;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
