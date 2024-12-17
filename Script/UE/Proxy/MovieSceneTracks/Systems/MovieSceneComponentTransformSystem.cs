using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneComponentTransformSystem")]
	public partial class UMovieSceneComponentTransformSystem : UMovieScenePropertySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneComponentTransformSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}