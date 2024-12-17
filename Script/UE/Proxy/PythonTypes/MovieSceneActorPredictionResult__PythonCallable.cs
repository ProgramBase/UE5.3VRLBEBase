using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/MovieSceneActorPredictionResult__PythonCallable.MovieSceneActorPredictionResult__PythonCallable")]
	public partial class MovieSceneActorPredictionResult__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/MovieSceneActorPredictionResult__PythonCallable.MovieSceneActorPredictionResult__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}