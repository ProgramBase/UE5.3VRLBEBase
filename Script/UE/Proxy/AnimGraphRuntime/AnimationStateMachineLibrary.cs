using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimationStateMachineLibrary")]
	public partial class UAnimationStateMachineLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraphRuntime.AnimationStateMachineLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void SetState(FAnimUpdateContext UpdateContext, FAnimationStateMachineReference Node, FName TargetState, float Duration, ETransitionLogicType BlendType, UBlendProfile BlendProfile, EAlphaBlendOption AlphaBlendOption, UCurveFloat CustomBlendCurve)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[46];

				*(nint*)(__InBuffer) = UpdateContext?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Node?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = TargetState?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Duration;

				*(byte*)(__InBuffer + 28) = (byte)BlendType;

				*(nint*)(__InBuffer + 29) = BlendProfile?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 37) = (byte)AlphaBlendOption;

				*(nint*)(__InBuffer + 38) = CustomBlendCurve?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetState, __InBuffer);
			}
		}

		public static bool IsStateBlendingOut(FAnimUpdateContext UpdateContext, FAnimationStateResultReference Node)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = UpdateContext?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Node?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsStateBlendingOut, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsStateBlendingIn(FAnimUpdateContext UpdateContext, FAnimationStateResultReference Node)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = UpdateContext?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Node?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsStateBlendingIn, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FName GetState(FAnimUpdateContext UpdateContext, FAnimationStateMachineReference Node)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = UpdateContext?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Node?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetState, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public static float GetRelevantAnimTimeRemainingFraction(FAnimUpdateContext UpdateContext, FAnimationStateResultReference Node)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = UpdateContext?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Node?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetRelevantAnimTimeRemainingFraction, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static float GetRelevantAnimTimeRemaining(FAnimUpdateContext UpdateContext, FAnimationStateResultReference Node)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = UpdateContext?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Node?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetRelevantAnimTimeRemaining, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static void ConvertToAnimationStateResultPure(FAnimNodeReference Node, ref FAnimationStateResultReference AnimationState, ref bool Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Node?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AnimationState?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = Result;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __ConvertToAnimationStateResultPure, __InBuffer, __OutBuffer);

				AnimationState = *(FAnimationStateResultReference*)(__OutBuffer);

				Result = *(bool*)(__OutBuffer + 8);

			}
		}

		public static void ConvertToAnimationStateResult(FAnimNodeReference Node, ref FAnimationStateResultReference AnimationState, ref EAnimNodeReferenceConversionResult Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Node?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AnimationState?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)Result;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __ConvertToAnimationStateResult, __InBuffer, __OutBuffer);

				AnimationState = *(FAnimationStateResultReference*)(__OutBuffer);

				Result = *(EAnimNodeReferenceConversionResult*)(__OutBuffer + 8);

			}
		}

		public static void ConvertToAnimationStateMachinePure(FAnimNodeReference Node, ref FAnimationStateMachineReference AnimationState, ref bool Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Node?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AnimationState?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = Result;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __ConvertToAnimationStateMachinePure, __InBuffer, __OutBuffer);

				AnimationState = *(FAnimationStateMachineReference*)(__OutBuffer);

				Result = *(bool*)(__OutBuffer + 8);

			}
		}

		public static void ConvertToAnimationStateMachine(FAnimNodeReference Node, ref FAnimationStateMachineReference AnimationState, ref EAnimNodeReferenceConversionResult Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Node?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AnimationState?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)Result;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __ConvertToAnimationStateMachine, __InBuffer, __OutBuffer);

				AnimationState = *(FAnimationStateMachineReference*)(__OutBuffer);

				Result = *(EAnimNodeReferenceConversionResult*)(__OutBuffer + 8);

			}
		}

		private static uint __SetState = 0;

		private static uint __IsStateBlendingOut = 0;

		private static uint __IsStateBlendingIn = 0;

		private static uint __GetState = 0;

		private static uint __GetRelevantAnimTimeRemainingFraction = 0;

		private static uint __GetRelevantAnimTimeRemaining = 0;

		private static uint __ConvertToAnimationStateResultPure = 0;

		private static uint __ConvertToAnimationStateResult = 0;

		private static uint __ConvertToAnimationStateMachinePure = 0;

		private static uint __ConvertToAnimationStateMachine = 0;
	}
}