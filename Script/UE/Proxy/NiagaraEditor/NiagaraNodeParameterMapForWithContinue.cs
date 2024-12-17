using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraNodeParameterMapForWithContinue")]
	public partial class UNiagaraNodeParameterMapForWithContinue : UNiagaraNodeParameterMapFor, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraNodeParameterMapForWithContinue");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}