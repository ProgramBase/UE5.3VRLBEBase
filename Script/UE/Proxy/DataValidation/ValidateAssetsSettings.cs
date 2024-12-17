using Script.CoreUObject;
using Script.Library;

namespace Script.DataValidation
{
	[PathName("/Script/DataValidation.ValidateAssetsSettings")]
	public partial class FValidateAssetsSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DataValidation.ValidateAssetsSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FValidateAssetsSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FValidateAssetsSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FValidateAssetsSettings A, FValidateAssetsSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FValidateAssetsSettings A, FValidateAssetsSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FValidateAssetsSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bSkipExcludedDirectories
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bSkipExcludedDirectories, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bSkipExcludedDirectories, __InBuffer);
				}
			}
		}

		public bool bShowIfNoFailures
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bShowIfNoFailures, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bShowIfNoFailures, __InBuffer);
				}
			}
		}

		public bool bCollectPerAssetDetails
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bCollectPerAssetDetails, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bCollectPerAssetDetails, __InBuffer);
				}
			}
		}

		public EDataValidationUsecase ValidationUsecase
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ValidationUsecase, __ReturnBuffer);

					return *(EDataValidationUsecase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ValidationUsecase, __InBuffer);
				}
			}
		}

		private static uint __bSkipExcludedDirectories = 0;

		private static uint __bShowIfNoFailures = 0;

		private static uint __bCollectPerAssetDetails = 0;

		private static uint __ValidationUsecase = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}