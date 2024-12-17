using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneVisibilityTrack")]
	public partial class UMovieSceneVisibilityTrack : UMovieSceneBoolTrack, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneVisibilityTrack");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}