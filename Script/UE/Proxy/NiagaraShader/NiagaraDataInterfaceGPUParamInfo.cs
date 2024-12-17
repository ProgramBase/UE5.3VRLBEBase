using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraShader
{
	[PathName("/Script/NiagaraShader.NiagaraDataInterfaceGPUParamInfo")]
	public partial class FNiagaraDataInterfaceGPUParamInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraShader.NiagaraDataInterfaceGPUParamInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraDataInterfaceGPUParamInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraDataInterfaceGPUParamInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraDataInterfaceGPUParamInfo A, FNiagaraDataInterfaceGPUParamInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraDataInterfaceGPUParamInfo A, FNiagaraDataInterfaceGPUParamInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraDataInterfaceGPUParamInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString DataInterfaceHLSLSymbol
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DataInterfaceHLSLSymbol, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DataInterfaceHLSLSymbol, __InBuffer);
				}
			}
		}

		public FString DIClassName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DIClassName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DIClassName, __InBuffer);
				}
			}
		}

		public uint ShaderParametersOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ShaderParametersOffset, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ShaderParametersOffset, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraDataInterfaceGeneratedFunction> GeneratedFunctions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GeneratedFunctions, __ReturnBuffer);

					return *(TArray<FNiagaraDataInterfaceGeneratedFunction>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GeneratedFunctions, __InBuffer);
				}
			}
		}

		private static uint __DataInterfaceHLSLSymbol = 0;

		private static uint __DIClassName = 0;

		private static uint __ShaderParametersOffset = 0;

		private static uint __GeneratedFunctions = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}