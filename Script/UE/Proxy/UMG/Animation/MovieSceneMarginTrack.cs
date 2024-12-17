using Script.CoreUObject;
using Script.MovieSceneTracks;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.MovieSceneMarginTrack")]
	public partial class UMovieSceneMarginTrack : UMovieScenePropertyTrack, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.MovieSceneMarginTrack");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}