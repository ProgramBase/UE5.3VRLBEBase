using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayTasks.GameplayTask_WaitDelay
{
	public class FTaskDelayDelegate : FMulticastDelegate<Action>
	{
		public FTaskDelayDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FTaskDelayDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
