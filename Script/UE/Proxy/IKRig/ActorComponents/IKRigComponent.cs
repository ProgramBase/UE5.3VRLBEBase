using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.IKRig
{
	[PathName("/Script/IKRig.IKRigComponent")]
	public partial class UIKRigComponent : UActorComponent, IStaticClass, IIKGoalCreatorInterface
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IKRig.IKRigComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void AddIKGoals(ref TMap<FName, FIKRigGoal> OutGoals)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutGoals?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __AddIKGoals, __InBuffer, __OutBuffer);

				OutGoals = *(TMap<FName, FIKRigGoal>*)(__OutBuffer);

			}
		}

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		public virtual void SetIKRigGoalTransform(FName GoalName, FTransform Transform, float PositionAlpha, float RotationAlpha)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = GoalName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Transform?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = PositionAlpha;

				*(float*)(__InBuffer + 20) = RotationAlpha;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetIKRigGoalTransform, __InBuffer);
			}
		}

		public virtual void SetIKRigGoalPositionAndRotation(FName GoalName, FVector Position, FQuat Rotation, float PositionAlpha, float RotationAlpha)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = GoalName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Position?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = PositionAlpha;

				*(float*)(__InBuffer + 28) = RotationAlpha;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetIKRigGoalPositionAndRotation, __InBuffer);
			}
		}

		public virtual void SetIKRigGoal(FIKRigGoal Goal)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Goal?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetIKRigGoal, __InBuffer);
			}
		}

		public virtual void ClearAllGoals()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearAllGoals);
			}
		}

		private static uint __AddIKGoals = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __SetIKRigGoalTransform = 0;

		private static uint __SetIKRigGoalPositionAndRotation = 0;

		private static uint __SetIKRigGoal = 0;

		private static uint __ClearAllGoals = 0;
	}
}