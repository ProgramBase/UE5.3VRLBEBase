using Script.CoreUObject;
using Script.Niagara;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraMessageData")]
	public partial class UNiagaraMessageData : UNiagaraMessageDataBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraMessageData");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}