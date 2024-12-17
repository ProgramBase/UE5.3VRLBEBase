using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDataInterfaceGBuffer")]
	public partial class UNiagaraDataInterfaceGBuffer : UNiagaraDataInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraDataInterfaceGBuffer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}