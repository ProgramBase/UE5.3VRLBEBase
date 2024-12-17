using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackErrorItemDismiss")]
	public partial class UNiagaraStackErrorItemDismiss : UNiagaraStackErrorItemFix, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackErrorItemDismiss");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}