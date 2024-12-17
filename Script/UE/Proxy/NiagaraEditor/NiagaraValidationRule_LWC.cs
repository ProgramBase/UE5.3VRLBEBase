using Script.CoreUObject;
using Script.Niagara;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraValidationRule_LWC")]
	public partial class UNiagaraValidationRule_LWC : UNiagaraValidationRule, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraValidationRule_LWC");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}