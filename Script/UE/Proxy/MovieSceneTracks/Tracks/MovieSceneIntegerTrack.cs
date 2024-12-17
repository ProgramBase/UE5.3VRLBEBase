using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneIntegerTrack")]
	public partial class UMovieSceneIntegerTrack : UMovieScenePropertyTrack, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneIntegerTrack");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}