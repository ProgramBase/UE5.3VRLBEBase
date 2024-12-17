using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.InterchangeTests
{
	[PathName("/Script/InterchangeTests.AnimationImportTestFunctions")]
	public partial class UAnimationImportTestFunctions : UImportTestFunctionsBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeTests.AnimationImportTestFunctions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FInterchangeTestFunctionResult CheckImportedAnimSequenceCount(TArray<UAnimSequence> AnimSequences, int ExpectedNumberOfImportedAnimSequences)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = AnimSequences?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = ExpectedNumberOfImportedAnimSequences;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckImportedAnimSequenceCount, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckCurveKeyValue(UAnimSequence AnimSequence, FString CurveName, int KeyIndex, float ExpectedCurveKeyValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = AnimSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CurveName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = KeyIndex;

				*(float*)(__InBuffer + 20) = ExpectedCurveKeyValue;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckCurveKeyValue, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckCurveKeyTime(UAnimSequence AnimSequence, FString CurveName, int KeyIndex, float ExpectedCurveKeyTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = AnimSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CurveName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = KeyIndex;

				*(float*)(__InBuffer + 20) = ExpectedCurveKeyTime;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckCurveKeyTime, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckCurveKeyLeaveTangentWeight(UAnimSequence AnimSequence, FString CurveName, int KeyIndex, float ExpectedCurveKeyLeaveTangentWeight)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = AnimSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CurveName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = KeyIndex;

				*(float*)(__InBuffer + 20) = ExpectedCurveKeyLeaveTangentWeight;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckCurveKeyLeaveTangentWeight, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckCurveKeyLeaveTangent(UAnimSequence AnimSequence, FString CurveName, int KeyIndex, float ExpectedCurveKeyLeaveTangent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = AnimSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CurveName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = KeyIndex;

				*(float*)(__InBuffer + 20) = ExpectedCurveKeyLeaveTangent;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckCurveKeyLeaveTangent, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckCurveKeyArriveTangentWeight(UAnimSequence AnimSequence, FString CurveName, int KeyIndex, float ExpectedCurveKeyArriveTangentWeight)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = AnimSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CurveName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = KeyIndex;

				*(float*)(__InBuffer + 20) = ExpectedCurveKeyArriveTangentWeight;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckCurveKeyArriveTangentWeight, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckCurveKeyArriveTangent(UAnimSequence AnimSequence, FString CurveName, int KeyIndex, float ExpectedCurveKeyArriveTangent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = AnimSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CurveName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = KeyIndex;

				*(float*)(__InBuffer + 20) = ExpectedCurveKeyArriveTangent;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckCurveKeyArriveTangent, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckAnimationLength(UAnimSequence AnimSequence, float ExpectedAnimationLength)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = AnimSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = ExpectedAnimationLength;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckAnimationLength, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckAnimationFrameNumber(UAnimSequence AnimSequence, int ExpectedFrameNumber)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = AnimSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = ExpectedFrameNumber;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckAnimationFrameNumber, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		private static uint __CheckImportedAnimSequenceCount = 0;

		private static uint __CheckCurveKeyValue = 0;

		private static uint __CheckCurveKeyTime = 0;

		private static uint __CheckCurveKeyLeaveTangentWeight = 0;

		private static uint __CheckCurveKeyLeaveTangent = 0;

		private static uint __CheckCurveKeyArriveTangentWeight = 0;

		private static uint __CheckCurveKeyArriveTangent = 0;

		private static uint __CheckAnimationLength = 0;

		private static uint __CheckAnimationFrameNumber = 0;
	}
}