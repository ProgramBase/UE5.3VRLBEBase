using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneTrackInstanceInstantiator")]
	public partial class UMovieSceneTrackInstanceInstantiator : UMovieSceneEntityInstantiatorSystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneTrackInstanceInstantiator");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}