using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayTasks.GameplayTask
{
	public class FGenericGameplayTaskDelegate : FMulticastDelegate<Action>
	{
		public FGenericGameplayTaskDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FGenericGameplayTaskDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
