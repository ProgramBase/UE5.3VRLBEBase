using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	public class FOnButtonClickedEvent : FMulticastDelegate<Action>
	{
		public FOnButtonClickedEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnButtonClickedEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
