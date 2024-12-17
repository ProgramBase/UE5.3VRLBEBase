using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	public class FOnButtonPressedEvent : FMulticastDelegate<Action>
	{
		public FOnButtonPressedEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnButtonPressedEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
