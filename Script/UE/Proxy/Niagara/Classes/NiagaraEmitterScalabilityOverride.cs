using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraEmitterScalabilityOverride")]
	public partial class FNiagaraEmitterScalabilityOverride : FNiagaraEmitterScalabilitySettings, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraEmitterScalabilityOverride");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraEmitterScalabilityOverride()
		{
		}

		public static bool operator ==(FNiagaraEmitterScalabilityOverride A, FNiagaraEmitterScalabilityOverride B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraEmitterScalabilityOverride A, FNiagaraEmitterScalabilityOverride B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraEmitterScalabilityOverride;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bOverrideSpawnCountScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideSpawnCountScale, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideSpawnCountScale, __InBuffer);
				}
			}
		}

		private static uint __bOverrideSpawnCountScale = 0;

	}
}