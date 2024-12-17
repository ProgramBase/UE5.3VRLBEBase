using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneEulerTransformTrack")]
	public partial class UMovieSceneEulerTransformTrack : UMovieScenePropertyTrack, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneEulerTransformTrack");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}