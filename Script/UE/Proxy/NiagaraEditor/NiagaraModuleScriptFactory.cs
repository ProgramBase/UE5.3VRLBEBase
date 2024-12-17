using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraModuleScriptFactory")]
	public partial class UNiagaraModuleScriptFactory : UNiagaraScriptFactoryNew, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraModuleScriptFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}