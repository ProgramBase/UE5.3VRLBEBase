using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	public class FOnMovieSceneSequencePlayerEvent : FMulticastDelegate<Action>
	{
		public FOnMovieSceneSequencePlayerEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnMovieSceneSequencePlayerEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
