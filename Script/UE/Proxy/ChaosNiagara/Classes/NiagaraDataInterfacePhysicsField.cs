using Script.CoreUObject;
using Script.Niagara;
using Script.Library;

namespace Script.ChaosNiagara
{
	[PathName("/Script/ChaosNiagara.NiagaraDataInterfacePhysicsField")]
	public partial class UNiagaraDataInterfacePhysicsField : UNiagaraDataInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ChaosNiagara.NiagaraDataInterfacePhysicsField");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}