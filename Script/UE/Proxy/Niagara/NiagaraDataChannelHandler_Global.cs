using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDataChannelHandler_Global")]
	public partial class UNiagaraDataChannelHandler_Global : UNiagaraDataChannelHandler, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraDataChannelHandler_Global");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}