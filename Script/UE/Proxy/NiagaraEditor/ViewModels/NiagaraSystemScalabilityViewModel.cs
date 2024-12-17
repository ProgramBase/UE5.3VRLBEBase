using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraSystemScalabilityViewModel")]
	public partial class UNiagaraSystemScalabilityViewModel : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraSystemScalabilityViewModel");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}