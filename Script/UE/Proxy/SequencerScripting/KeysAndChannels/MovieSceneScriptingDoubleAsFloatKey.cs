using Script.CoreUObject;
using Script.Library;

namespace Script.SequencerScripting
{
	[PathName("/Script/SequencerScripting.MovieSceneScriptingDoubleAsFloatKey")]
	public partial class UMovieSceneScriptingDoubleAsFloatKey : UMovieSceneScriptingFloatKey, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequencerScripting.MovieSceneScriptingDoubleAsFloatKey");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}