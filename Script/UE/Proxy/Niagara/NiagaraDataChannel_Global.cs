using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDataChannel_Global")]
	public partial class UNiagaraDataChannel_Global : UNiagaraDataChannel, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraDataChannel_Global");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}