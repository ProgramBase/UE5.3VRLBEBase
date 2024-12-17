using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneTrackTemplateProducer")]
	public partial class UMovieSceneTrackTemplateProducer : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneTrackTemplateProducer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/MovieScene.MovieSceneTrackTemplateProducer")]
	public interface IMovieSceneTrackTemplateProducer : IInterface
	{
	}
}