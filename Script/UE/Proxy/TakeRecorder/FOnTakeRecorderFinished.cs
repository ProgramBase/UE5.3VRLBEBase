using System;
using Script.CoreUObject;
using Script.Library;
using Script.LevelSequence;

namespace Script.TakeRecorder
{
	public class FOnTakeRecorderFinished : FDelegate<Action<ULevelSequence>>
	{
		public FOnTakeRecorderFinished() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnTakeRecorderFinished() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(ULevelSequence SequenceAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SequenceAsset?.GarbageCollectionHandle ?? nint.Zero;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
