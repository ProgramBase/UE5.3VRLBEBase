using Script.CoreUObject;
using Script.Library;
using Script.Niagara;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraDebuggerSpawnData")]
	public partial class FNiagaraDebuggerSpawnData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraEditor.NiagaraDebuggerSpawnData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraDebuggerSpawnData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraDebuggerSpawnData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraDebuggerSpawnData A, FNiagaraDebuggerSpawnData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraDebuggerSpawnData A, FNiagaraDebuggerSpawnData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraDebuggerSpawnData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<TSoftObjectPtr<UNiagaraSystem>> SystemsToSpawn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SystemsToSpawn, __ReturnBuffer);

					return *(TArray<TSoftObjectPtr<UNiagaraSystem>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SystemsToSpawn, __InBuffer);
				}
			}
		}

		public bool bSpawnAllAtOnce
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bSpawnAllAtOnce, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bSpawnAllAtOnce, __InBuffer);
				}
			}
		}

		public float TimeBetweenSpawns
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TimeBetweenSpawns, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TimeBetweenSpawns, __InBuffer);
				}
			}
		}

		public bool bKillBeforeSpawn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bKillBeforeSpawn, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bKillBeforeSpawn, __InBuffer);
				}
			}
		}

		public bool bWorldLocation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bWorldLocation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bWorldLocation, __InBuffer);
				}
			}
		}

		public FVector Location
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Location, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Location, __InBuffer);
				}
			}
		}

		public bool bAttachToPlayer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAttachToPlayer, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAttachToPlayer, __InBuffer);
				}
			}
		}

		public bool bAutoActivate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAutoActivate, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAutoActivate, __InBuffer);
				}
			}
		}

		public bool bAutoDestroy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAutoDestroy, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAutoDestroy, __InBuffer);
				}
			}
		}

		public bool bDoPreCullCheck
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bDoPreCullCheck, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bDoPreCullCheck, __InBuffer);
				}
			}
		}

		private static uint __SystemsToSpawn = 0;

		private static uint __bSpawnAllAtOnce = 0;

		private static uint __TimeBetweenSpawns = 0;

		private static uint __bKillBeforeSpawn = 0;

		private static uint __bWorldLocation = 0;

		private static uint __Location = 0;

		private static uint __bAttachToPlayer = 0;

		private static uint __bAutoActivate = 0;

		private static uint __bAutoDestroy = 0;

		private static uint __bDoPreCullCheck = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}