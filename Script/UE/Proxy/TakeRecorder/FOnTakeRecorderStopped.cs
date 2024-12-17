using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.TakeRecorder
{
	public class FOnTakeRecorderStopped : FDelegate<Action>
	{
		public FOnTakeRecorderStopped() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnTakeRecorderStopped() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute()
		{
			unsafe
			{
				FDelegateImplementation.FDelegate_GenericExecute0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
