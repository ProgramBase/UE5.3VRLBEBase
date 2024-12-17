using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraSimCacheCustomStorageInterface")]
	public partial class UNiagaraSimCacheCustomStorageInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraSimCacheCustomStorageInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Niagara.NiagaraSimCacheCustomStorageInterface")]
	public interface INiagaraSimCacheCustomStorageInterface : IInterface
	{
	}
}