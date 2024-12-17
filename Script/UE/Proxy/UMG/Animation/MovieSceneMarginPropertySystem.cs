using Script.CoreUObject;
using Script.MovieSceneTracks;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.MovieSceneMarginPropertySystem")]
	public partial class UMovieSceneMarginPropertySystem : UMovieScenePropertySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.MovieSceneMarginPropertySystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}