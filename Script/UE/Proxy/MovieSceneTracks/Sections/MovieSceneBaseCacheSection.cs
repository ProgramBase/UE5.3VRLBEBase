using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneBaseCacheSection")]
	public partial class UMovieSceneBaseCacheSection : UMovieSceneSection, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneBaseCacheSection");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}