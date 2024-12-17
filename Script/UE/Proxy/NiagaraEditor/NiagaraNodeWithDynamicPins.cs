using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraNodeWithDynamicPins")]
	public partial class UNiagaraNodeWithDynamicPins : UNiagaraNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraNodeWithDynamicPins");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}