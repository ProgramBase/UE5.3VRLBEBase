using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackObject")]
	public partial class UNiagaraStackObject : UNiagaraStackItemContent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackObject");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}