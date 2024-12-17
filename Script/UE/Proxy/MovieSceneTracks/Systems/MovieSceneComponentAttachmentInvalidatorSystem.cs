using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneComponentAttachmentInvalidatorSystem")]
	public partial class UMovieSceneComponentAttachmentInvalidatorSystem : UMovieSceneEntityInstantiatorSystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneComponentAttachmentInvalidatorSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}