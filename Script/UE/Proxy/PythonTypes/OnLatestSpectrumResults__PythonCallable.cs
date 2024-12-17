using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnLatestSpectrumResults__PythonCallable.OnLatestSpectrumResults__PythonCallable")]
	public partial class OnLatestSpectrumResults__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnLatestSpectrumResults__PythonCallable.OnLatestSpectrumResults__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}