using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.TestMovieSceneSubSection")]
	public partial class UTestMovieSceneSubSection : UMovieSceneSubSection, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.TestMovieSceneSubSection");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}