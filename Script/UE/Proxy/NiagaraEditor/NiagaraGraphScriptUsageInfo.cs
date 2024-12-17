using Script.CoreUObject;
using Script.Library;
using Script.Niagara;
using Script.NiagaraCore;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraGraphScriptUsageInfo")]
	public partial class FNiagaraGraphScriptUsageInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraEditor.NiagaraGraphScriptUsageInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraGraphScriptUsageInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraGraphScriptUsageInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraGraphScriptUsageInfo A, FNiagaraGraphScriptUsageInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraGraphScriptUsageInfo A, FNiagaraGraphScriptUsageInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraGraphScriptUsageInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FGuid BaseId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BaseId, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BaseId, __InBuffer);
				}
			}
		}

		public ENiagaraScriptUsage UsageType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UsageType, __ReturnBuffer);

					return *(ENiagaraScriptUsage*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UsageType, __InBuffer);
				}
			}
		}

		public FGuid UsageId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UsageId, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UsageId, __InBuffer);
				}
			}
		}

		public FNiagaraCompileHash CompileHash
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CompileHash, __ReturnBuffer);

					return *(FNiagaraCompileHash*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CompileHash, __InBuffer);
				}
			}
		}

		public FNiagaraCompileHash CompileHashFromGraph
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CompileHashFromGraph, __ReturnBuffer);

					return *(FNiagaraCompileHash*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CompileHashFromGraph, __InBuffer);
				}
			}
		}

		public FNiagaraCompileHash ReferenceHashFromGraph
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ReferenceHashFromGraph, __ReturnBuffer);

					return *(FNiagaraCompileHash*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ReferenceHashFromGraph, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraCompileHashVisitorDebugInfo> CompileLastObjects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CompileLastObjects, __ReturnBuffer);

					return *(TArray<FNiagaraCompileHashVisitorDebugInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CompileLastObjects, __InBuffer);
				}
			}
		}

		public TArray<UNiagaraNode> Traversal
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Traversal, __ReturnBuffer);

					return *(TArray<UNiagaraNode>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Traversal, __InBuffer);
				}
			}
		}

		private static uint __BaseId = 0;

		private static uint __UsageType = 0;

		private static uint __UsageId = 0;

		private static uint __CompileHash = 0;

		private static uint __CompileHashFromGraph = 0;

		private static uint __ReferenceHashFromGraph = 0;

		private static uint __CompileLastObjects = 0;

		private static uint __Traversal = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}