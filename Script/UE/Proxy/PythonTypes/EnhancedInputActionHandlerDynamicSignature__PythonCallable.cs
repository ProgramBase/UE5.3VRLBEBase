using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/EnhancedInputActionHandlerDynamicSignature__PythonCallable.EnhancedInputActionHandlerDynamicSignature__PythonCallable")]
	public partial class EnhancedInputActionHandlerDynamicSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/EnhancedInputActionHandlerDynamicSignature__PythonCallable.EnhancedInputActionHandlerDynamicSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}