using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneBoundSceneComponentInstantiator")]
	public partial class UMovieSceneBoundSceneComponentInstantiator : UMovieSceneEntityInstantiatorSystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneBoundSceneComponentInstantiator");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}