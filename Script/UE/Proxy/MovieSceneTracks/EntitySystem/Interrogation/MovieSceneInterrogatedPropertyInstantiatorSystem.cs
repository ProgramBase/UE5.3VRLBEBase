using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneInterrogatedPropertyInstantiatorSystem")]
	public partial class UMovieSceneInterrogatedPropertyInstantiatorSystem : UMovieSceneEntityInstantiatorSystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneInterrogatedPropertyInstantiatorSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}