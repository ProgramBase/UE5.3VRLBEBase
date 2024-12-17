using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackValueCollection")]
	public partial class UNiagaraStackValueCollection : UNiagaraStackItemContent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackValueCollection");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}