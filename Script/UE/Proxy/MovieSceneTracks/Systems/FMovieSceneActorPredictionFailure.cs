using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	public class FMovieSceneActorPredictionFailure : FMulticastDelegate<Action>
	{
		public FMovieSceneActorPredictionFailure() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FMovieSceneActorPredictionFailure() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
