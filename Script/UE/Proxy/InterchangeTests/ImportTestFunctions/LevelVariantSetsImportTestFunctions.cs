using Script.CoreUObject;
using Script.Library;
using Script.VariantManagerContent;

namespace Script.InterchangeTests
{
	[PathName("/Script/InterchangeTests.LevelVariantSetsImportTestFunctions")]
	public partial class ULevelVariantSetsImportTestFunctions : UImportTestFunctionsBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeTests.LevelVariantSetsImportTestFunctions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FInterchangeTestFunctionResult CheckVariantSetsCount(ULevelVariantSets LevelVariantSets, int ExpectedNumberOfVariantSets)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = LevelVariantSets?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = ExpectedNumberOfVariantSets;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckVariantSetsCount, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckVariantsCount(ULevelVariantSets LevelVariantSets, FString VariantSetName, int ExpectedNumberOfVariants)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = LevelVariantSets?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = VariantSetName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = ExpectedNumberOfVariants;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckVariantsCount, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckLevelVariantSetsCount(TArray<ULevelVariantSets> LevelVariantSetsAssets, int ExpectedNumberOfLevelVariantSets)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = LevelVariantSetsAssets?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = ExpectedNumberOfLevelVariantSets;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckLevelVariantSetsCount, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckBindingsCount(ULevelVariantSets LevelVariantSets, FString VariantSetName, FString VariantName, int ExpectedNumberOfBindings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = LevelVariantSets?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = VariantSetName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = VariantName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 24) = ExpectedNumberOfBindings;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckBindingsCount, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		private static uint __CheckVariantSetsCount = 0;

		private static uint __CheckVariantsCount = 0;

		private static uint __CheckLevelVariantSetsCount = 0;

		private static uint __CheckBindingsCount = 0;
	}
}