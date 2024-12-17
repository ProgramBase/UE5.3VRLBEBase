using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneCameraCutTrackInstance")]
	public partial class UMovieSceneCameraCutTrackInstance : UMovieSceneTrackInstance, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneCameraCutTrackInstance");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}