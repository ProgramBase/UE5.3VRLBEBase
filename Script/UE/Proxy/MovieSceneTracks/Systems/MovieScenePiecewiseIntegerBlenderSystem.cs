using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieScenePiecewiseIntegerBlenderSystem")]
	public partial class UMovieScenePiecewiseIntegerBlenderSystem : UMovieSceneBlenderSystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieScenePiecewiseIntegerBlenderSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}