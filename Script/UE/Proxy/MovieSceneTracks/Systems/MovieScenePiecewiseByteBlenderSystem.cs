using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieScenePiecewiseByteBlenderSystem")]
	public partial class UMovieScenePiecewiseByteBlenderSystem : UMovieSceneBlenderSystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieScenePiecewiseByteBlenderSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}