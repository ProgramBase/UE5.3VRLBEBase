using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraHierarchyItem")]
	public partial class UNiagaraHierarchyItem : UNiagaraHierarchyItemBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraHierarchyItem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}