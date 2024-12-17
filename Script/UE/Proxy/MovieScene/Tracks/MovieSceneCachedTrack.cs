using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneCachedTrack")]
	public partial class UMovieSceneCachedTrack : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneCachedTrack");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/MovieScene.MovieSceneCachedTrack")]
	public interface IMovieSceneCachedTrack : IInterface
	{
	}
}