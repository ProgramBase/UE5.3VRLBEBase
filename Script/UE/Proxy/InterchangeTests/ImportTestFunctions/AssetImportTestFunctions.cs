using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeTests
{
	[PathName("/Script/InterchangeTests.AssetImportTestFunctions")]
	public partial class UAssetImportTestFunctions : UImportTestFunctionsBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeTests.AssetImportTestFunctions");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="ExpectedMetadataKey">
		/// - The object metadata key to pass to the package to retrieve the metadata value
		/// </param>
		/// <param name="ExpectedMetadataValue">
		/// - The value to compare the object metadata query with the metadata key
		/// </param>
		public static FInterchangeTestFunctionResult CheckMetadataValue(UObject Object, FString ExpectedMetadataKey, FString ExpectedMetadataValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ExpectedMetadataKey?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ExpectedMetadataValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckMetadataValue, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		/// <param name="ExpectedMetadataKey">
		/// - The object metadata key to pass to the package to retrieve the metadata value
		/// </param>
		public static FInterchangeTestFunctionResult CheckMetadataExist(UObject Object, FString ExpectedMetadataKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ExpectedMetadataKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckMetadataExist, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckImportedMetadataCount(UObject Object, int ExpectedNumberOfMetadataForThisObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = ExpectedNumberOfMetadataForThisObject;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckImportedMetadataCount, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		private static uint __CheckMetadataValue = 0;

		private static uint __CheckMetadataExist = 0;

		private static uint __CheckImportedMetadataCount = 0;
	}
}