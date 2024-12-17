using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraCore
{
	[PathName("/Script/NiagaraCore.NiagaraDataInterfaceBase")]
	public partial class UNiagaraDataInterfaceBase : UNiagaraMergeable, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraCore.NiagaraDataInterfaceBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}