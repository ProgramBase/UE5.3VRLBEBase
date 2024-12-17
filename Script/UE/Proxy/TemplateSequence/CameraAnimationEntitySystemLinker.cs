using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.TemplateSequence
{
	[PathName("/Script/TemplateSequence.CameraAnimationEntitySystemLinker")]
	public partial class UCameraAnimationEntitySystemLinker : UMovieSceneEntitySystemLinker, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TemplateSequence.CameraAnimationEntitySystemLinker");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}