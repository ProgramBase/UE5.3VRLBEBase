using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationSystem")]
	public partial class UMovieSceneSkeletalAnimationSystem : UMovieSceneEntitySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}