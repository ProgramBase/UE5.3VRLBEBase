using Script.CoreUObject;
using Script.GameplayTasks.GameplayTask;
using Script.Library;
using Script.Engine;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AITask_MoveTo")]
	public partial class UAITask_MoveTo : UAITask, IStaticClass
	{
		public FGenericGameplayTaskDelegate OnRequestFailed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnRequestFailed, __ReturnBuffer);

					return *(FGenericGameplayTaskDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnRequestFailed, __InBuffer);
				}
			}
		}

		public FMoveTaskCompletedSignature OnMoveFinished
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnMoveFinished, __ReturnBuffer);

					return *(FMoveTaskCompletedSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnMoveFinished, __InBuffer);
				}
			}
		}

		public FAIMoveRequest MoveRequest
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MoveRequest, __ReturnBuffer);

					return *(FAIMoveRequest*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MoveRequest, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.AITask_MoveTo");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UAITask_MoveTo AIMoveTo(AAIController Controller, FVector GoalLocation, AActor GoalActor = null, float AcceptanceRadius = -1.000000f, EAIOptionFlag StopOnOverlap = EAIOptionFlag.Default, EAIOptionFlag AcceptPartialPath = EAIOptionFlag.Default, bool bUsePathfinding = true, bool bLockAILogic = true, bool bUseContinuousGoalTracking = false, EAIOptionFlag ProjectGoalOnNavigation = EAIOptionFlag.Default)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[34];

				*(nint*)(__InBuffer) = Controller?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = GoalLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = GoalActor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = AcceptanceRadius;

				*(byte*)(__InBuffer + 28) = (byte)StopOnOverlap;

				*(byte*)(__InBuffer + 29) = (byte)AcceptPartialPath;

				*(bool*)(__InBuffer + 30) = bUsePathfinding;

				*(bool*)(__InBuffer + 31) = bLockAILogic;

				*(bool*)(__InBuffer + 32) = bUseContinuousGoalTracking;

				*(byte*)(__InBuffer + 33) = (byte)ProjectGoalOnNavigation;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AIMoveTo, __InBuffer, __ReturnBuffer);

				return *(UAITask_MoveTo*)__ReturnBuffer;
			}
		}

		private static uint __OnRequestFailed = 0;

		private static uint __OnMoveFinished = 0;

		private static uint __MoveRequest = 0;

		private static uint __AIMoveTo = 0;
	}
}