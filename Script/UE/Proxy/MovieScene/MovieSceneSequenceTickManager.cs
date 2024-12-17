using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneSequenceTickManager")]
	public partial class UMovieSceneSequenceTickManager : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneSequenceTickManager");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}