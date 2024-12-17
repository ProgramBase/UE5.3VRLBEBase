using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraParticleCallbackHandler")]
	public partial class UNiagaraParticleCallbackHandler : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraParticleCallbackHandler");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Niagara.NiagaraParticleCallbackHandler")]
	public interface INiagaraParticleCallbackHandler : IInterface
	{
		 void ReceiveParticleData(TArray<FBasicParticleData> Data, UNiagaraSystem NiagaraSystem, FVector SimulationPositionOffset);
	}
}