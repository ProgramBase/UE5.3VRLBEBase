using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/InputDebugKeyHandlerDynamicSignature__PythonCallable.InputDebugKeyHandlerDynamicSignature__PythonCallable")]
	public partial class InputDebugKeyHandlerDynamicSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/InputDebugKeyHandlerDynamicSignature__PythonCallable.InputDebugKeyHandlerDynamicSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}