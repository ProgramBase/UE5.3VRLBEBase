using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	public class FMovieSceneActorPredictionResult : FMulticastDelegate<Action<FTransform>>
	{
		public FMovieSceneActorPredictionResult() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FMovieSceneActorPredictionResult() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FTransform PredictedTransform)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PredictedTransform?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
