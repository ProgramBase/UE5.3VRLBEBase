using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneCustomClockSource")]
	public partial class UMovieSceneCustomClockSource : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneCustomClockSource");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/MovieScene.MovieSceneCustomClockSource")]
	public interface IMovieSceneCustomClockSource : IInterface
	{
		 void OnTick(float DeltaSeconds, float InPlayRate);

		 void OnStopPlaying(FQualifiedFrameTime InStopTime);

		 void OnStartPlaying(FQualifiedFrameTime InStartTime);

		 FFrameTime OnRequestCurrentTime(FQualifiedFrameTime InCurrentTime, float InPlayRate);
	}
}