using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.TakeRecorder
{
	public class FOnTakeRecorderPanelChanged : FDelegate<Action>
	{
		public FOnTakeRecorderPanelChanged() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnTakeRecorderPanelChanged() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute()
		{
			unsafe
			{
				FDelegateImplementation.FDelegate_GenericExecute0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
