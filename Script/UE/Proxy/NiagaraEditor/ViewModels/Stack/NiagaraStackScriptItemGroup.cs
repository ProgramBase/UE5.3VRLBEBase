using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackScriptItemGroup")]
	public partial class UNiagaraStackScriptItemGroup : UNiagaraStackItemGroup, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackScriptItemGroup");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}