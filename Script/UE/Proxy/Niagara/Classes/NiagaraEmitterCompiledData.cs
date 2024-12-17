using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraEmitterCompiledData")]
	public partial class FNiagaraEmitterCompiledData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraEmitterCompiledData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraEmitterCompiledData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraEmitterCompiledData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraEmitterCompiledData A, FNiagaraEmitterCompiledData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraEmitterCompiledData A, FNiagaraEmitterCompiledData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraEmitterCompiledData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FName> SpawnAttributes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SpawnAttributes, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SpawnAttributes, __InBuffer);
				}
			}
		}

		public FNiagaraVariable EmitterSpawnIntervalVar
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EmitterSpawnIntervalVar, __ReturnBuffer);

					return *(FNiagaraVariable*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EmitterSpawnIntervalVar, __InBuffer);
				}
			}
		}

		public FNiagaraVariable EmitterInterpSpawnStartDTVar
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EmitterInterpSpawnStartDTVar, __ReturnBuffer);

					return *(FNiagaraVariable*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EmitterInterpSpawnStartDTVar, __InBuffer);
				}
			}
		}

		public FNiagaraVariable EmitterSpawnGroupVar
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EmitterSpawnGroupVar, __ReturnBuffer);

					return *(FNiagaraVariable*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EmitterSpawnGroupVar, __InBuffer);
				}
			}
		}

		public FNiagaraVariable EmitterAgeVar
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EmitterAgeVar, __ReturnBuffer);

					return *(FNiagaraVariable*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EmitterAgeVar, __InBuffer);
				}
			}
		}

		public FNiagaraVariable EmitterRandomSeedVar
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EmitterRandomSeedVar, __ReturnBuffer);

					return *(FNiagaraVariable*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EmitterRandomSeedVar, __InBuffer);
				}
			}
		}

		public FNiagaraVariable EmitterInstanceSeedVar
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EmitterInstanceSeedVar, __ReturnBuffer);

					return *(FNiagaraVariable*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EmitterInstanceSeedVar, __InBuffer);
				}
			}
		}

		public FNiagaraVariable EmitterTotalSpawnedParticlesVar
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EmitterTotalSpawnedParticlesVar, __ReturnBuffer);

					return *(FNiagaraVariable*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EmitterTotalSpawnedParticlesVar, __InBuffer);
				}
			}
		}

		public FNiagaraDataSetCompiledData DataSetCompiledData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DataSetCompiledData, __ReturnBuffer);

					return *(FNiagaraDataSetCompiledData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DataSetCompiledData, __InBuffer);
				}
			}
		}

		private static uint __SpawnAttributes = 0;

		private static uint __EmitterSpawnIntervalVar = 0;

		private static uint __EmitterInterpSpawnStartDTVar = 0;

		private static uint __EmitterSpawnGroupVar = 0;

		private static uint __EmitterAgeVar = 0;

		private static uint __EmitterRandomSeedVar = 0;

		private static uint __EmitterInstanceSeedVar = 0;

		private static uint __EmitterTotalSpawnedParticlesVar = 0;

		private static uint __DataSetCompiledData = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}