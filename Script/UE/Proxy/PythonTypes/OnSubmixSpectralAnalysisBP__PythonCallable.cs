using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnSubmixSpectralAnalysisBP__PythonCallable.OnSubmixSpectralAnalysisBP__PythonCallable")]
	public partial class OnSubmixSpectralAnalysisBP__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnSubmixSpectralAnalysisBP__PythonCallable.OnSubmixSpectralAnalysisBP__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}