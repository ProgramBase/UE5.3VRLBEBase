using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackItemTextContent")]
	public partial class UNiagaraStackItemTextContent : UNiagaraStackItemContent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackItemTextContent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}