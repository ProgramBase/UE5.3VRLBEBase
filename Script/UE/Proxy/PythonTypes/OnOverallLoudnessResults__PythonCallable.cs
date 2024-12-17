using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnOverallLoudnessResults__PythonCallable.OnOverallLoudnessResults__PythonCallable")]
	public partial class OnOverallLoudnessResults__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnOverallLoudnessResults__PythonCallable.OnOverallLoudnessResults__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}