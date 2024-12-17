using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneTransformOriginInstantiatorSystem")]
	public partial class UMovieSceneTransformOriginInstantiatorSystem : UMovieSceneEntitySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneTransformOriginInstantiatorSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}