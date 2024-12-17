using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraUserParametersHierarchyViewModel")]
	public partial class UNiagaraUserParametersHierarchyViewModel : UNiagaraHierarchyViewModelBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraUserParametersHierarchyViewModel");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}