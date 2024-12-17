using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraNodeParameterMapSet")]
	public partial class UNiagaraNodeParameterMapSet : UNiagaraNodeParameterMapBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraNodeParameterMapSet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}