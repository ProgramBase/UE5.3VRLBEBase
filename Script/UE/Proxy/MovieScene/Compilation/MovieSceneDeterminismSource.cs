using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneDeterminismSource")]
	public partial class UMovieSceneDeterminismSource : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneDeterminismSource");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/MovieScene.MovieSceneDeterminismSource")]
	public interface IMovieSceneDeterminismSource : IInterface
	{
	}
}