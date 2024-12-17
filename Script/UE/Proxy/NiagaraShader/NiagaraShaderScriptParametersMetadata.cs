using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraShader
{
	[PathName("/Script/NiagaraShader.NiagaraShaderScriptParametersMetadata")]
	public partial class FNiagaraShaderScriptParametersMetadata : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraShader.NiagaraShaderScriptParametersMetadata");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraShaderScriptParametersMetadata() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraShaderScriptParametersMetadata() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraShaderScriptParametersMetadata A, FNiagaraShaderScriptParametersMetadata B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraShaderScriptParametersMetadata A, FNiagaraShaderScriptParametersMetadata B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraShaderScriptParametersMetadata;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FNiagaraDataInterfaceGPUParamInfo> DataInterfaceParamInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DataInterfaceParamInfo, __ReturnBuffer);

					return *(TArray<FNiagaraDataInterfaceGPUParamInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DataInterfaceParamInfo, __InBuffer);
				}
			}
		}

		public TArray<FString> LooseMetadataNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LooseMetadataNames, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LooseMetadataNames, __InBuffer);
				}
			}
		}

		public bool bExternalConstantsInterpolated
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bExternalConstantsInterpolated, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bExternalConstantsInterpolated, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraShaderScriptExternalConstant> ExternalConstants
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExternalConstants, __ReturnBuffer);

					return *(TArray<FNiagaraShaderScriptExternalConstant>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExternalConstants, __InBuffer);
				}
			}
		}

		private static uint __DataInterfaceParamInfo = 0;

		private static uint __LooseMetadataNames = 0;

		private static uint __bExternalConstantsInterpolated = 0;

		private static uint __ExternalConstants = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}