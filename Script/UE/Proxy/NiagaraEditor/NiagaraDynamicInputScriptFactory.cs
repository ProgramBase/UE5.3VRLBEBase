using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraDynamicInputScriptFactory")]
	public partial class UNiagaraDynamicInputScriptFactory : UNiagaraScriptFactoryNew, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraDynamicInputScriptFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}