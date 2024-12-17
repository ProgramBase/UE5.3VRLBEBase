using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDataInterfaceCollisionQuery")]
	public partial class UNiagaraDataInterfaceCollisionQuery : UNiagaraDataInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraDataInterfaceCollisionQuery");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}