using Script.CoreUObject;
using Script.NiagaraCore;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDataInterface")]
	public partial class UNiagaraDataInterface : UNiagaraDataInterfaceBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraDataInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}