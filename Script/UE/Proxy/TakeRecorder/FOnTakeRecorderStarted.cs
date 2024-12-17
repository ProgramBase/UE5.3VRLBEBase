using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.TakeRecorder
{
	public class FOnTakeRecorderStarted : FDelegate<Action>
	{
		public FOnTakeRecorderStarted() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnTakeRecorderStarted() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute()
		{
			unsafe
			{
				FDelegateImplementation.FDelegate_GenericExecute0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
