using Script.CoreUObject;
using Script.Library;

namespace Script.SequencerScripting
{
	[PathName("/Script/SequencerScripting.MovieSceneScriptingActualFloatKey")]
	public partial class UMovieSceneScriptingActualFloatKey : UMovieSceneScriptingFloatKey, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequencerScripting.MovieSceneScriptingActualFloatKey");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}