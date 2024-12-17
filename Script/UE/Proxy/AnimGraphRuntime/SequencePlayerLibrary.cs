using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.SequencePlayerLibrary")]
	public partial class USequencePlayerLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraphRuntime.SequencePlayerLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FSequencePlayerReference SetStartPosition(FSequencePlayerReference SequencePlayer, float StartPosition)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = SequencePlayer?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = StartPosition;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SetStartPosition, __InBuffer, __ReturnBuffer);

				return *(FSequencePlayerReference*)__ReturnBuffer;
			}
		}

		public static FSequencePlayerReference SetSequenceWithInertialBlending(FAnimUpdateContext UpdateContext, FSequencePlayerReference SequencePlayer, UAnimSequenceBase Sequence, float BlendTime = 0.200000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = UpdateContext?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SequencePlayer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = BlendTime;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SetSequenceWithInertialBlending, __InBuffer, __ReturnBuffer);

				return *(FSequencePlayerReference*)__ReturnBuffer;
			}
		}

		public static FSequencePlayerReference SetSequence(FSequencePlayerReference SequencePlayer, UAnimSequenceBase Sequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SequencePlayer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SetSequence, __InBuffer, __ReturnBuffer);

				return *(FSequencePlayerReference*)__ReturnBuffer;
			}
		}

		public static FSequencePlayerReference SetPlayRate(FSequencePlayerReference SequencePlayer, float PlayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = SequencePlayer?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = PlayRate;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SetPlayRate, __InBuffer, __ReturnBuffer);

				return *(FSequencePlayerReference*)__ReturnBuffer;
			}
		}

		public static FSequencePlayerReference SetAccumulatedTime(FSequencePlayerReference SequencePlayer, float Time)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = SequencePlayer?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Time;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SetAccumulatedTime, __InBuffer, __ReturnBuffer);

				return *(FSequencePlayerReference*)__ReturnBuffer;
			}
		}

		public static float GetStartPosition(FSequencePlayerReference SequencePlayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SequencePlayer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetStartPosition, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static UAnimSequenceBase GetSequencePure(FSequencePlayerReference SequencePlayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SequencePlayer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetSequencePure, __InBuffer, __ReturnBuffer);

				return *(UAnimSequenceBase*)__ReturnBuffer;
			}
		}

		public static FSequencePlayerReference GetSequence(FSequencePlayerReference SequencePlayer, ref UAnimSequenceBase SequenceBase)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SequencePlayer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __GetSequence, __InBuffer, __OutBuffer, __ReturnBuffer);

				SequenceBase = *(UAnimSequenceBase*)(__OutBuffer);

				return *(FSequencePlayerReference*)__ReturnBuffer;
			}
		}

		public static float GetPlayRate(FSequencePlayerReference SequencePlayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SequencePlayer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPlayRate, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static bool GetLoopAnimation(FSequencePlayerReference SequencePlayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SequencePlayer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLoopAnimation, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static float GetAccumulatedTime(FSequencePlayerReference SequencePlayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SequencePlayer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetAccumulatedTime, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static void ConvertToSequencePlayerPure(FAnimNodeReference Node, ref FSequencePlayerReference SequencePlayer, ref bool Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Node?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SequencePlayer?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = Result;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __ConvertToSequencePlayerPure, __InBuffer, __OutBuffer);

				SequencePlayer = *(FSequencePlayerReference*)(__OutBuffer);

				Result = *(bool*)(__OutBuffer + 8);

			}
		}

		public static FSequencePlayerReference ConvertToSequencePlayer(FAnimNodeReference Node, ref EAnimNodeReferenceConversionResult Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Node?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Result;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __ConvertToSequencePlayer, __InBuffer, __OutBuffer, __ReturnBuffer);

				Result = *(EAnimNodeReferenceConversionResult*)(__OutBuffer);

				return *(FSequencePlayerReference*)__ReturnBuffer;
			}
		}

		public static float ComputePlayRateFromDuration(FSequencePlayerReference SequencePlayer, float Duration = 1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = SequencePlayer?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Duration;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ComputePlayRateFromDuration, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __SetStartPosition = 0;

		private static uint __SetSequenceWithInertialBlending = 0;

		private static uint __SetSequence = 0;

		private static uint __SetPlayRate = 0;

		private static uint __SetAccumulatedTime = 0;

		private static uint __GetStartPosition = 0;

		private static uint __GetSequencePure = 0;

		private static uint __GetSequence = 0;

		private static uint __GetPlayRate = 0;

		private static uint __GetLoopAnimation = 0;

		private static uint __GetAccumulatedTime = 0;

		private static uint __ConvertToSequencePlayerPure = 0;

		private static uint __ConvertToSequencePlayer = 0;

		private static uint __ComputePlayRateFromDuration = 0;
	}
}