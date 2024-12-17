using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneBindingOwnerInterface")]
	public partial class UMovieSceneBindingOwnerInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneBindingOwnerInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/MovieScene.MovieSceneBindingOwnerInterface")]
	public interface IMovieSceneBindingOwnerInterface : IInterface
	{
	}
}