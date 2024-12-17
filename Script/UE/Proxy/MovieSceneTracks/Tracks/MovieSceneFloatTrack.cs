using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneFloatTrack")]
	public partial class UMovieSceneFloatTrack : UMovieScenePropertyTrack, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneFloatTrack");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}