using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FEmptyOnlineDelegate : FMulticastDelegate<Action>
	{
		public FEmptyOnlineDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FEmptyOnlineDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
