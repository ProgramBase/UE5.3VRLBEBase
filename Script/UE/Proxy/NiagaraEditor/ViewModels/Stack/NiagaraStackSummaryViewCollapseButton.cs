using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackSummaryViewCollapseButton")]
	public partial class UNiagaraStackSummaryViewCollapseButton : UNiagaraStackEntry, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackSummaryViewCollapseButton");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}