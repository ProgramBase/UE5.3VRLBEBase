using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/NiagaraClipboardFunction_OnPastedFunctionCallNode__PythonCallable.NiagaraClipboardFunction_OnPastedFunctionCallNode__PythonCallable")]
	public partial class NiagaraClipboardFunction_OnPastedFunctionCallNode__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/NiagaraClipboardFunction_OnPastedFunctionCallNode__PythonCallable.NiagaraClipboardFunction_OnPastedFunctionCallNode__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}