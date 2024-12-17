using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraHierarchyEventHandlerProperties")]
	public partial class UNiagaraHierarchyEventHandlerProperties : UNiagaraHierarchyItem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraHierarchyEventHandlerProperties");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}