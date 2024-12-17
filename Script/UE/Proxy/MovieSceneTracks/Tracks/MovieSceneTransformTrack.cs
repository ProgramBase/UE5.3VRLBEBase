using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneTransformTrack")]
	public partial class UMovieSceneTransformTrack : UMovieScenePropertyTrack, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneTransformTrack");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}