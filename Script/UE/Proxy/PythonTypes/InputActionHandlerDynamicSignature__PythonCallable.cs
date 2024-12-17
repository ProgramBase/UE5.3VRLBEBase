using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/InputActionHandlerDynamicSignature__PythonCallable.InputActionHandlerDynamicSignature__PythonCallable")]
	public partial class InputActionHandlerDynamicSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/InputActionHandlerDynamicSignature__PythonCallable.InputActionHandlerDynamicSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}