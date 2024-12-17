using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDataInterfaceRWBase")]
	public partial class UNiagaraDataInterfaceRWBase : UNiagaraDataInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraDataInterfaceRWBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}