using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	public class FOnButtonReleasedEvent : FMulticastDelegate<Action>
	{
		public FOnButtonReleasedEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnButtonReleasedEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
