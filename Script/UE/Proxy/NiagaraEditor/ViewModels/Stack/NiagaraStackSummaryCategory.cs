using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackSummaryCategory")]
	public partial class UNiagaraStackSummaryCategory : UNiagaraStackCategory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackSummaryCategory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}