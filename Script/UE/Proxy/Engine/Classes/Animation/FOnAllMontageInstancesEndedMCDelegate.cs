using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnAllMontageInstancesEndedMCDelegate : FMulticastDelegate<Action>
	{
		public FOnAllMontageInstancesEndedMCDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnAllMontageInstancesEndedMCDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
