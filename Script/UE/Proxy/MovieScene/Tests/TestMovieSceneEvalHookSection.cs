using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.TestMovieSceneEvalHookSection")]
	public partial class UTestMovieSceneEvalHookSection : UMovieSceneHookSection, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.TestMovieSceneEvalHookSection");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}