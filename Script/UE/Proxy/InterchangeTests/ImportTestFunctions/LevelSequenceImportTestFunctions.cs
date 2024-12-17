using Script.CoreUObject;
using Script.Library;
using Script.LevelSequence;
using Script.Engine;

namespace Script.InterchangeTests
{
	[PathName("/Script/InterchangeTests.LevelSequenceImportTestFunctions")]
	public partial class ULevelSequenceImportTestFunctions : UImportTestFunctionsBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeTests.LevelSequenceImportTestFunctions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FInterchangeTestFunctionResult CheckSequenceLength(ULevelSequence LevelSequence, float ExpectedLevelSequenceLength)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = ExpectedLevelSequenceLength;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckSequenceLength, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckSectionInterpolationMode(ULevelSequence LevelSequence, int SectionIndex, ERichCurveInterpMode ExpectedInterpolationMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = SectionIndex;

				*(byte*)(__InBuffer + 12) = (byte)ExpectedInterpolationMode;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckSectionInterpolationMode, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckSectionCount(ULevelSequence LevelSequence, int ExpectedNumberOfSections)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = ExpectedNumberOfSections;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckSectionCount, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckLevelSequenceCount(TArray<ULevelSequence> LevelSequences, int ExpectedNumberOfLevelSequences)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = LevelSequences?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = ExpectedNumberOfLevelSequences;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckLevelSequenceCount, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		private static uint __CheckSequenceLength = 0;

		private static uint __CheckSectionInterpolationMode = 0;

		private static uint __CheckSectionCount = 0;

		private static uint __CheckLevelSequenceCount = 0;
	}
}