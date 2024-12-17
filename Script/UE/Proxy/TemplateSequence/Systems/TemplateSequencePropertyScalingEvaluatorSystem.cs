using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.TemplateSequence
{
	[PathName("/Script/TemplateSequence.TemplateSequencePropertyScalingEvaluatorSystem")]
	public partial class UTemplateSequencePropertyScalingEvaluatorSystem : UMovieSceneEntitySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TemplateSequence.TemplateSequencePropertyScalingEvaluatorSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}