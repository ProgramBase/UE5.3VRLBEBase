using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneQuaternionInterpolationRotationSystem")]
	public partial class UMovieSceneQuaternionInterpolationRotationSystem : UMovieSceneEntitySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneQuaternionInterpolationRotationSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}