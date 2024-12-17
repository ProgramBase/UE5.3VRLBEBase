using Script.CoreUObject;
using Script.Library;

namespace Script.MaterialShaderQualitySettings
{
	[PathName("/Script/MaterialShaderQualitySettings.MaterialQualityOverrides")]
	public partial class FMaterialQualityOverrides : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MaterialShaderQualitySettings.MaterialQualityOverrides");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMaterialQualityOverrides() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMaterialQualityOverrides() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMaterialQualityOverrides A, FMaterialQualityOverrides B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMaterialQualityOverrides A, FMaterialQualityOverrides B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMaterialQualityOverrides;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bDiscardQualityDuringCook
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bDiscardQualityDuringCook, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bDiscardQualityDuringCook, __InBuffer);
				}
			}
		}

		public bool bEnableOverride
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bEnableOverride, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bEnableOverride, __InBuffer);
				}
			}
		}

		public bool bForceFullyRough
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bForceFullyRough, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bForceFullyRough, __InBuffer);
				}
			}
		}

		public bool bForceNonMetal
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bForceNonMetal, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bForceNonMetal, __InBuffer);
				}
			}
		}

		public bool bForceDisableLMDirectionality
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bForceDisableLMDirectionality, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bForceDisableLMDirectionality, __InBuffer);
				}
			}
		}

		public bool bForceDisablePreintegratedGF
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bForceDisablePreintegratedGF, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bForceDisablePreintegratedGF, __InBuffer);
				}
			}
		}

		public bool bDisableMaterialNormalCalculation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bDisableMaterialNormalCalculation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bDisableMaterialNormalCalculation, __InBuffer);
				}
			}
		}

		public EMobileShadowQuality MobileShadowQuality
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MobileShadowQuality, __ReturnBuffer);

					return *(EMobileShadowQuality*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MobileShadowQuality, __InBuffer);
				}
			}
		}

		private static uint __bDiscardQualityDuringCook = 0;

		private static uint __bEnableOverride = 0;

		private static uint __bForceFullyRough = 0;

		private static uint __bForceNonMetal = 0;

		private static uint __bForceDisableLMDirectionality = 0;

		private static uint __bForceDisablePreintegratedGF = 0;

		private static uint __bDisableMaterialNormalCalculation = 0;

		private static uint __MobileShadowQuality = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}