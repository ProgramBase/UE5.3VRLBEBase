using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraSummaryViewViewModel")]
	public partial class UNiagaraSummaryViewViewModel : UNiagaraHierarchyViewModelBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraSummaryViewViewModel");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}