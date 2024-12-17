using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneMaterialParameterCollectionSystem")]
	public partial class UMovieSceneMaterialParameterCollectionSystem : UMovieSceneEntitySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneMaterialParameterCollectionSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}