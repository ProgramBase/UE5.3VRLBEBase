using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.SequenceEvaluatorLibrary")]
	public partial class USequenceEvaluatorLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraphRuntime.SequenceEvaluatorLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FSequenceEvaluatorReference SetSequenceWithInertialBlending(FAnimUpdateContext UpdateContext, FSequenceEvaluatorReference SequenceEvaluator, UAnimSequenceBase Sequence, float BlendTime = 0.200000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = UpdateContext?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SequenceEvaluator?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = BlendTime;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SetSequenceWithInertialBlending, __InBuffer, __ReturnBuffer);

				return *(FSequenceEvaluatorReference*)__ReturnBuffer;
			}
		}

		public static FSequenceEvaluatorReference SetSequence(FSequenceEvaluatorReference SequenceEvaluator, UAnimSequenceBase Sequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SequenceEvaluator?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SetSequence, __InBuffer, __ReturnBuffer);

				return *(FSequenceEvaluatorReference*)__ReturnBuffer;
			}
		}

		public static FSequenceEvaluatorReference SetExplicitTime(FSequenceEvaluatorReference SequenceEvaluator, float Time)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = SequenceEvaluator?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Time;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SetExplicitTime, __InBuffer, __ReturnBuffer);

				return *(FSequenceEvaluatorReference*)__ReturnBuffer;
			}
		}

		public static UAnimSequenceBase GetSequence(FSequenceEvaluatorReference SequenceEvaluator)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SequenceEvaluator?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetSequence, __InBuffer, __ReturnBuffer);

				return *(UAnimSequenceBase*)__ReturnBuffer;
			}
		}

		public static float GetAccumulatedTime(FSequenceEvaluatorReference SequenceEvaluator)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SequenceEvaluator?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetAccumulatedTime, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static void ConvertToSequenceEvaluatorPure(FAnimNodeReference Node, ref FSequenceEvaluatorReference SequenceEvaluator, ref bool Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Node?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SequenceEvaluator?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = Result;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __ConvertToSequenceEvaluatorPure, __InBuffer, __OutBuffer);

				SequenceEvaluator = *(FSequenceEvaluatorReference*)(__OutBuffer);

				Result = *(bool*)(__OutBuffer + 8);

			}
		}

		public static FSequenceEvaluatorReference ConvertToSequenceEvaluator(FAnimNodeReference Node, ref EAnimNodeReferenceConversionResult Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Node?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Result;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __ConvertToSequenceEvaluator, __InBuffer, __OutBuffer, __ReturnBuffer);

				Result = *(EAnimNodeReferenceConversionResult*)(__OutBuffer);

				return *(FSequenceEvaluatorReference*)__ReturnBuffer;
			}
		}

		public static FSequenceEvaluatorReference AdvanceTime(FAnimUpdateContext UpdateContext, FSequenceEvaluatorReference SequenceEvaluator, float PlayRate = 1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = UpdateContext?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SequenceEvaluator?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = PlayRate;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AdvanceTime, __InBuffer, __ReturnBuffer);

				return *(FSequenceEvaluatorReference*)__ReturnBuffer;
			}
		}

		private static uint __SetSequenceWithInertialBlending = 0;

		private static uint __SetSequence = 0;

		private static uint __SetExplicitTime = 0;

		private static uint __GetSequence = 0;

		private static uint __GetAccumulatedTime = 0;

		private static uint __ConvertToSequenceEvaluatorPure = 0;

		private static uint __ConvertToSequenceEvaluator = 0;

		private static uint __AdvanceTime = 0;
	}
}