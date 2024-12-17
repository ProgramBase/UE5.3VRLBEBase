using Script.CoreUObject;
using Script.Niagara;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraConvertInPlaceEmitterAndSystemState")]
	public partial class UNiagaraConvertInPlaceEmitterAndSystemState : UNiagaraConvertInPlaceUtilityBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraConvertInPlaceEmitterAndSystemState");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}