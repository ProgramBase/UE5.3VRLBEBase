using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.TakeRecorder
{
	public class FOnTakeRecorderPreInitialize : FDelegate<Action>
	{
		public FOnTakeRecorderPreInitialize() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnTakeRecorderPreInitialize() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute()
		{
			unsafe
			{
				FDelegateImplementation.FDelegate_GenericExecute0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
