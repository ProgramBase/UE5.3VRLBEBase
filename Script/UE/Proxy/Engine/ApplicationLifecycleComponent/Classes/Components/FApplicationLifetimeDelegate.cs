using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine.ApplicationLifecycleComponent
{
	public class FApplicationLifetimeDelegate : FMulticastDelegate<Action>
	{
		public FApplicationLifetimeDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FApplicationLifetimeDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
