using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackSummaryViewCollection")]
	public partial class UNiagaraStackSummaryViewCollection : UNiagaraStackValueCollection, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackSummaryViewCollection");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}