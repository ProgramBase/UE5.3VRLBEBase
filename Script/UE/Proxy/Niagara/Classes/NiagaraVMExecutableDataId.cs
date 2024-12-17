using Script.CoreUObject;
using Script.Library;
using Script.NiagaraCore;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraVMExecutableDataId")]
	public partial class FNiagaraVMExecutableDataId : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraVMExecutableDataId");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraVMExecutableDataId() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraVMExecutableDataId() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraVMExecutableDataId A, FNiagaraVMExecutableDataId B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraVMExecutableDataId A, FNiagaraVMExecutableDataId B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraVMExecutableDataId;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FGuid CompilerVersionID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CompilerVersionID, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CompilerVersionID, __InBuffer);
				}
			}
		}

		public ENiagaraScriptUsage ScriptUsageType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ScriptUsageType, __ReturnBuffer);

					return *(ENiagaraScriptUsage*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ScriptUsageType, __InBuffer);
				}
			}
		}

		public FGuid ScriptUsageTypeID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ScriptUsageTypeID, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ScriptUsageTypeID, __InBuffer);
				}
			}
		}

		public TArray<FString> AdditionalDefines
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AdditionalDefines, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AdditionalDefines, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraVariableBase> AdditionalVariables
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AdditionalVariables, __ReturnBuffer);

					return *(TArray<FNiagaraVariableBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AdditionalVariables, __InBuffer);
				}
			}
		}

		public bool bUsesRapidIterationParams
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bUsesRapidIterationParams, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bUsesRapidIterationParams, __InBuffer);
				}
			}
		}

		public bool bDisableDebugSwitches
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bDisableDebugSwitches, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bDisableDebugSwitches, __InBuffer);
				}
			}
		}

		public bool bInterpolatedSpawn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bInterpolatedSpawn, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bInterpolatedSpawn, __InBuffer);
				}
			}
		}

		public bool bRequiresPersistentIDs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bRequiresPersistentIDs, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bRequiresPersistentIDs, __InBuffer);
				}
			}
		}

		public FNiagaraCompileHash BaseScriptCompileHash
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BaseScriptCompileHash, __ReturnBuffer);

					return *(FNiagaraCompileHash*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BaseScriptCompileHash, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraCompileHash> ReferencedCompileHashes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ReferencedCompileHashes, __ReturnBuffer);

					return *(TArray<FNiagaraCompileHash>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ReferencedCompileHashes, __InBuffer);
				}
			}
		}

		public FGuid ScriptVersionID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ScriptVersionID, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ScriptVersionID, __InBuffer);
				}
			}
		}

		private static uint __CompilerVersionID = 0;

		private static uint __ScriptUsageType = 0;

		private static uint __ScriptUsageTypeID = 0;

		private static uint __AdditionalDefines = 0;

		private static uint __AdditionalVariables = 0;

		private static uint __bUsesRapidIterationParams = 0;

		private static uint __bDisableDebugSwitches = 0;

		private static uint __bInterpolatedSpawn = 0;

		private static uint __bRequiresPersistentIDs = 0;

		private static uint __BaseScriptCompileHash = 0;

		private static uint __ReferencedCompileHashes = 0;

		private static uint __ScriptVersionID = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}