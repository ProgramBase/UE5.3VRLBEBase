using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneEulerTransformPropertySystem")]
	public partial class UMovieSceneEulerTransformPropertySystem : UMovieScenePropertySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneEulerTransformPropertySystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}