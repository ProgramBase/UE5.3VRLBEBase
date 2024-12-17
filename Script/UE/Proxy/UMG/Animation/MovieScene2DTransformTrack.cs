using Script.CoreUObject;
using Script.MovieSceneTracks;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.MovieScene2DTransformTrack")]
	public partial class UMovieScene2DTransformTrack : UMovieScenePropertyTrack, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.MovieScene2DTransformTrack");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}