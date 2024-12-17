using System;
using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.TakeRecorder
{
	public class FOnTakeRecorderMarkedFrameAdded : FDelegate<Action<FMovieSceneMarkedFrame>>
	{
		public FOnTakeRecorderMarkedFrameAdded() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnTakeRecorderMarkedFrameAdded() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(FMovieSceneMarkedFrame MarkedFrame)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MarkedFrame?.GarbageCollectionHandle ?? nint.Zero;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
