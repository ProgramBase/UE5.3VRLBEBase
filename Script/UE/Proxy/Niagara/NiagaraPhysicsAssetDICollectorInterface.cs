using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraPhysicsAssetDICollectorInterface")]
	public partial class UNiagaraPhysicsAssetDICollectorInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraPhysicsAssetDICollectorInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Niagara.NiagaraPhysicsAssetDICollectorInterface")]
	public interface INiagaraPhysicsAssetDICollectorInterface : IInterface
	{
	}
}