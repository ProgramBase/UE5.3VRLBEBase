using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraNodeParameterMapForIndex")]
	public partial class UNiagaraNodeParameterMapForIndex : UNiagaraNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraNodeParameterMapForIndex");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}