using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraHierarchyEventHandler")]
	public partial class UNiagaraHierarchyEventHandler : UNiagaraHierarchyItem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraHierarchyEventHandler");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}