using Script.CoreUObject;
using Script.Niagara;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraValidationRule_NoOpaqueRenderMaterial")]
	public partial class UNiagaraValidationRule_NoOpaqueRenderMaterial : UNiagaraValidationRule, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraValidationRule_NoOpaqueRenderMaterial");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}