using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackErrorItemLongDescription")]
	public partial class UNiagaraStackErrorItemLongDescription : UNiagaraStackEntry, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackErrorItemLongDescription");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}