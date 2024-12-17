using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/InputAxisHandlerDynamicSignature__PythonCallable.InputAxisHandlerDynamicSignature__PythonCallable")]
	public partial class InputAxisHandlerDynamicSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/InputAxisHandlerDynamicSignature__PythonCallable.InputAxisHandlerDynamicSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}