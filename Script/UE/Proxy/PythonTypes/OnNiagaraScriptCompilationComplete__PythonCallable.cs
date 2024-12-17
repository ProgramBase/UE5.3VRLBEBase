using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnNiagaraScriptCompilationComplete__PythonCallable.OnNiagaraScriptCompilationComplete__PythonCallable")]
	public partial class OnNiagaraScriptCompilationComplete__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnNiagaraScriptCompilationComplete__PythonCallable.OnNiagaraScriptCompilationComplete__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}