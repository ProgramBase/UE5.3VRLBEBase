using Script.CoreUObject;
using Script.Library;
using Script.NiagaraCore;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NDIDataChannelCompiledData")]
	public partial class FNDIDataChannelCompiledData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NDIDataChannelCompiledData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNDIDataChannelCompiledData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNDIDataChannelCompiledData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNDIDataChannelCompiledData A, FNDIDataChannelCompiledData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNDIDataChannelCompiledData A, FNDIDataChannelCompiledData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNDIDataChannelCompiledData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FNDIDataChannelFunctionInfo> FunctionInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FunctionInfo, __ReturnBuffer);

					return *(TArray<FNDIDataChannelFunctionInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FunctionInfo, __InBuffer);
				}
			}
		}

		public TMap<FNiagaraCompileHash, FNDIDataChannel_GPUScriptParameterAccessInfo> GPUScriptParameterInfos
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GPUScriptParameterInfos, __ReturnBuffer);

					return *(TMap<FNiagaraCompileHash, FNDIDataChannel_GPUScriptParameterAccessInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GPUScriptParameterInfos, __InBuffer);
				}
			}
		}

		public uint TotalParams
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TotalParams, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TotalParams, __InBuffer);
				}
			}
		}

		public bool bUsedByCPU
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bUsedByCPU, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bUsedByCPU, __InBuffer);
				}
			}
		}

		public bool bUsedByGPU
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bUsedByGPU, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bUsedByGPU, __InBuffer);
				}
			}
		}

		private static uint __FunctionInfo = 0;

		private static uint __GPUScriptParameterInfos = 0;

		private static uint __TotalParams = 0;

		private static uint __bUsedByCPU = 0;

		private static uint __bUsedByGPU = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}