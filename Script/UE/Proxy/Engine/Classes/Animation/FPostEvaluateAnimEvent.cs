using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FPostEvaluateAnimEvent : FDelegate<Action>
	{
		public FPostEvaluateAnimEvent() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FPostEvaluateAnimEvent() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute()
		{
			unsafe
			{
				FDelegateImplementation.FDelegate_GenericExecute0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
