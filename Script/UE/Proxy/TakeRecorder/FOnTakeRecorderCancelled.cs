using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.TakeRecorder
{
	public class FOnTakeRecorderCancelled : FDelegate<Action>
	{
		public FOnTakeRecorderCancelled() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnTakeRecorderCancelled() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute()
		{
			unsafe
			{
				FDelegateImplementation.FDelegate_GenericExecute0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
