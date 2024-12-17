using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine.PlatformEventsComponent
{
	public class FPlatformEventDelegate : FMulticastDelegate<Action>
	{
		public FPlatformEventDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FPlatformEventDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
