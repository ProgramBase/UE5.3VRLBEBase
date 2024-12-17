using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraHierarchySimStage")]
	public partial class UNiagaraHierarchySimStage : UNiagaraHierarchyItem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraHierarchySimStage");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}