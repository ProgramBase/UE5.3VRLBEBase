using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneBoundObjectProxy")]
	public partial class UMovieSceneBoundObjectProxy : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneBoundObjectProxy");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/MovieScene.MovieSceneBoundObjectProxy")]
	public interface IMovieSceneBoundObjectProxy : IInterface
	{
		 UObject BP_GetBoundObjectForSequencer(UObject ResolvedObject);
	}
}