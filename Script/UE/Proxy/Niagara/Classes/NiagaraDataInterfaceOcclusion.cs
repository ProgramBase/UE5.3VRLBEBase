using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDataInterfaceOcclusion")]
	public partial class UNiagaraDataInterfaceOcclusion : UNiagaraDataInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraDataInterfaceOcclusion");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}