using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraScriptValidationCommandlet")]
	public partial class UNiagaraScriptValidationCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraScriptValidationCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}