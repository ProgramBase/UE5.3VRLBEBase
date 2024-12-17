using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraValidationRule")]
	public partial class UNiagaraValidationRule : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraValidationRule");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}