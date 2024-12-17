using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneBlenderSystemSupport")]
	public partial class UMovieSceneBlenderSystemSupport : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneBlenderSystemSupport");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/MovieScene.MovieSceneBlenderSystemSupport")]
	public interface IMovieSceneBlenderSystemSupport : IInterface
	{
	}
}