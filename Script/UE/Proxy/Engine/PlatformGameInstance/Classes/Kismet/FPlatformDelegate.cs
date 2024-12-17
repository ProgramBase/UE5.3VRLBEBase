using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine.PlatformGameInstance
{
	public class FPlatformDelegate : FMulticastDelegate<Action>
	{
		public FPlatformDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FPlatformDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
