using Script.CoreUObject;
using Script.Engine;
using Script.GameplayTasks;
using Script.Library;
using Script.NavigationSystem;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AIController")]
	public partial class AAIController : AController, IStaticClass, IAIPerceptionListenerInterface, IGameplayTaskOwnerInterface, IGenericTeamAgentInterface, IVisualLoggerDebugSnapshotInterface
	{
		public bool bStartAILogicOnPossess
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bStartAILogicOnPossess, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bStartAILogicOnPossess, __InBuffer);
				}
			}
		}

		public bool bStopAILogicOnUnposses
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bStopAILogicOnUnposses, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bStopAILogicOnUnposses, __InBuffer);
				}
			}
		}

		public bool bLOSflag
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bLOSflag, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bLOSflag, __InBuffer);
				}
			}
		}

		public bool bSkipExtraLOSChecks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSkipExtraLOSChecks, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSkipExtraLOSChecks, __InBuffer);
				}
			}
		}

		public bool bAllowStrafe
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowStrafe, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowStrafe, __InBuffer);
				}
			}
		}

		public bool bWantsPlayerState
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bWantsPlayerState, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bWantsPlayerState, __InBuffer);
				}
			}
		}

		public bool bSetControlRotationFromPawnOrientation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSetControlRotationFromPawnOrientation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSetControlRotationFromPawnOrientation, __InBuffer);
				}
			}
		}

		public UPathFollowingComponent PathFollowingComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PathFollowingComponent, __ReturnBuffer);

					return *(UPathFollowingComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PathFollowingComponent, __InBuffer);
				}
			}
		}

		public UBrainComponent BrainComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BrainComponent, __ReturnBuffer);

					return *(UBrainComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BrainComponent, __InBuffer);
				}
			}
		}

		public UAIPerceptionComponent PerceptionComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PerceptionComponent, __ReturnBuffer);

					return *(UAIPerceptionComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PerceptionComponent, __InBuffer);
				}
			}
		}

		public UBlackboardComponent Blackboard
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Blackboard, __ReturnBuffer);

					return *(UBlackboardComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Blackboard, __InBuffer);
				}
			}
		}

		public UGameplayTasksComponent CachedGameplayTasksComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CachedGameplayTasksComponent, __ReturnBuffer);

					return *(UGameplayTasksComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CachedGameplayTasksComponent, __InBuffer);
				}
			}
		}

		public TSubclassOf<UNavigationQueryFilter> DefaultNavigationFilterClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultNavigationFilterClass, __ReturnBuffer);

					return *(TSubclassOf<UNavigationQueryFilter>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultNavigationFilterClass, __InBuffer);
				}
			}
		}

		public FAIMoveCompletedSignature ReceiveMoveCompleted
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReceiveMoveCompleted, __ReturnBuffer);

					return *(FAIMoveCompletedSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReceiveMoveCompleted, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.AIController");
		}

		private static UClass StaticClassSingleton { get; set; }

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

		/// <param name="BlackboardAsset">
		/// The Blackboard asset to use.
		/// </param>
		/// <param name="BlackboardComponent">
		/// The Blackboard component that was used or created to work with the passed-in Blackboard Asset.
		/// </param>
		/// <returns>
		/// true if we successfully linked the blackboard asset to the blackboard component.
		/// </returns>
		public virtual bool UseBlackboard(UBlackboardData BlackboardAsset, ref UBlackboardComponent BlackboardComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = BlackboardAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BlackboardComponent?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __UseBlackboard, __InBuffer, __OutBuffer, __ReturnBuffer);

				BlackboardComponent = *(UBlackboardComponent*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void UnclaimTaskResource(TSubclassOf<UGameplayTaskResource> ResourceClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ResourceClass?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UnclaimTaskResource, __InBuffer);
			}
		}

		public virtual void SetPathFollowingComponent(UPathFollowingComponent NewPFComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewPFComponent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPathFollowingComponent, __InBuffer);
			}
		}

		public virtual void SetMoveBlockDetection(bool bEnable)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnable;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMoveBlockDetection, __InBuffer);
			}
		}

		public virtual bool RunBehaviorTree(UBehaviorTree BTAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BTAsset?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RunBehaviorTree, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void OnUsingBlackBoard(UBlackboardComponent BlackboardComp, UBlackboardData BlackboardAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = BlackboardComp?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BlackboardAsset?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __OnUsingBlackBoard, __InBuffer);
			}
		}

		public virtual void OnGameplayTaskResourcesClaimed(FGameplayResourceSet NewlyClaimed, FGameplayResourceSet FreshlyReleased)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NewlyClaimed?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FreshlyReleased?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnGameplayTaskResourcesClaimed, __InBuffer);
			}
		}

		/// <param name="AcceptanceRadius">
		/// - finish move if pawn gets close enough
		/// </param>
		/// <param name="bStopOnOverlap">
		/// - add pawn's radius to AcceptanceRadius
		/// </param>
		/// <param name="bUsePathfinding">
		/// - use navigation data to calculate path (otherwise it will go in straight line)
		/// </param>
		/// <param name="bProjectDestinationToNavigation">
		/// - project location on navigation data before using it
		/// </param>
		/// <param name="bCanStrafe">
		/// - set focus related flag: bAllowStrafe
		/// </param>
		/// <param name="FilterClass">
		/// - navigation filter for pathfinding adjustments. If none specified DefaultNavigationFilterClass will be used
		/// </param>
		/// <param name="bAllowPartialPath">
		/// - use incomplete path when goal can't be reached
		/// </param>
		/// <note>
		/// AcceptanceRadius has default value or -1 due to Header Parser not being able to recognize UPathFollowingComponent::DefaultAcceptanceRadius
		/// </note>
		public virtual EPathFollowingRequestResult MoveToLocation(FVector Dest, float AcceptanceRadius = -1.000000f, bool bStopOnOverlap = true, bool bUsePathfinding = true, bool bProjectDestinationToNavigation = false, bool bCanStrafe = true, TSubclassOf<UNavigationQueryFilter> FilterClass = null, bool bAllowPartialPath = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = Dest?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = AcceptanceRadius;

				*(bool*)(__InBuffer + 12) = bStopOnOverlap;

				*(bool*)(__InBuffer + 13) = bUsePathfinding;

				*(bool*)(__InBuffer + 14) = bProjectDestinationToNavigation;

				*(bool*)(__InBuffer + 15) = bCanStrafe;

				*(nint*)(__InBuffer + 16) = FilterClass?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bAllowPartialPath;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __MoveToLocation, __InBuffer, __ReturnBuffer);

				return *(EPathFollowingRequestResult*)__ReturnBuffer;
			}
		}

		/// <param name="AcceptanceRadius">
		/// - finish move if pawn gets close enough
		/// </param>
		/// <param name="bStopOnOverlap">
		/// - add pawn's radius to AcceptanceRadius
		/// </param>
		/// <param name="bUsePathfinding">
		/// - use navigation data to calculate path (otherwise it will go in straight line)
		/// </param>
		/// <param name="bCanStrafe">
		/// - set focus related flag: bAllowStrafe
		/// </param>
		/// <param name="FilterClass">
		/// - navigation filter for pathfinding adjustments. If none specified DefaultNavigationFilterClass will be used
		/// </param>
		/// <param name="bAllowPartialPath">
		/// - use incomplete path when goal can't be reached
		/// </param>
		/// <note>
		/// AcceptanceRadius has default value or -1 due to Header Parser not being able to recognize UPathFollowingComponent::DefaultAcceptanceRadius
		/// </note>
		public virtual EPathFollowingRequestResult MoveToActor(AActor Goal, float AcceptanceRadius = -1.000000f, bool bStopOnOverlap = true, bool bUsePathfinding = true, bool bCanStrafe = true, TSubclassOf<UNavigationQueryFilter> FilterClass = null, bool bAllowPartialPath = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Goal?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = AcceptanceRadius;

				*(bool*)(__InBuffer + 12) = bStopOnOverlap;

				*(bool*)(__InBuffer + 13) = bUsePathfinding;

				*(bool*)(__InBuffer + 14) = bCanStrafe;

				*(nint*)(__InBuffer + 15) = FilterClass?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 23) = bAllowPartialPath;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __MoveToActor, __InBuffer, __ReturnBuffer);

				return *(EPathFollowingRequestResult*)__ReturnBuffer;
			}
		}

		public virtual void K2_SetFocus(AActor NewFocus)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewFocus?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __K2_SetFocus, __InBuffer);
			}
		}

		public virtual void K2_SetFocalPoint(FVector FP)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = FP?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __K2_SetFocalPoint, __InBuffer);
			}
		}

		public virtual void K2_ClearFocus()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __K2_ClearFocus);
			}
		}

		public virtual bool HasPartialPath()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __HasPartialPath, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual UPathFollowingComponent GetPathFollowingComponent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPathFollowingComponent, __ReturnBuffer);

				return *(UPathFollowingComponent*)__ReturnBuffer;
			}
		}

		public virtual EPathFollowingStatus GetMoveStatus()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetMoveStatus, __ReturnBuffer);

				return *(EPathFollowingStatus*)__ReturnBuffer;
			}
		}

		public virtual FVector GetImmediateMoveDestination()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetImmediateMoveDestination, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual AActor GetFocusActor()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetFocusActor, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		public virtual FVector GetFocalPointOnActor(AActor Actor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetFocalPointOnActor, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetFocalPoint()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetFocalPoint, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual UDEPRECATED_PawnActionsComponent GetDeprecatedActionsComponent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDeprecatedActionsComponent, __ReturnBuffer);

				return *(UDEPRECATED_PawnActionsComponent*)__ReturnBuffer;
			}
		}

		public virtual UAIPerceptionComponent GetAIPerceptionComponent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAIPerceptionComponent, __ReturnBuffer);

				return *(UAIPerceptionComponent*)__ReturnBuffer;
			}
		}

		public virtual void ClaimTaskResource(TSubclassOf<UGameplayTaskResource> ResourceClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ResourceClass?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ClaimTaskResource, __InBuffer);
			}
		}

		private static uint __bStartAILogicOnPossess = 0;

		private static uint __bStopAILogicOnUnposses = 0;

		private static uint __bLOSflag = 0;

		private static uint __bSkipExtraLOSChecks = 0;

		private static uint __bAllowStrafe = 0;

		private static uint __bWantsPlayerState = 0;

		private static uint __bSetControlRotationFromPawnOrientation = 0;

		private static uint __PathFollowingComponent = 0;

		private static uint __BrainComponent = 0;

		private static uint __PerceptionComponent = 0;

		private static uint __Blackboard = 0;

		private static uint __CachedGameplayTasksComponent = 0;

		private static uint __DefaultNavigationFilterClass = 0;

		private static uint __ReceiveMoveCompleted = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __UseBlackboard = 0;

		private static uint __UnclaimTaskResource = 0;

		private static uint __SetPathFollowingComponent = 0;

		private static uint __SetMoveBlockDetection = 0;

		private static uint __RunBehaviorTree = 0;

		private static uint __OnUsingBlackBoard = 0;

		private static uint __OnGameplayTaskResourcesClaimed = 0;

		private static uint __MoveToLocation = 0;

		private static uint __MoveToActor = 0;

		private static uint __K2_SetFocus = 0;

		private static uint __K2_SetFocalPoint = 0;

		private static uint __K2_ClearFocus = 0;

		private static uint __HasPartialPath = 0;

		private static uint __GetPathFollowingComponent = 0;

		private static uint __GetMoveStatus = 0;

		private static uint __GetImmediateMoveDestination = 0;

		private static uint __GetFocusActor = 0;

		private static uint __GetFocalPointOnActor = 0;

		private static uint __GetFocalPoint = 0;

		private static uint __GetDeprecatedActionsComponent = 0;

		private static uint __GetAIPerceptionComponent = 0;

		private static uint __ClaimTaskResource = 0;
	}
}