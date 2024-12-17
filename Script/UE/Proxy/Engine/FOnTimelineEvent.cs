using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnTimelineEvent : FDelegate<Action>
	{
		public FOnTimelineEvent() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnTimelineEvent() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute()
		{
			unsafe
			{
				FDelegateImplementation.FDelegate_GenericExecute0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
