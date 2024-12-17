using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/AsyncNiagaraCaptureSimCache_OnCaptureComplete__PythonCallable.AsyncNiagaraCaptureSimCache_OnCaptureComplete__PythonCallable")]
	public partial class AsyncNiagaraCaptureSimCache_OnCaptureComplete__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/AsyncNiagaraCaptureSimCache_OnCaptureComplete__PythonCallable.AsyncNiagaraCaptureSimCache_OnCaptureComplete__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}