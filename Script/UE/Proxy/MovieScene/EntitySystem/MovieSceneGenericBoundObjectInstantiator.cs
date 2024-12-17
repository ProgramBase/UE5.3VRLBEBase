using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneGenericBoundObjectInstantiator")]
	public partial class UMovieSceneGenericBoundObjectInstantiator : UMovieSceneEntityInstantiatorSystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneGenericBoundObjectInstantiator");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}