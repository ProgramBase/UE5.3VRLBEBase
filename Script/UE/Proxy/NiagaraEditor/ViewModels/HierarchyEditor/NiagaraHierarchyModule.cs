using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraHierarchyModule")]
	public partial class UNiagaraHierarchyModule : UNiagaraHierarchyItem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraHierarchyModule");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}