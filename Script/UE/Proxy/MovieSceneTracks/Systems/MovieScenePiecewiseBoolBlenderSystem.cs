using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieScenePiecewiseBoolBlenderSystem")]
	public partial class UMovieScenePiecewiseBoolBlenderSystem : UMovieSceneBlenderSystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieScenePiecewiseBoolBlenderSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}