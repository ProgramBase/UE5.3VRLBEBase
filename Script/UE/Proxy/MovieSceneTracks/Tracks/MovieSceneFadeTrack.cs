using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneFadeTrack")]
	public partial class UMovieSceneFadeTrack : UMovieSceneFloatTrack, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneFadeTrack");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}