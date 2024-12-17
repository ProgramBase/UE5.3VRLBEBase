using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.TemplateSequence
{
	[PathName("/Script/TemplateSequence.TemplateSequenceTrack")]
	public partial class UTemplateSequenceTrack : UMovieSceneSubTrack, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TemplateSequence.TemplateSequenceTrack");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}