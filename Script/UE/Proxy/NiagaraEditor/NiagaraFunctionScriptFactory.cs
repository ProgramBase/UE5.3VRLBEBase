using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraFunctionScriptFactory")]
	public partial class UNiagaraFunctionScriptFactory : UNiagaraScriptFactoryNew, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraFunctionScriptFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}