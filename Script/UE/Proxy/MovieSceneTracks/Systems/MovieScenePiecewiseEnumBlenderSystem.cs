using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieScenePiecewiseEnumBlenderSystem")]
	public partial class UMovieScenePiecewiseEnumBlenderSystem : UMovieSceneBlenderSystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieScenePiecewiseEnumBlenderSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}