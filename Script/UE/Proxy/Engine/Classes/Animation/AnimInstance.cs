using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimInstance")]
	public partial class UAnimInstance : UObject, IStaticClass
	{
		public USkeleton CurrentSkeleton
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentSkeleton, __ReturnBuffer);

					return *(USkeleton*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentSkeleton, __InBuffer);
				}
			}
		}

		public ERootMotionMode RootMotionMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RootMotionMode, __ReturnBuffer);

					return *(ERootMotionMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RootMotionMode, __InBuffer);
				}
			}
		}

		public bool bUseMultiThreadedAnimationUpdate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseMultiThreadedAnimationUpdate, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseMultiThreadedAnimationUpdate, __InBuffer);
				}
			}
		}

		public bool bUsingCopyPoseFromMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUsingCopyPoseFromMesh, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUsingCopyPoseFromMesh, __InBuffer);
				}
			}
		}

		public bool bReceiveNotifiesFromLinkedInstances
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bReceiveNotifiesFromLinkedInstances, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bReceiveNotifiesFromLinkedInstances, __InBuffer);
				}
			}
		}

		public bool bPropagateNotifiesToLinkedInstances
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPropagateNotifiesToLinkedInstances, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPropagateNotifiesToLinkedInstances, __InBuffer);
				}
			}
		}

		public bool bUseMainInstanceMontageEvaluationData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseMainInstanceMontageEvaluationData, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseMainInstanceMontageEvaluationData, __InBuffer);
				}
			}
		}

		public bool bQueueMontageEvents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bQueueMontageEvents, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bQueueMontageEvents, __InBuffer);
				}
			}
		}

		public FOnMontageBlendingOutStartedMCDelegate OnMontageBlendingOut
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnMontageBlendingOut, __ReturnBuffer);

					return *(FOnMontageBlendingOutStartedMCDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnMontageBlendingOut, __InBuffer);
				}
			}
		}

		public FOnMontageStartedMCDelegate OnMontageStarted
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnMontageStarted, __ReturnBuffer);

					return *(FOnMontageStartedMCDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnMontageStarted, __InBuffer);
				}
			}
		}

		public FOnMontageEndedMCDelegate OnMontageEnded
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnMontageEnded, __ReturnBuffer);

					return *(FOnMontageEndedMCDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnMontageEnded, __InBuffer);
				}
			}
		}

		public FOnAllMontageInstancesEndedMCDelegate OnAllMontageInstancesEnded
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnAllMontageInstancesEnded, __ReturnBuffer);

					return *(FOnAllMontageInstancesEndedMCDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnAllMontageInstancesEnded, __InBuffer);
				}
			}
		}

		public FSoftClassPath PostCompileValidationClassName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PostCompileValidationClassName, __ReturnBuffer);

					return *(FSoftClassPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PostCompileValidationClassName, __InBuffer);
				}
			}
		}

		public FAnimNotifyQueue NotifyQueue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NotifyQueue, __ReturnBuffer);

					return *(FAnimNotifyQueue*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NotifyQueue, __InBuffer);
				}
			}
		}

		public TArray<FAnimNotifyEvent> ActiveAnimNotifyState
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveAnimNotifyState, __ReturnBuffer);

					return *(TArray<FAnimNotifyEvent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveAnimNotifyState, __InBuffer);
				}
			}
		}

		public TArray<FAnimNotifyEventReference> ActiveAnimNotifyEventReference
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveAnimNotifyEventReference, __ReturnBuffer);

					return *(TArray<FAnimNotifyEventReference>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveAnimNotifyEventReference, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimInstance");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool WasAnimNotifyTriggeredInStateMachine(int MachineIndex, TSubclassOf<UAnimNotify> AnimNotifyType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = MachineIndex;

				*(nint*)(__InBuffer + 4) = AnimNotifyType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __WasAnimNotifyTriggeredInStateMachine, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool WasAnimNotifyTriggeredInSourceState(int MachineIndex, int StateIndex, TSubclassOf<UAnimNotify> AnimNotifyType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(int*)(__InBuffer) = MachineIndex;

				*(int*)(__InBuffer + 4) = StateIndex;

				*(nint*)(__InBuffer + 8) = AnimNotifyType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __WasAnimNotifyTriggeredInSourceState, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool WasAnimNotifyTriggeredInAnyState(TSubclassOf<UAnimNotify> AnimNotifyType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AnimNotifyType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __WasAnimNotifyTriggeredInAnyState, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool WasAnimNotifyStateActiveInStateMachine(int MachineIndex, TSubclassOf<UAnimNotifyState> AnimNotifyStateType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = MachineIndex;

				*(nint*)(__InBuffer + 4) = AnimNotifyStateType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __WasAnimNotifyStateActiveInStateMachine, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool WasAnimNotifyStateActiveInSourceState(int MachineIndex, int StateIndex, TSubclassOf<UAnimNotifyState> AnimNotifyStateType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(int*)(__InBuffer) = MachineIndex;

				*(int*)(__InBuffer + 4) = StateIndex;

				*(nint*)(__InBuffer + 8) = AnimNotifyStateType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __WasAnimNotifyStateActiveInSourceState, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool WasAnimNotifyStateActiveInAnyState(TSubclassOf<UAnimNotifyState> AnimNotifyStateType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AnimNotifyStateType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __WasAnimNotifyStateActiveInAnyState, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool WasAnimNotifyNameTriggeredInStateMachine(int MachineIndex, FName NotifyName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = MachineIndex;

				*(nint*)(__InBuffer + 4) = NotifyName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __WasAnimNotifyNameTriggeredInStateMachine, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool WasAnimNotifyNameTriggeredInSourceState(int MachineIndex, int StateIndex, FName NotifyName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(int*)(__InBuffer) = MachineIndex;

				*(int*)(__InBuffer + 4) = StateIndex;

				*(nint*)(__InBuffer + 8) = NotifyName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __WasAnimNotifyNameTriggeredInSourceState, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool WasAnimNotifyNameTriggeredInAnyState(FName NotifyName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NotifyName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __WasAnimNotifyNameTriggeredInAnyState, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void UnlockAIResources(bool bUnlockMovement, bool UnlockAILogic)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = bUnlockMovement;

				*(bool*)(__InBuffer + 1) = UnlockAILogic;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UnlockAIResources, __InBuffer);
			}
		}

		public virtual void UnlinkAnimClassLayers(TSubclassOf<UAnimInstance> InClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InClass?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UnlinkAnimClassLayers, __InBuffer);
			}
		}

		public virtual APawn TryGetPawnOwner()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __TryGetPawnOwner, __ReturnBuffer);

				return *(APawn*)__ReturnBuffer;
			}
		}

		public virtual void StopSlotAnimation(float InBlendOutTime = 0.250000f, FName SlotNodeName = null)
		{
			unsafe
			{
				SlotNodeName ??= new FName("None");

				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = InBlendOutTime;

				*(nint*)(__InBuffer + 4) = SlotNodeName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StopSlotAnimation, __InBuffer);
			}
		}

		public virtual void SnapshotPose(ref FPoseSnapshot Snapshot)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Snapshot?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __SnapshotPose, __InBuffer, __OutBuffer);

				Snapshot = *(FPoseSnapshot*)(__OutBuffer);

			}
		}

		public virtual void SetUseMainInstanceMontageEvaluationData(bool bSet)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bSet;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetUseMainInstanceMontageEvaluationData, __InBuffer);
			}
		}

		public virtual void SetRootMotionMode(ERootMotionMode Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRootMotionMode, __InBuffer);
			}
		}

		public virtual void SetReceiveNotifiesFromLinkedInstances(bool bSet)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bSet;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetReceiveNotifiesFromLinkedInstances, __InBuffer);
			}
		}

		public virtual void SetPropagateNotifiesToLinkedInstances(bool bSet)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bSet;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPropagateNotifiesToLinkedInstances, __InBuffer);
			}
		}

		public virtual void SetMorphTarget(FName MorphTargetName, float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = MorphTargetName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMorphTarget, __InBuffer);
			}
		}

		public virtual void SavePoseSnapshot(FName SnapshotName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SnapshotName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SavePoseSnapshot, __InBuffer);
			}
		}

		public virtual void ResetDynamics(ETeleportType InTeleportType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InTeleportType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ResetDynamics, __InBuffer);
			}
		}

		public virtual bool RequestTransitionEvent(FName EventName, double RequestTimeout, ETransitionRequestQueueMode QueueMode, ETransitionRequestOverwriteMode OverwriteMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = EventName?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = RequestTimeout;

				*(byte*)(__InBuffer + 16) = (byte)QueueMode;

				*(byte*)(__InBuffer + 17) = (byte)OverwriteMode;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RequestTransitionEvent, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void RequestSlotGroupInertialization(FName InSlotGroupName, float Duration, UBlendProfile BlendProfile = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = InSlotGroupName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Duration;

				*(nint*)(__InBuffer + 12) = BlendProfile?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RequestSlotGroupInertialization, __InBuffer);
			}
		}

		public virtual void RemovePoseSnapshot(FName SnapshotName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SnapshotName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemovePoseSnapshot, __InBuffer);
			}
		}

		public virtual bool QueryTransitionEvent(int MachineIndex, int TransitionIndex, FName EventName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(int*)(__InBuffer) = MachineIndex;

				*(int*)(__InBuffer + 4) = TransitionIndex;

				*(nint*)(__InBuffer + 8) = EventName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __QueryTransitionEvent, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool QueryAndMarkTransitionEvent(int MachineIndex, int TransitionIndex, FName EventName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(int*)(__InBuffer) = MachineIndex;

				*(int*)(__InBuffer + 4) = TransitionIndex;

				*(nint*)(__InBuffer + 8) = EventName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __QueryAndMarkTransitionEvent, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual UAnimMontage PlaySlotAnimationAsDynamicMontage_WithBlendSettings(UAnimSequenceBase Asset, FName SlotNodeName, FMontageBlendSettings BlendInSettings, FMontageBlendSettings BlendOutSettings, float InPlayRate = 1.000000f, int LoopCount = 1, float BlendOutTriggerTime = -1.000000f, float InTimeToStartMontageAt = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[48];

				*(nint*)(__InBuffer) = Asset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SlotNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = BlendInSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = BlendOutSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 32) = InPlayRate;

				*(int*)(__InBuffer + 36) = LoopCount;

				*(float*)(__InBuffer + 40) = BlendOutTriggerTime;

				*(float*)(__InBuffer + 44) = InTimeToStartMontageAt;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __PlaySlotAnimationAsDynamicMontage_WithBlendSettings, __InBuffer, __ReturnBuffer);

				return *(UAnimMontage*)__ReturnBuffer;
			}
		}

		public virtual UAnimMontage PlaySlotAnimationAsDynamicMontage_WithBlendArgs(UAnimSequenceBase Asset, FName SlotNodeName, FAlphaBlendArgs BlendIn, FAlphaBlendArgs BlendOut, float InPlayRate = 1.000000f, int LoopCount = 1, float BlendOutTriggerTime = -1.000000f, float InTimeToStartMontageAt = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[48];

				*(nint*)(__InBuffer) = Asset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SlotNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = BlendIn?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = BlendOut?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 32) = InPlayRate;

				*(int*)(__InBuffer + 36) = LoopCount;

				*(float*)(__InBuffer + 40) = BlendOutTriggerTime;

				*(float*)(__InBuffer + 44) = InTimeToStartMontageAt;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __PlaySlotAnimationAsDynamicMontage_WithBlendArgs, __InBuffer, __ReturnBuffer);

				return *(UAnimMontage*)__ReturnBuffer;
			}
		}

		public virtual UAnimMontage PlaySlotAnimationAsDynamicMontage(UAnimSequenceBase Asset, FName SlotNodeName, float BlendInTime = 0.250000f, float BlendOutTime = 0.250000f, float InPlayRate = 1.000000f, int LoopCount = 1, float BlendOutTriggerTime = -1.000000f, float InTimeToStartMontageAt = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = Asset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SlotNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = BlendInTime;

				*(float*)(__InBuffer + 20) = BlendOutTime;

				*(float*)(__InBuffer + 24) = InPlayRate;

				*(int*)(__InBuffer + 28) = LoopCount;

				*(float*)(__InBuffer + 32) = BlendOutTriggerTime;

				*(float*)(__InBuffer + 36) = InTimeToStartMontageAt;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __PlaySlotAnimationAsDynamicMontage, __InBuffer, __ReturnBuffer);

				return *(UAnimMontage*)__ReturnBuffer;
			}
		}

		/// <param name="MontageFollower">
		/// : The montage we want to stop synchronizing */
		/// </param>
		public virtual void MontageSync_StopFollowing(UAnimMontage MontageFollower)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MontageFollower?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __MontageSync_StopFollowing, __InBuffer);
			}
		}

		/// <param name="MontageFollower">
		/// : The montage that will follow the leader in OtherAnimInstance
		/// </param>
		/// <param name="OtherAnimInstance">
		/// : The other anim instance we want to synchronize to. Can be set to self
		/// </param>
		/// <param name="MontageLeader">
		/// : The montage we want to follow in the other anim instance */
		/// </param>
		public virtual void MontageSync_Follow(UAnimMontage MontageFollower, UAnimInstance OtherAnimInstance, UAnimMontage MontageLeader)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = MontageFollower?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OtherAnimInstance?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = MontageLeader?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __MontageSync_Follow, __InBuffer);
			}
		}

		public virtual void Montage_StopWithBlendSettings(FMontageBlendSettings BlendOutSettings, UAnimMontage Montage = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = BlendOutSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Montage?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Montage_StopWithBlendSettings, __InBuffer);
			}
		}

		public virtual void Montage_StopWithBlendOut(FAlphaBlendArgs BlendOut, UAnimMontage Montage = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = BlendOut?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Montage?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Montage_StopWithBlendOut, __InBuffer);
			}
		}

		public virtual void Montage_StopGroupByName(float InBlendOutTime, FName GroupName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = InBlendOutTime;

				*(nint*)(__InBuffer + 4) = GroupName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Montage_StopGroupByName, __InBuffer);
			}
		}

		public virtual void Montage_Stop(float InBlendOutTime, UAnimMontage Montage = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = InBlendOutTime;

				*(nint*)(__InBuffer + 4) = Montage?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Montage_Stop, __InBuffer);
			}
		}

		public virtual void Montage_SetPosition(UAnimMontage Montage, float NewPosition)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Montage?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = NewPosition;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Montage_SetPosition, __InBuffer);
			}
		}

		public virtual void Montage_SetPlayRate(UAnimMontage Montage, float NewPlayRate = 1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Montage?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = NewPlayRate;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Montage_SetPlayRate, __InBuffer);
			}
		}

		/// <param name="SectionNameToChange">
		/// : This should be the name of the Montage Section after which you want to insert a new next section
		/// </param>
		/// <param name="NextSection">
		/// : new next section 
		/// </param>
		public virtual void Montage_SetNextSection(FName SectionNameToChange, FName NextSection, UAnimMontage Montage = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = SectionNameToChange?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NextSection?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Montage?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Montage_SetNextSection, __InBuffer);
			}
		}

		public virtual void Montage_Resume(UAnimMontage Montage)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Montage?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Montage_Resume, __InBuffer);
			}
		}

		public virtual float Montage_PlayWithBlendSettings(UAnimMontage MontageToPlay, FMontageBlendSettings BlendInSettings, float InPlayRate = 1.000000f, EMontagePlayReturnType ReturnValueType = EMontagePlayReturnType.MontageLength, float InTimeToStartMontageAt = 0.000000f, bool bStopAllMontages = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = MontageToPlay?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BlendInSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = InPlayRate;

				*(byte*)(__InBuffer + 20) = (byte)ReturnValueType;

				*(float*)(__InBuffer + 21) = InTimeToStartMontageAt;

				*(bool*)(__InBuffer + 25) = bStopAllMontages;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __Montage_PlayWithBlendSettings, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float Montage_PlayWithBlendIn(UAnimMontage MontageToPlay, FAlphaBlendArgs BlendIn, float InPlayRate = 1.000000f, EMontagePlayReturnType ReturnValueType = EMontagePlayReturnType.MontageLength, float InTimeToStartMontageAt = 0.000000f, bool bStopAllMontages = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = MontageToPlay?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BlendIn?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = InPlayRate;

				*(byte*)(__InBuffer + 20) = (byte)ReturnValueType;

				*(float*)(__InBuffer + 21) = InTimeToStartMontageAt;

				*(bool*)(__InBuffer + 25) = bStopAllMontages;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __Montage_PlayWithBlendIn, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float Montage_Play(UAnimMontage MontageToPlay, float InPlayRate = 1.000000f, EMontagePlayReturnType ReturnValueType = EMontagePlayReturnType.MontageLength, float InTimeToStartMontageAt = 0.000000f, bool bStopAllMontages = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = MontageToPlay?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InPlayRate;

				*(byte*)(__InBuffer + 12) = (byte)ReturnValueType;

				*(float*)(__InBuffer + 13) = InTimeToStartMontageAt;

				*(bool*)(__InBuffer + 17) = bStopAllMontages;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __Montage_Play, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual void Montage_Pause(UAnimMontage Montage = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Montage?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Montage_Pause, __InBuffer);
			}
		}

		public virtual void Montage_JumpToSectionsEnd(FName SectionName, UAnimMontage Montage = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SectionName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Montage?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Montage_JumpToSectionsEnd, __InBuffer);
			}
		}

		public virtual void Montage_JumpToSection(FName SectionName, UAnimMontage Montage = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SectionName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Montage?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Montage_JumpToSection, __InBuffer);
			}
		}

		public virtual bool Montage_IsPlaying(UAnimMontage Montage)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Montage?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __Montage_IsPlaying, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool Montage_IsActive(UAnimMontage Montage)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Montage?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __Montage_IsActive, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual float Montage_GetPosition(UAnimMontage Montage)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Montage?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __Montage_GetPosition, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float Montage_GetPlayRate(UAnimMontage Montage)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Montage?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __Montage_GetPlayRate, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual bool Montage_GetIsStopped(UAnimMontage Montage)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Montage?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __Montage_GetIsStopped, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual float Montage_GetEffectivePlayRate(UAnimMontage Montage)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Montage?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __Montage_GetEffectivePlayRate, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FName Montage_GetCurrentSection(UAnimMontage Montage = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Montage?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __Montage_GetCurrentSection, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual float Montage_GetBlendTime(UAnimMontage Montage)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Montage?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __Montage_GetBlendTime, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual void LockAIResources(bool bLockMovement, bool LockAILogic)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = bLockMovement;

				*(bool*)(__InBuffer + 1) = LockAILogic;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __LockAIResources, __InBuffer);
			}
		}

		public virtual void LinkAnimGraphByTag(FName InTag, TSubclassOf<UAnimInstance> InClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InTag?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InClass?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __LinkAnimGraphByTag, __InBuffer);
			}
		}

		public virtual void LinkAnimClassLayers(TSubclassOf<UAnimInstance> InClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InClass?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __LinkAnimClassLayers, __InBuffer);
			}
		}

		public virtual bool IsUsingMainInstanceMontageEvaluationData()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsUsingMainInstanceMontageEvaluationData, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsSyncGroupBetweenMarkers(FName InSyncGroupName, FName PreviousMarker, FName NextMarker, bool bRespectMarkerOrder = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = InSyncGroupName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PreviousMarker?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NextMarker?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bRespectMarkerOrder;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsSyncGroupBetweenMarkers, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsSlotActive(FName SlotNodeName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SlotNodeName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsSlotActive, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsPlayingSlotAnimation(UAnimSequenceBase Asset, FName SlotNodeName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Asset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SlotNodeName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsPlayingSlotAnimation, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsAnyMontagePlaying()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsAnyMontagePlaying, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool HasMarkerBeenHitThisFrame(FName SyncGroup, FName MarkerName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SyncGroup?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MarkerName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __HasMarkerBeenHitThisFrame, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetTimeToClosestMarker(FName SyncGroup, FName MarkerName, ref float OutMarkerTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = SyncGroup?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MarkerName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = OutMarkerTime;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetTimeToClosestMarker, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutMarkerTime = *(float*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FMarkerSyncAnimPosition GetSyncGroupPosition(FName InSyncGroupName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSyncGroupName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetSyncGroupPosition, __InBuffer, __ReturnBuffer);

				return *(FMarkerSyncAnimPosition*)__ReturnBuffer;
			}
		}

		public virtual float GetRelevantAnimTimeRemainingFraction(int MachineIndex, int StateIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = MachineIndex;

				*(int*)(__InBuffer + 4) = StateIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetRelevantAnimTimeRemainingFraction, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetRelevantAnimTimeRemaining(int MachineIndex, int StateIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = MachineIndex;

				*(int*)(__InBuffer + 4) = StateIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetRelevantAnimTimeRemaining, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetRelevantAnimTimeFraction(int MachineIndex, int StateIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = MachineIndex;

				*(int*)(__InBuffer + 4) = StateIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetRelevantAnimTimeFraction, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetRelevantAnimTime(int MachineIndex, int StateIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = MachineIndex;

				*(int*)(__InBuffer + 4) = StateIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetRelevantAnimTime, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetRelevantAnimLength(int MachineIndex, int StateIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = MachineIndex;

				*(int*)(__InBuffer + 4) = StateIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetRelevantAnimLength, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual bool GetReceiveNotifiesFromLinkedInstances()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetReceiveNotifiesFromLinkedInstances, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetPropagateNotifiesToLinkedInstances()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPropagateNotifiesToLinkedInstances, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual USkeletalMeshComponent GetOwningComponent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetOwningComponent, __ReturnBuffer);

				return *(USkeletalMeshComponent*)__ReturnBuffer;
			}
		}

		public virtual AActor GetOwningActor()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetOwningActor, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		public virtual void GetLinkedAnimLayerInstancesByGroup(FName InGroup, ref TArray<UAnimInstance> OutLinkedInstances)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InGroup?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutLinkedInstances?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetLinkedAnimLayerInstancesByGroup, __InBuffer, __OutBuffer);

				OutLinkedInstances = *(TArray<UAnimInstance>*)(__OutBuffer);

			}
		}

		public virtual UAnimInstance GetLinkedAnimLayerInstanceByGroupAndClass(FName InGroup, TSubclassOf<UAnimInstance> InClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InGroup?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetLinkedAnimLayerInstanceByGroupAndClass, __InBuffer, __ReturnBuffer);

				return *(UAnimInstance*)__ReturnBuffer;
			}
		}

		public virtual UAnimInstance GetLinkedAnimLayerInstanceByGroup(FName InGroup)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InGroup?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetLinkedAnimLayerInstanceByGroup, __InBuffer, __ReturnBuffer);

				return *(UAnimInstance*)__ReturnBuffer;
			}
		}

		public virtual UAnimInstance GetLinkedAnimLayerInstanceByClass(TSubclassOf<UAnimInstance> InClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetLinkedAnimLayerInstanceByClass, __InBuffer, __ReturnBuffer);

				return *(UAnimInstance*)__ReturnBuffer;
			}
		}

		public virtual void GetLinkedAnimGraphInstancesByTag(FName InTag, ref TArray<UAnimInstance> OutLinkedInstances)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InTag?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutLinkedInstances?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetLinkedAnimGraphInstancesByTag, __InBuffer, __OutBuffer);

				OutLinkedInstances = *(TArray<UAnimInstance>*)(__OutBuffer);

			}
		}

		public virtual UAnimInstance GetLinkedAnimGraphInstanceByTag(FName InTag)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InTag?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetLinkedAnimGraphInstanceByTag, __InBuffer, __ReturnBuffer);

				return *(UAnimInstance*)__ReturnBuffer;
			}
		}

		public virtual float GetInstanceTransitionTimeElapsedFraction(int MachineIndex, int TransitionIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = MachineIndex;

				*(int*)(__InBuffer + 4) = TransitionIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetInstanceTransitionTimeElapsedFraction, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetInstanceTransitionTimeElapsed(int MachineIndex, int TransitionIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = MachineIndex;

				*(int*)(__InBuffer + 4) = TransitionIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetInstanceTransitionTimeElapsed, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetInstanceTransitionCrossfadeDuration(int MachineIndex, int TransitionIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = MachineIndex;

				*(int*)(__InBuffer + 4) = TransitionIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetInstanceTransitionCrossfadeDuration, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetInstanceStateWeight(int MachineIndex, int StateIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = MachineIndex;

				*(int*)(__InBuffer + 4) = StateIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetInstanceStateWeight, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetInstanceMachineWeight(int MachineIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = MachineIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetInstanceMachineWeight, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetInstanceCurrentStateElapsedTime(int MachineIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = MachineIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetInstanceCurrentStateElapsedTime, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetInstanceAssetPlayerTimeFromEndFraction(int AssetPlayerIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = AssetPlayerIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetInstanceAssetPlayerTimeFromEndFraction, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetInstanceAssetPlayerTimeFromEnd(int AssetPlayerIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = AssetPlayerIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetInstanceAssetPlayerTimeFromEnd, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetInstanceAssetPlayerTimeFraction(int AssetPlayerIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = AssetPlayerIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetInstanceAssetPlayerTimeFraction, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetInstanceAssetPlayerTime(int AssetPlayerIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = AssetPlayerIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetInstanceAssetPlayerTime, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetInstanceAssetPlayerLength(int AssetPlayerIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = AssetPlayerIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetInstanceAssetPlayerLength, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetDeltaSeconds()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetDeltaSeconds, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="AnimInstance">
		/// The anim instance to find this curve value for.
		/// </param>
		/// <param name="CurveName">
		/// The name of the curve.
		/// </param>
		/// <param name="DefaultValue">
		/// Value to use when the curve is not found.
		/// </param>
		/// <param name="OutValue">
		/// The curve's value.
		/// </param>
		public virtual bool GetCurveValueWithDefault(FName CurveName, float DefaultValue, ref float OutValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = CurveName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = DefaultValue;

				*(float*)(__InBuffer + 12) = OutValue;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCurveValueWithDefault, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutValue = *(float*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual float GetCurveValue(FName CurveName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = CurveName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetCurveValue, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FName GetCurrentStateName(int MachineIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = MachineIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetCurrentStateName, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual UAnimMontage GetCurrentActiveMontage()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetCurrentActiveMontage, __ReturnBuffer);

				return *(UAnimMontage*)__ReturnBuffer;
			}
		}

		public virtual void GetAllCurveNames(ref TArray<FName> OutNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutNames?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetAllCurveNames, __InBuffer, __OutBuffer);

				OutNames = *(TArray<FName>*)(__OutBuffer);

			}
		}

		public virtual void GetActiveCurveNames(EAnimCurveType CurveType, ref TArray<FName> OutNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(byte*)(__InBuffer) = (byte)CurveType;

				*(nint*)(__InBuffer + 1) = OutNames?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetActiveCurveNames, __InBuffer, __OutBuffer);

				OutNames = *(TArray<FName>*)(__OutBuffer);

			}
		}

		public virtual void ClearTransitionEvents(FName EventName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = EventName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ClearTransitionEvents, __InBuffer);
			}
		}

		public virtual void ClearMorphTargets()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearMorphTargets);
			}
		}

		public virtual void ClearAllTransitionEvents()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearAllTransitionEvents);
			}
		}

		public virtual float CalculateDirection(FVector Velocity, FRotator BaseRotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Velocity?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BaseRotation?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CalculateDirection, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = DeltaTimeX;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __BlueprintUpdateAnimation, __InBuffer);
			}
		}

		public virtual void BlueprintThreadSafeUpdateAnimation(float DeltaTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = DeltaTime;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __BlueprintThreadSafeUpdateAnimation, __InBuffer);
			}
		}

		public virtual void BlueprintPostEvaluateAnimation()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __BlueprintPostEvaluateAnimation);
			}
		}

		public virtual void BlueprintLinkedAnimationLayersInitialized()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __BlueprintLinkedAnimationLayersInitialized);
			}
		}

		public virtual void BlueprintInitializeAnimation()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __BlueprintInitializeAnimation);
			}
		}

		public virtual void BlueprintBeginPlay()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __BlueprintBeginPlay);
			}
		}

		public virtual float Blueprint_GetSlotMontageLocalWeight(FName SlotNodeName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SlotNodeName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __Blueprint_GetSlotMontageLocalWeight, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __CurrentSkeleton = 0;

		private static uint __RootMotionMode = 0;

		private static uint __bUseMultiThreadedAnimationUpdate = 0;

		private static uint __bUsingCopyPoseFromMesh = 0;

		private static uint __bReceiveNotifiesFromLinkedInstances = 0;

		private static uint __bPropagateNotifiesToLinkedInstances = 0;

		private static uint __bUseMainInstanceMontageEvaluationData = 0;

		private static uint __bQueueMontageEvents = 0;

		private static uint __OnMontageBlendingOut = 0;

		private static uint __OnMontageStarted = 0;

		private static uint __OnMontageEnded = 0;

		private static uint __OnAllMontageInstancesEnded = 0;

		private static uint __PostCompileValidationClassName = 0;

		private static uint __NotifyQueue = 0;

		private static uint __ActiveAnimNotifyState = 0;

		private static uint __ActiveAnimNotifyEventReference = 0;

		private static uint __WasAnimNotifyTriggeredInStateMachine = 0;

		private static uint __WasAnimNotifyTriggeredInSourceState = 0;

		private static uint __WasAnimNotifyTriggeredInAnyState = 0;

		private static uint __WasAnimNotifyStateActiveInStateMachine = 0;

		private static uint __WasAnimNotifyStateActiveInSourceState = 0;

		private static uint __WasAnimNotifyStateActiveInAnyState = 0;

		private static uint __WasAnimNotifyNameTriggeredInStateMachine = 0;

		private static uint __WasAnimNotifyNameTriggeredInSourceState = 0;

		private static uint __WasAnimNotifyNameTriggeredInAnyState = 0;

		private static uint __UnlockAIResources = 0;

		private static uint __UnlinkAnimClassLayers = 0;

		private static uint __TryGetPawnOwner = 0;

		private static uint __StopSlotAnimation = 0;

		private static uint __SnapshotPose = 0;

		private static uint __SetUseMainInstanceMontageEvaluationData = 0;

		private static uint __SetRootMotionMode = 0;

		private static uint __SetReceiveNotifiesFromLinkedInstances = 0;

		private static uint __SetPropagateNotifiesToLinkedInstances = 0;

		private static uint __SetMorphTarget = 0;

		private static uint __SavePoseSnapshot = 0;

		private static uint __ResetDynamics = 0;

		private static uint __RequestTransitionEvent = 0;

		private static uint __RequestSlotGroupInertialization = 0;

		private static uint __RemovePoseSnapshot = 0;

		private static uint __QueryTransitionEvent = 0;

		private static uint __QueryAndMarkTransitionEvent = 0;

		private static uint __PlaySlotAnimationAsDynamicMontage_WithBlendSettings = 0;

		private static uint __PlaySlotAnimationAsDynamicMontage_WithBlendArgs = 0;

		private static uint __PlaySlotAnimationAsDynamicMontage = 0;

		private static uint __MontageSync_StopFollowing = 0;

		private static uint __MontageSync_Follow = 0;

		private static uint __Montage_StopWithBlendSettings = 0;

		private static uint __Montage_StopWithBlendOut = 0;

		private static uint __Montage_StopGroupByName = 0;

		private static uint __Montage_Stop = 0;

		private static uint __Montage_SetPosition = 0;

		private static uint __Montage_SetPlayRate = 0;

		private static uint __Montage_SetNextSection = 0;

		private static uint __Montage_Resume = 0;

		private static uint __Montage_PlayWithBlendSettings = 0;

		private static uint __Montage_PlayWithBlendIn = 0;

		private static uint __Montage_Play = 0;

		private static uint __Montage_Pause = 0;

		private static uint __Montage_JumpToSectionsEnd = 0;

		private static uint __Montage_JumpToSection = 0;

		private static uint __Montage_IsPlaying = 0;

		private static uint __Montage_IsActive = 0;

		private static uint __Montage_GetPosition = 0;

		private static uint __Montage_GetPlayRate = 0;

		private static uint __Montage_GetIsStopped = 0;

		private static uint __Montage_GetEffectivePlayRate = 0;

		private static uint __Montage_GetCurrentSection = 0;

		private static uint __Montage_GetBlendTime = 0;

		private static uint __LockAIResources = 0;

		private static uint __LinkAnimGraphByTag = 0;

		private static uint __LinkAnimClassLayers = 0;

		private static uint __IsUsingMainInstanceMontageEvaluationData = 0;

		private static uint __IsSyncGroupBetweenMarkers = 0;

		private static uint __IsSlotActive = 0;

		private static uint __IsPlayingSlotAnimation = 0;

		private static uint __IsAnyMontagePlaying = 0;

		private static uint __HasMarkerBeenHitThisFrame = 0;

		private static uint __GetTimeToClosestMarker = 0;

		private static uint __GetSyncGroupPosition = 0;

		private static uint __GetRelevantAnimTimeRemainingFraction = 0;

		private static uint __GetRelevantAnimTimeRemaining = 0;

		private static uint __GetRelevantAnimTimeFraction = 0;

		private static uint __GetRelevantAnimTime = 0;

		private static uint __GetRelevantAnimLength = 0;

		private static uint __GetReceiveNotifiesFromLinkedInstances = 0;

		private static uint __GetPropagateNotifiesToLinkedInstances = 0;

		private static uint __GetOwningComponent = 0;

		private static uint __GetOwningActor = 0;

		private static uint __GetLinkedAnimLayerInstancesByGroup = 0;

		private static uint __GetLinkedAnimLayerInstanceByGroupAndClass = 0;

		private static uint __GetLinkedAnimLayerInstanceByGroup = 0;

		private static uint __GetLinkedAnimLayerInstanceByClass = 0;

		private static uint __GetLinkedAnimGraphInstancesByTag = 0;

		private static uint __GetLinkedAnimGraphInstanceByTag = 0;

		private static uint __GetInstanceTransitionTimeElapsedFraction = 0;

		private static uint __GetInstanceTransitionTimeElapsed = 0;

		private static uint __GetInstanceTransitionCrossfadeDuration = 0;

		private static uint __GetInstanceStateWeight = 0;

		private static uint __GetInstanceMachineWeight = 0;

		private static uint __GetInstanceCurrentStateElapsedTime = 0;

		private static uint __GetInstanceAssetPlayerTimeFromEndFraction = 0;

		private static uint __GetInstanceAssetPlayerTimeFromEnd = 0;

		private static uint __GetInstanceAssetPlayerTimeFraction = 0;

		private static uint __GetInstanceAssetPlayerTime = 0;

		private static uint __GetInstanceAssetPlayerLength = 0;

		private static uint __GetDeltaSeconds = 0;

		private static uint __GetCurveValueWithDefault = 0;

		private static uint __GetCurveValue = 0;

		private static uint __GetCurrentStateName = 0;

		private static uint __GetCurrentActiveMontage = 0;

		private static uint __GetAllCurveNames = 0;

		private static uint __GetActiveCurveNames = 0;

		private static uint __ClearTransitionEvents = 0;

		private static uint __ClearMorphTargets = 0;

		private static uint __ClearAllTransitionEvents = 0;

		private static uint __CalculateDirection = 0;

		private static uint __BlueprintUpdateAnimation = 0;

		private static uint __BlueprintThreadSafeUpdateAnimation = 0;

		private static uint __BlueprintPostEvaluateAnimation = 0;

		private static uint __BlueprintLinkedAnimationLayersInitialized = 0;

		private static uint __BlueprintInitializeAnimation = 0;

		private static uint __BlueprintBeginPlay = 0;

		private static uint __Blueprint_GetSlotMontageLocalWeight = 0;
	}
}