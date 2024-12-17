using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeTests
{
	[PathName("/Script/InterchangeTests.InterchangeImportTestStepReimport")]
	public partial class UInterchangeImportTestStepReimport : UInterchangeImportTestStepBase, IStaticClass
	{
		public FFilePath SourceFileToReimport
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SourceFileToReimport, __ReturnBuffer);

					return *(FFilePath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SourceFileToReimport, __InBuffer);
				}
			}
		}

		public TSubclassOf<UObject> AssetTypeToReimport
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AssetTypeToReimport, __ReturnBuffer);

					return *(TSubclassOf<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AssetTypeToReimport, __InBuffer);
				}
			}
		}

		public FString AssetNameToReimport
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AssetNameToReimport, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AssetNameToReimport, __InBuffer);
				}
			}
		}

		public bool bSaveThenReloadImportedAssets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSaveThenReloadImportedAssets, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSaveThenReloadImportedAssets, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeTests.InterchangeImportTestStepReimport");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SourceFileToReimport = 0;

		private static uint __AssetTypeToReimport = 0;

		private static uint __AssetNameToReimport = 0;

		private static uint __bSaveThenReloadImportedAssets = 0;
	}
}