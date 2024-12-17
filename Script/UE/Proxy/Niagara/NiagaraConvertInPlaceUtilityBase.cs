using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraConvertInPlaceUtilityBase")]
	public partial class UNiagaraConvertInPlaceUtilityBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraConvertInPlaceUtilityBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}