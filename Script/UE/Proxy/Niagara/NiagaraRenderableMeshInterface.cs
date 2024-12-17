using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraRenderableMeshInterface")]
	public partial class UNiagaraRenderableMeshInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraRenderableMeshInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Niagara.NiagaraRenderableMeshInterface")]
	public interface INiagaraRenderableMeshInterface : IInterface
	{
	}
}