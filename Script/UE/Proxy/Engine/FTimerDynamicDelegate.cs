using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FTimerDynamicDelegate : FDelegate<Action>
	{
		public FTimerDynamicDelegate() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FTimerDynamicDelegate() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute()
		{
			unsafe
			{
				FDelegateImplementation.FDelegate_GenericExecute0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
