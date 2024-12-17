using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayTasks.GameplayTask_TimeLimitedExecution
{
	public class FTaskFinishDelegate : FMulticastDelegate<Action>
	{
		public FTaskFinishDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FTaskFinishDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
