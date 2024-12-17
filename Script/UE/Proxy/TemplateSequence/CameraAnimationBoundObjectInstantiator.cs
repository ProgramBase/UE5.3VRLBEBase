using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.TemplateSequence
{
	[PathName("/Script/TemplateSequence.CameraAnimationBoundObjectInstantiator")]
	public partial class UCameraAnimationBoundObjectInstantiator : UMovieSceneEntityInstantiatorSystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TemplateSequence.CameraAnimationBoundObjectInstantiator");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}