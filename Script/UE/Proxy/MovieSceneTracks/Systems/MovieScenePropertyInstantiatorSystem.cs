using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieScenePropertyInstantiatorSystem")]
	public partial class UMovieScenePropertyInstantiatorSystem : UMovieSceneEntityInstantiatorSystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieScenePropertyInstantiatorSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}