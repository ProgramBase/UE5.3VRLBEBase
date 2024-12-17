using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraNodeParameterMapFor")]
	public partial class UNiagaraNodeParameterMapFor : UNiagaraNodeParameterMapSet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraNodeParameterMapFor");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}