using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnLatestOverallLoudnessResults__PythonCallable.OnLatestOverallLoudnessResults__PythonCallable")]
	public partial class OnLatestOverallLoudnessResults__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnLatestOverallLoudnessResults__PythonCallable.OnLatestOverallLoudnessResults__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}