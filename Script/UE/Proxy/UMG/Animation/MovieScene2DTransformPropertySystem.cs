using Script.CoreUObject;
using Script.MovieSceneTracks;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.MovieScene2DTransformPropertySystem")]
	public partial class UMovieScene2DTransformPropertySystem : UMovieScenePropertySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.MovieScene2DTransformPropertySystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}