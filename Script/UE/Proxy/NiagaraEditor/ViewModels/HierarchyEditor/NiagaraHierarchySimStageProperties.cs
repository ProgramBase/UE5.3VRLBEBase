using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraHierarchySimStageProperties")]
	public partial class UNiagaraHierarchySimStageProperties : UNiagaraHierarchyItem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraHierarchySimStageProperties");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}