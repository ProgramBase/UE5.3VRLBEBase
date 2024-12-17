using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraEmitterScalabilitySettings")]
	public partial class FNiagaraEmitterScalabilitySettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraEmitterScalabilitySettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraEmitterScalabilitySettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraEmitterScalabilitySettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraEmitterScalabilitySettings A, FNiagaraEmitterScalabilitySettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraEmitterScalabilitySettings A, FNiagaraEmitterScalabilitySettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraEmitterScalabilitySettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FNiagaraPlatformSet Platforms
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Platforms, __ReturnBuffer);

					return *(FNiagaraPlatformSet*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Platforms, __InBuffer);
				}
			}
		}

		public bool bScaleSpawnCount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bScaleSpawnCount, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bScaleSpawnCount, __InBuffer);
				}
			}
		}

		public float SpawnCountScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SpawnCountScale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SpawnCountScale, __InBuffer);
				}
			}
		}

		private static uint __Platforms = 0;

		private static uint __bScaleSpawnCount = 0;

		private static uint __SpawnCountScale = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}