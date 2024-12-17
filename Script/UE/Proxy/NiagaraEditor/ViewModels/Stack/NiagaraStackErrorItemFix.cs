using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackErrorItemFix")]
	public partial class UNiagaraStackErrorItemFix : UNiagaraStackEntry, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackErrorItemFix");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}