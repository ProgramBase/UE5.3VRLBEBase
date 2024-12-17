using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneCinematicShotTrack")]
	public partial class UMovieSceneCinematicShotTrack : UMovieSceneSubTrack, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneCinematicShotTrack");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}