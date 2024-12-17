using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraNodeParameterMapBase")]
	public partial class UNiagaraNodeParameterMapBase : UNiagaraNodeWithDynamicPins, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraNodeParameterMapBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}