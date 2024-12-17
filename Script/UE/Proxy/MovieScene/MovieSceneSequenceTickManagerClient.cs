using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneSequenceTickManagerClient")]
	public partial class UMovieSceneSequenceTickManagerClient : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneSequenceTickManagerClient");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/MovieScene.MovieSceneSequenceTickManagerClient")]
	public interface IMovieSceneSequenceTickManagerClient : IInterface
	{
	}
}