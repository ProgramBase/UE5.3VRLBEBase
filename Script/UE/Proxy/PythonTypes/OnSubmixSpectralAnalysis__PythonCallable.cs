using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnSubmixSpectralAnalysis__PythonCallable.OnSubmixSpectralAnalysis__PythonCallable")]
	public partial class OnSubmixSpectralAnalysis__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnSubmixSpectralAnalysis__PythonCallable.OnSubmixSpectralAnalysis__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}