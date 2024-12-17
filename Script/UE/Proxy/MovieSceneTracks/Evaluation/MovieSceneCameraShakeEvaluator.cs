using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneCameraShakeEvaluator")]
	public partial class UMovieSceneCameraShakeEvaluator : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneCameraShakeEvaluator");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}