using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnSpectrumResults__PythonCallable.OnSpectrumResults__PythonCallable")]
	public partial class OnSpectrumResults__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnSpectrumResults__PythonCallable.OnSpectrumResults__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}