using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.TemplateSequence
{
	[PathName("/Script/TemplateSequence.TemplateSequencePropertyScalingInstantiatorSystem")]
	public partial class UTemplateSequencePropertyScalingInstantiatorSystem : UMovieSceneEntitySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TemplateSequence.TemplateSequencePropertyScalingInstantiatorSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}