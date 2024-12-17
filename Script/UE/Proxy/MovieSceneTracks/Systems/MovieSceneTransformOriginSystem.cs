using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneTransformOriginSystem")]
	public partial class UMovieSceneTransformOriginSystem : UMovieSceneEntitySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneTransformOriginSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}