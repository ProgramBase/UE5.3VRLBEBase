using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraNodeReadDataSet")]
	public partial class UNiagaraNodeReadDataSet : UNiagaraNodeDataSetBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraNodeReadDataSet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}