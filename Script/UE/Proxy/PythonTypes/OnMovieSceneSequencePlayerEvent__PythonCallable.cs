using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnMovieSceneSequencePlayerEvent__PythonCallable.OnMovieSceneSequencePlayerEvent__PythonCallable")]
	public partial class OnMovieSceneSequencePlayerEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnMovieSceneSequencePlayerEvent__PythonCallable.OnMovieSceneSequencePlayerEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}