using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.TestMovieSceneSection")]
	public partial class UTestMovieSceneSection : UMovieSceneSection, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.TestMovieSceneSection");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}