using Script.CoreUObject;
using Script.UMG;
using Script.InputCore;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PlayerController")]
	public partial class APlayerController : AController, IStaticClass
	{
		public UPlayer Player
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Player, __ReturnBuffer);

					return *(UPlayer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Player, __InBuffer);
				}
			}
		}

		public APawn AcknowledgedPawn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AcknowledgedPawn, __ReturnBuffer);

					return *(APawn*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AcknowledgedPawn, __InBuffer);
				}
			}
		}

		public AHUD MyHUD
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MyHUD, __ReturnBuffer);

					return *(AHUD*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MyHUD, __InBuffer);
				}
			}
		}

		public APlayerCameraManager PlayerCameraManager
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerCameraManager, __ReturnBuffer);

					return *(APlayerCameraManager*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerCameraManager, __InBuffer);
				}
			}
		}

		public TSubclassOf<APlayerCameraManager> PlayerCameraManagerClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerCameraManagerClass, __ReturnBuffer);

					return *(TSubclassOf<APlayerCameraManager>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerCameraManagerClass, __InBuffer);
				}
			}
		}

		public bool bAutoManageActiveCameraTarget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoManageActiveCameraTarget, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoManageActiveCameraTarget, __InBuffer);
				}
			}
		}

		public FRotator TargetViewRotation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TargetViewRotation, __ReturnBuffer);

					return *(FRotator*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TargetViewRotation, __InBuffer);
				}
			}
		}

		public float SmoothTargetViewRotationSpeed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SmoothTargetViewRotationSpeed, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SmoothTargetViewRotationSpeed, __InBuffer);
				}
			}
		}

		public TArray<AActor> HiddenActors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HiddenActors, __ReturnBuffer);

					return *(TArray<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HiddenActors, __InBuffer);
				}
			}
		}

		public TArray<TWeakObjectPtr<UPrimitiveComponent>> HiddenPrimitiveComponents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HiddenPrimitiveComponents, __ReturnBuffer);

					return *(TArray<TWeakObjectPtr<UPrimitiveComponent>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HiddenPrimitiveComponents, __InBuffer);
				}
			}
		}

		public float LastSpectatorStateSynchTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastSpectatorStateSynchTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastSpectatorStateSynchTime, __InBuffer);
				}
			}
		}

		public FVector LastSpectatorSyncLocation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastSpectatorSyncLocation, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastSpectatorSyncLocation, __InBuffer);
				}
			}
		}

		public FRotator LastSpectatorSyncRotation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastSpectatorSyncRotation, __ReturnBuffer);

					return *(FRotator*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastSpectatorSyncRotation, __InBuffer);
				}
			}
		}

		public int ClientCap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ClientCap, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ClientCap, __InBuffer);
				}
			}
		}

		public UCheatManager CheatManager
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CheatManager, __ReturnBuffer);

					return *(UCheatManager*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CheatManager, __InBuffer);
				}
			}
		}

		public TSubclassOf<UCheatManager> CheatClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CheatClass, __ReturnBuffer);

					return *(TSubclassOf<UCheatManager>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CheatClass, __InBuffer);
				}
			}
		}

		public UPlayerInput PlayerInput
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerInput, __ReturnBuffer);

					return *(UPlayerInput*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerInput, __InBuffer);
				}
			}
		}

		public TArray<FActiveForceFeedbackEffect> ActiveForceFeedbackEffects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveForceFeedbackEffects, __ReturnBuffer);

					return *(TArray<FActiveForceFeedbackEffect>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveForceFeedbackEffects, __InBuffer);
				}
			}
		}

		public UAsyncPhysicsInputComponent AsyncPhysicsDataComponent_DEPRECARED
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AsyncPhysicsDataComponent_DEPRECARED, __ReturnBuffer);

					return *(UAsyncPhysicsInputComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AsyncPhysicsDataComponent_DEPRECARED, __InBuffer);
				}
			}
		}

		public bool bPlayerIsWaiting
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPlayerIsWaiting, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPlayerIsWaiting, __InBuffer);
				}
			}
		}

		public byte NetPlayerIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NetPlayerIndex, __ReturnBuffer);

					return *(byte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NetPlayerIndex, __InBuffer);
				}
			}
		}

		public UNetConnection PendingSwapConnection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PendingSwapConnection, __ReturnBuffer);

					return *(UNetConnection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PendingSwapConnection, __InBuffer);
				}
			}
		}

		public UNetConnection NetConnection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NetConnection, __ReturnBuffer);

					return *(UNetConnection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NetConnection, __InBuffer);
				}
			}
		}

		public bool bShowMouseCursor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowMouseCursor, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowMouseCursor, __InBuffer);
				}
			}
		}

		public bool bEnableClickEvents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableClickEvents, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableClickEvents, __InBuffer);
				}
			}
		}

		public bool bEnableTouchEvents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableTouchEvents, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableTouchEvents, __InBuffer);
				}
			}
		}

		public bool bEnableMouseOverEvents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableMouseOverEvents, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableMouseOverEvents, __InBuffer);
				}
			}
		}

		public bool bEnableTouchOverEvents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableTouchOverEvents, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableTouchOverEvents, __InBuffer);
				}
			}
		}

		public bool bForceFeedbackEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bForceFeedbackEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bForceFeedbackEnabled, __InBuffer);
				}
			}
		}

		public bool bEnableMotionControls
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableMotionControls, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableMotionControls, __InBuffer);
				}
			}
		}

		public bool bEnableStreamingSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableStreamingSource, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableStreamingSource, __InBuffer);
				}
			}
		}

		public bool bStreamingSourceShouldActivate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bStreamingSourceShouldActivate, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bStreamingSourceShouldActivate, __InBuffer);
				}
			}
		}

		public bool bStreamingSourceShouldBlockOnSlowStreaming
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bStreamingSourceShouldBlockOnSlowStreaming, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bStreamingSourceShouldBlockOnSlowStreaming, __InBuffer);
				}
			}
		}

		public EStreamingSourcePriority StreamingSourcePriority
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StreamingSourcePriority, __ReturnBuffer);

					return *(EStreamingSourcePriority*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StreamingSourcePriority, __InBuffer);
				}
			}
		}

		public FColor StreamingSourceDebugColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StreamingSourceDebugColor, __ReturnBuffer);

					return *(FColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StreamingSourceDebugColor, __InBuffer);
				}
			}
		}

		public TArray<FStreamingSourceShape> StreamingSourceShapes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StreamingSourceShapes, __ReturnBuffer);

					return *(TArray<FStreamingSourceShape>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StreamingSourceShapes, __InBuffer);
				}
			}
		}

		public float ForceFeedbackScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ForceFeedbackScale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ForceFeedbackScale, __InBuffer);
				}
			}
		}

		public TArray<FKey> ClickEventKeys
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ClickEventKeys, __ReturnBuffer);

					return *(TArray<FKey>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ClickEventKeys, __InBuffer);
				}
			}
		}

		public EMouseCursor DefaultMouseCursor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultMouseCursor, __ReturnBuffer);

					return *(EMouseCursor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultMouseCursor, __InBuffer);
				}
			}
		}

		public EMouseCursor CurrentMouseCursor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentMouseCursor, __ReturnBuffer);

					return *(EMouseCursor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentMouseCursor, __InBuffer);
				}
			}
		}

		public ECollisionChannel DefaultClickTraceChannel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultClickTraceChannel, __ReturnBuffer);

					return *(ECollisionChannel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultClickTraceChannel, __InBuffer);
				}
			}
		}

		public ECollisionChannel CurrentClickTraceChannel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentClickTraceChannel, __ReturnBuffer);

					return *(ECollisionChannel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentClickTraceChannel, __InBuffer);
				}
			}
		}

		public float HitResultTraceDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HitResultTraceDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HitResultTraceDistance, __InBuffer);
				}
			}
		}

		public ushort SeamlessTravelCount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SeamlessTravelCount, __ReturnBuffer);

					return *(ushort*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(ushort*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SeamlessTravelCount, __InBuffer);
				}
			}
		}

		public ushort LastCompletedSeamlessTravelCount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastCompletedSeamlessTravelCount, __ReturnBuffer);

					return *(ushort*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(ushort*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastCompletedSeamlessTravelCount, __InBuffer);
				}
			}
		}

		public UInputComponent InactiveStateInputComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InactiveStateInputComponent, __ReturnBuffer);

					return *(UInputComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InactiveStateInputComponent, __InBuffer);
				}
			}
		}

		public bool bShouldPerformFullTickWhenPaused
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldPerformFullTickWhenPaused, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldPerformFullTickWhenPaused, __InBuffer);
				}
			}
		}

		public UTouchInterface CurrentTouchInterface
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentTouchInterface, __ReturnBuffer);

					return *(UTouchInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentTouchInterface, __InBuffer);
				}
			}
		}

		public TSubclassOf<UPlayerInput> OverridePlayerInputClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OverridePlayerInputClass, __ReturnBuffer);

					return *(TSubclassOf<UPlayerInput>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OverridePlayerInputClass, __InBuffer);
				}
			}
		}

		public ASpectatorPawn SpectatorPawn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SpectatorPawn, __ReturnBuffer);

					return *(ASpectatorPawn*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SpectatorPawn, __InBuffer);
				}
			}
		}

		public bool bIsLocalPlayerController
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsLocalPlayerController, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsLocalPlayerController, __InBuffer);
				}
			}
		}

		public FVector SpawnLocation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SpawnLocation, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SpawnLocation, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PlayerController");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool WasInputKeyJustReleased(FKey Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __WasInputKeyJustReleased, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool WasInputKeyJustPressed(FKey Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __WasInputKeyJustPressed, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="bSpeaking">
		/// enable or disable voice chat
		/// </param>
		public virtual void ToggleSpeaking(bool bInSpeaking)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInSpeaking;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ToggleSpeaking, __InBuffer);
			}
		}

		public virtual void TestServerLevelVisibilityChange(FName PackageName, FName FileName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PackageName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FileName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __TestServerLevelVisibilityChange, __InBuffer);
			}
		}

		public virtual void SwitchLevel(FString URL)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = URL?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SwitchLevel, __InBuffer);
			}
		}

		/// <returns>
		/// true if it should.
		/// </returns>
		public virtual bool StreamingSourceShouldBlockOnSlowStreaming()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __StreamingSourceShouldBlockOnSlowStreaming, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if it should.
		/// </returns>
		public virtual bool StreamingSourceShouldActivate()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __StreamingSourceShouldActivate, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="HapticEffect">
		/// The haptic effect to stop
		/// </param>
		/// <param name="Hand">
		/// Which hand to stop the effect for
		/// </param>
		public virtual void StopHapticEffect(EControllerHand Hand)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)Hand;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StopHapticEffect, __InBuffer);
			}
		}

		public virtual void StartFire(byte FireModeNum)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = FireModeNum;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StartFire, __InBuffer);
			}
		}

		public virtual void SetVirtualJoystickVisibility(bool bVisible)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bVisible;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVirtualJoystickVisibility, __InBuffer);
			}
		}

		/// <param name="NewViewTarget">
		/// - new actor to set as view target
		/// </param>
		/// <param name="BlendTime">
		/// - time taken to blend
		/// </param>
		/// <param name="BlendFunc">
		/// - Cubic, Linear etc functions for blending
		/// </param>
		/// <param name="BlendExp">
		/// -  Exponent, used by certain blend functions to control the shape of the curve. 
		/// </param>
		/// <param name="bLockOutgoing">
		/// - If true, lock outgoing viewtarget to last frame's camera position for the remainder of the blend.
		/// </param>
		public virtual void SetViewTargetWithBlend(AActor NewViewTarget, float BlendTime = 0.000000f, EViewTargetBlendFunction BlendFunc = EViewTargetBlendFunction.VTBlend_Linear, float BlendExp = 0.000000f, bool bLockOutgoing = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = NewViewTarget?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = BlendTime;

				*(byte*)(__InBuffer + 12) = (byte)BlendFunc;

				*(float*)(__InBuffer + 13) = BlendExp;

				*(bool*)(__InBuffer + 17) = bLockOutgoing;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetViewTargetWithBlend, __InBuffer);
			}
		}

		public virtual void SetName(FString S)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = S?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetName, __InBuffer);
			}
		}

		public virtual void SetMouseLocation(int X, int Y)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = X;

				*(int*)(__InBuffer + 4) = Y;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMouseLocation, __InBuffer);
			}
		}

		/// <param name="Cursor">
		/// - the cursor to set the widget for
		/// </param>
		/// <param name="CursorWidget">
		/// - the widget to set the cursor to
		/// </param>
		public virtual void SetMouseCursorWidget(EMouseCursor Cursor, UUserWidget CursorWidget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(byte*)(__InBuffer) = (byte)Cursor;

				*(nint*)(__InBuffer + 1) = CursorWidget?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMouseCursorWidget, __InBuffer);
			}
		}

		public virtual void SetMotionControlsEnabled(bool bEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMotionControlsEnabled, __InBuffer);
			}
		}

		/// <param name="Frequency">
		/// The normalized frequency [0.0, 1.0] to play through the haptics system
		/// </param>
		/// <param name="Amplitude">
		/// The normalized amplitude [0.0, 1.0] to set the haptic feedback to
		/// </param>
		/// <param name="Hand">
		/// Which hand to play the effect on
		/// </param>
		public virtual void SetHapticsByValue(float Frequency, float Amplitude, EControllerHand Hand)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(float*)(__InBuffer) = Frequency;

				*(float*)(__InBuffer + 4) = Amplitude;

				*(byte*)(__InBuffer + 8) = (byte)Hand;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetHapticsByValue, __InBuffer);
			}
		}

		/// <param name="bNewDisabled">
		/// If TRUE, the haptics will stop and prevented from being enabled again until set to FALSE
		/// </param>
		public virtual void SetDisableHaptics(bool bNewDisabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewDisabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDisableHaptics, __InBuffer);
			}
		}

		public virtual void SetDeprecatedInputYawScale(float NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDeprecatedInputYawScale, __InBuffer);
			}
		}

		public virtual void SetDeprecatedInputRollScale(float NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDeprecatedInputRollScale, __InBuffer);
			}
		}

		public virtual void SetDeprecatedInputPitchScale(float NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDeprecatedInputPitchScale, __InBuffer);
			}
		}

		/// <param name="Color">
		/// The color for the light to be
		/// </param>
		public virtual void SetControllerLightColor(FColor Color)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Color?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControllerLightColor, __InBuffer);
			}
		}

		/// <param name="bInCinematicMode">
		/// specify true if the player is entering cinematic mode; false if the player is leaving cinematic mode.
		/// </param>
		/// <param name="bHidePlayer">
		/// specify true to hide the player's pawn (only relevant if bInCinematicMode is true)
		/// </param>
		/// <param name="bAffectsHUD">
		/// specify true if we should show/hide the HUD to match the value of bCinematicMode
		/// </param>
		/// <param name="bAffectsMovement">
		/// specify true to disable movement in cinematic mode, enable it when leaving
		/// </param>
		/// <param name="bAffectsTurning">
		/// specify true to disable turning in cinematic mode or enable it when leaving
		/// </param>
		public virtual void SetCinematicMode(bool bInCinematicMode, bool bHidePlayer, bool bAffectsHUD, bool bAffectsMovement, bool bAffectsTurning)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(bool*)(__InBuffer) = bInCinematicMode;

				*(bool*)(__InBuffer + 1) = bHidePlayer;

				*(bool*)(__InBuffer + 2) = bAffectsHUD;

				*(bool*)(__InBuffer + 3) = bAffectsMovement;

				*(bool*)(__InBuffer + 4) = bAffectsTurning;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCinematicMode, __InBuffer);
			}
		}

		/// <param name="AttachToComponent">
		/// Optional component to attach the audio listener to
		/// </param>
		/// <param name="Location">
		/// Depending on whether Component is attached this is either an offset from its location or an absolute position
		/// </param>
		/// <param name="Rotation">
		/// Depending on whether Component is attached this is either an offset from its rotation or an absolute rotation
		/// </param>
		public virtual void SetAudioListenerOverride(USceneComponent AttachToComponent, FVector Location, FRotator Rotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = AttachToComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAudioListenerOverride, __InBuffer);
			}
		}

		public virtual void SetAudioListenerAttenuationOverride(USceneComponent AttachToComponent, FVector AttenuationLocationOVerride)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AttachToComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttenuationLocationOVerride?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAudioListenerAttenuationOverride, __InBuffer);
			}
		}

		public virtual void ServerViewSelf(FViewTargetTransitionParams TransitionParams)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TransitionParams?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerViewSelf, __InBuffer);
			}
		}

		public virtual void ServerViewPrevPlayer()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __ServerViewPrevPlayer);
			}
		}

		public virtual void ServerViewNextPlayer()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __ServerViewNextPlayer);
			}
		}

		public virtual void ServerVerifyViewTarget()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __ServerVerifyViewTarget);
			}
		}

		/// <param name="LevelVisibilities">
		/// Visibility state for each level whose state has changed
		/// </param>
		public virtual void ServerUpdateMultipleLevelsVisibility(TArray<FUpdateLevelVisibilityLevelInfo> LevelVisibilities)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LevelVisibilities?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerUpdateMultipleLevelsVisibility, __InBuffer);
			}
		}

		/// <param name="LevelVisibility">
		/// Visibility state for the level whose state changed.
		/// </param>
		public virtual void ServerUpdateLevelVisibility(FUpdateLevelVisibilityLevelInfo LevelVisibility)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LevelVisibility?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerUpdateLevelVisibility, __InBuffer);
			}
		}

		/// <TODO>
		/// - combine pitch/yaw into one int, maybe also send location compressed
		/// </TODO>
		public virtual void ServerUpdateCamera(FVector_NetQuantize CamLoc, int CamPitchAndYaw)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = CamLoc?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = CamPitchAndYaw;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerUpdateCamera, __InBuffer);
			}
		}

		/// <param name="PlayerId">
		/// player id to unmute
		/// </param>
		public virtual void ServerUnmutePlayer(FUniqueNetIdRepl PlayerId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlayerId?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerUnmutePlayer, __InBuffer);
			}
		}

		/// <param name="PlayerId">
		/// player id to unblock
		/// </param>
		public virtual void ServerUnblockPlayer(FUniqueNetIdRepl PlayerId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlayerId?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerUnblockPlayer, __InBuffer);
			}
		}

		public virtual void ServerToggleAILogging()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __ServerToggleAILogging);
			}
		}

		public virtual void ServerShortTimeout()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __ServerShortTimeout);
			}
		}

		public virtual void ServerSetSpectatorWaiting(bool bWaiting)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bWaiting;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerSetSpectatorWaiting, __InBuffer);
			}
		}

		public virtual void ServerSetSpectatorLocation(FVector NewLoc, FRotator NewRot)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NewLoc?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewRot?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerSetSpectatorLocation, __InBuffer);
			}
		}

		public virtual void ServerSendLatestAsyncPhysicsTimestamp(FAsyncPhysicsTimestamp Timestamp)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Timestamp?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerSendLatestAsyncPhysicsTimestamp, __InBuffer);
			}
		}

		public virtual void ServerRestartPlayer()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __ServerRestartPlayer);
			}
		}

		public virtual void ServerRecvClientInputFrame(int RecvClientInputFrame, TArray<byte> Data)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = RecvClientInputFrame;

				*(nint*)(__InBuffer + 4) = Data?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerRecvClientInputFrame, __InBuffer);
			}
		}

		public virtual void ServerPause()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __ServerPause);
			}
		}

		/// <param name="WorldPackageName">
		/// the name of the world package that was loaded
		/// </param>
		public virtual void ServerNotifyLoadedWorld(FName WorldPackageName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldPackageName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerNotifyLoadedWorld, __InBuffer);
			}
		}

		/// <param name="PlayerId">
		/// player id to mute
		/// </param>
		public virtual void ServerMutePlayer(FUniqueNetIdRepl PlayerId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlayerId?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerMutePlayer, __InBuffer);
			}
		}

		public virtual void ServerExecRPC(FString Msg)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Msg?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerExecRPC, __InBuffer);
			}
		}

		public virtual void ServerExec(FString Msg)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Msg?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ServerExec, __InBuffer);
			}
		}

		public virtual void ServerCheckClientPossessionReliable()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __ServerCheckClientPossessionReliable);
			}
		}

		public virtual void ServerCheckClientPossession()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __ServerCheckClientPossession);
			}
		}

		public virtual void ServerChangeName(FString S)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = S?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerChangeName, __InBuffer);
			}
		}

		public virtual void ServerCamera(FName NewMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewMode?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerCamera, __InBuffer);
			}
		}

		/// <param name="PlayerId">
		/// player id to block
		/// </param>
		public virtual void ServerBlockPlayer(FUniqueNetIdRepl PlayerId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlayerId?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerBlockPlayer, __InBuffer);
			}
		}

		public virtual void ServerAcknowledgePossession(APawn P)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = P?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerAcknowledgePossession, __InBuffer);
			}
		}

		public virtual void SendToConsole(FString Command)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Command?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SendToConsole, __InBuffer);
			}
		}

		public virtual void RestartLevel()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RestartLevel);
			}
		}

		public virtual void ResetControllerLightColor()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetControllerLightColor);
			}
		}

		/// <returns>
		/// true if the world coordinate was successfully projected to the screen.
		/// </returns>
		public virtual bool ProjectWorldLocationToScreen(FVector WorldLocation, ref FVector2D ScreenLocation, bool bPlayerViewportRelative)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = WorldLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ScreenLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bPlayerViewportRelative;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __ProjectWorldLocationToScreen, __InBuffer, __OutBuffer, __ReturnBuffer);

				ScreenLocation = *(FVector2D*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="HapticEffect">
		/// The haptic effect to play
		/// </param>
		/// <param name="Hand">
		/// Which hand to play the effect on
		/// </param>
		/// <param name="Scale">
		/// Scale between 0.0 and 1.0 on the intensity of playback
		/// </param>
		public virtual void PlayHapticEffect(UHapticFeedbackEffect_Base HapticEffect, EControllerHand Hand, float Scale = 1.000000f, bool bLoop = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[14];

				*(nint*)(__InBuffer) = HapticEffect?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Hand;

				*(float*)(__InBuffer + 9) = Scale;

				*(bool*)(__InBuffer + 13) = bLoop;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __PlayHapticEffect, __InBuffer);
			}
		}

		/// <param name="Intensity">
		/// How strong the feedback should be.  Valid values are between 0.0 and 1.0
		/// </param>
		/// <param name="Duration">
		/// How long the feedback should play for.  If the value is negative it will play until stopped
		/// </param>
		/// <param name="bAffectsLeftLarge">
		/// Whether the intensity should be applied to the large left servo
		/// </param>
		/// <param name="bAffectsLeftSmall">
		/// Whether the intensity should be applied to the small left servo
		/// </param>
		/// <param name="bAffectsRightLarge">
		/// Whether the intensity should be applied to the large right servo
		/// </param>
		/// <param name="bAffectsRightSmall">
		/// Whether the intensity should be applied to the small right servo
		/// </param>
		public virtual void PlayDynamicForceFeedback(float Intensity, float Duration, bool bAffectsLeftLarge, bool bAffectsLeftSmall, bool bAffectsRightLarge, bool bAffectsRightSmall, EDynamicForceFeedbackAction Action, FLatentActionInfo LatentInfo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(float*)(__InBuffer) = Intensity;

				*(float*)(__InBuffer + 4) = Duration;

				*(bool*)(__InBuffer + 8) = bAffectsLeftLarge;

				*(bool*)(__InBuffer + 9) = bAffectsLeftSmall;

				*(bool*)(__InBuffer + 10) = bAffectsRightLarge;

				*(bool*)(__InBuffer + 11) = bAffectsRightSmall;

				*(byte*)(__InBuffer + 12) = (byte)Action;

				*(nint*)(__InBuffer + 13) = LatentInfo?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __PlayDynamicForceFeedback, __InBuffer);
			}
		}

		public virtual void Pause()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Pause);
			}
		}

		public virtual void OnServerStartedVisualLogger(bool bIsLogging)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIsLogging;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __OnServerStartedVisualLogger, __InBuffer);
			}
		}

		public virtual void OnRep_AsyncPhysicsDataComponent()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_AsyncPhysicsDataComponent);
			}
		}

		public virtual void LocalTravel(FString URL)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = URL?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __LocalTravel, __InBuffer);
			}
		}

		/// <param name="ForceFeedbackEffect">
		/// The force feedback pattern to play
		/// </param>
		/// <param name="bLooping">
		/// Whether the pattern should be played repeatedly or be a single one shot
		/// </param>
		/// <param name="bIgnoreTimeDilation">
		/// Whether the pattern should ignore time dilation
		/// </param>
		/// <param name="bPlayWhilePaused">
		/// Whether the pattern should continue to play while the game is paused
		/// </param>
		/// <param name="Tag">
		/// A tag that allows stopping of an effect.  If another effect with this Tag is playing, it will be stopped and replaced
		/// </param>
		public virtual void K2_ClientPlayForceFeedback(UForceFeedbackEffect ForceFeedbackEffect, FName Tag, bool bLooping, bool bIgnoreTimeDilation, bool bPlayWhilePaused)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = ForceFeedbackEffect?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Tag?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bLooping;

				*(bool*)(__InBuffer + 17) = bIgnoreTimeDilation;

				*(bool*)(__InBuffer + 18) = bPlayWhilePaused;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __K2_ClientPlayForceFeedback, __InBuffer);
			}
		}

		/// <returns>
		/// true if it should.
		/// </returns>
		public virtual bool IsStreamingSourceEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsStreamingSourceEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsInputKeyDown(FKey Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsInputKeyDown, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void GetViewportSize(ref int SizeX, ref int SizeY)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = SizeX;

				*(int*)(__InBuffer + 4) = SizeY;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetViewportSize, __InBuffer, __OutBuffer);

				SizeX = *(int*)(__OutBuffer);

				SizeY = *(int*)(__OutBuffer + 4);

			}
		}

		/// <returns>
		/// the streaming source priority.
		/// </returns>
		public virtual void GetStreamingSourceShapes(ref TArray<FStreamingSourceShape> OutShapes)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutShapes?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetStreamingSourceShapes, __InBuffer, __OutBuffer);

				OutShapes = *(TArray<FStreamingSourceShape>*)(__OutBuffer);

			}
		}

		/// <returns>
		/// the streaming source priority.
		/// </returns>
		public virtual EStreamingSourcePriority GetStreamingSourcePriority()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetStreamingSourcePriority, __ReturnBuffer);

				return *(EStreamingSourcePriority*)__ReturnBuffer;
			}
		}

		public virtual void GetStreamingSourceLocationAndRotation(ref FVector OutLocation, ref FRotator OutRotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OutLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutRotation?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetStreamingSourceLocationAndRotation, __InBuffer, __OutBuffer);

				OutLocation = *(FVector*)(__OutBuffer);

				OutRotation = *(FRotator*)(__OutBuffer + 8);

			}
		}

		public virtual ASpectatorPawn GetSpectatorPawn()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSpectatorPawn, __ReturnBuffer);

				return *(ASpectatorPawn*)__ReturnBuffer;
			}
		}

		public virtual FPlatformUserId GetPlatformUserId()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPlatformUserId, __ReturnBuffer);

				return *(FPlatformUserId*)__ReturnBuffer;
			}
		}

		public virtual TSubclassOf<UPlayerInput> GetOverridePlayerInputClass()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetOverridePlayerInputClass, __ReturnBuffer);

				return *(TSubclassOf<UPlayerInput>*)__ReturnBuffer;
			}
		}

		public virtual bool GetMousePosition(ref float LocationX, ref float LocationY)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = LocationX;

				*(float*)(__InBuffer + 4) = LocationY;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetMousePosition, __InBuffer, __OutBuffer, __ReturnBuffer);

				LocationX = *(float*)(__OutBuffer);

				LocationY = *(float*)(__OutBuffer + 4);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FVector GetInputVectorKeyState(FKey Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetInputVectorKeyState, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual void GetInputTouchState(ETouchIndex FingerIndex, ref float LocationX, ref float LocationY, ref bool bIsCurrentlyPressed)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(byte*)(__InBuffer) = (byte)FingerIndex;

				*(float*)(__InBuffer + 1) = LocationX;

				*(float*)(__InBuffer + 5) = LocationY;

				*(bool*)(__InBuffer + 9) = bIsCurrentlyPressed;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetInputTouchState, __InBuffer, __OutBuffer);

				LocationX = *(float*)(__OutBuffer);

				LocationY = *(float*)(__OutBuffer + 4);

				bIsCurrentlyPressed = *(bool*)(__OutBuffer + 8);

			}
		}

		public virtual void GetInputMouseDelta(ref float DeltaX, ref float DeltaY)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = DeltaX;

				*(float*)(__InBuffer + 4) = DeltaY;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetInputMouseDelta, __InBuffer, __OutBuffer);

				DeltaX = *(float*)(__OutBuffer);

				DeltaY = *(float*)(__OutBuffer + 4);

			}
		}

		public virtual void GetInputMotionState(ref FVector Tilt, ref FVector RotationRate, ref FVector Gravity, ref FVector Acceleration)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Tilt?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = RotationRate?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Gravity?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Acceleration?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[32];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetInputMotionState, __InBuffer, __OutBuffer);

				Tilt = *(FVector*)(__OutBuffer);

				RotationRate = *(FVector*)(__OutBuffer + 8);

				Gravity = *(FVector*)(__OutBuffer + 16);

				Acceleration = *(FVector*)(__OutBuffer + 24);

			}
		}

		public virtual float GetInputKeyTimeDown(FKey Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetInputKeyTimeDown, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual void GetInputAnalogStickState(EControllerAnalogStick WhichStick, ref float StickX, ref float StickY)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(byte*)(__InBuffer) = (byte)WhichStick;

				*(float*)(__InBuffer + 1) = StickX;

				*(float*)(__InBuffer + 5) = StickY;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetInputAnalogStickState, __InBuffer, __OutBuffer);

				StickX = *(float*)(__OutBuffer);

				StickY = *(float*)(__OutBuffer + 4);

			}
		}

		public virtual float GetInputAnalogKeyState(FKey Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetInputAnalogKeyState, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual AHUD GetHUD()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetHUD, __ReturnBuffer);

				return *(AHUD*)__ReturnBuffer;
			}
		}

		public virtual bool GetHitResultUnderFingerForObjects(ETouchIndex FingerIndex, TArray<EObjectTypeQuery> ObjectTypes, bool bTraceComplex, ref FHitResult HitResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(byte*)(__InBuffer) = (byte)FingerIndex;

				*(nint*)(__InBuffer + 1) = ObjectTypes?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 9) = bTraceComplex;

				*(nint*)(__InBuffer + 10) = HitResult?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetHitResultUnderFingerForObjects, __InBuffer, __OutBuffer, __ReturnBuffer);

				HitResult = *(FHitResult*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetHitResultUnderFingerByChannel(ETouchIndex FingerIndex, ETraceTypeQuery TraceChannel, bool bTraceComplex, ref FHitResult HitResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[11];

				*(byte*)(__InBuffer) = (byte)FingerIndex;

				*(byte*)(__InBuffer + 1) = (byte)TraceChannel;

				*(bool*)(__InBuffer + 2) = bTraceComplex;

				*(nint*)(__InBuffer + 3) = HitResult?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetHitResultUnderFingerByChannel, __InBuffer, __OutBuffer, __ReturnBuffer);

				HitResult = *(FHitResult*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetHitResultUnderFinger(ETouchIndex FingerIndex, ECollisionChannel TraceChannel, bool bTraceComplex, ref FHitResult HitResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[11];

				*(byte*)(__InBuffer) = (byte)FingerIndex;

				*(byte*)(__InBuffer + 1) = (byte)TraceChannel;

				*(bool*)(__InBuffer + 2) = bTraceComplex;

				*(nint*)(__InBuffer + 3) = HitResult?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetHitResultUnderFinger, __InBuffer, __OutBuffer, __ReturnBuffer);

				HitResult = *(FHitResult*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetHitResultUnderCursorForObjects(TArray<EObjectTypeQuery> ObjectTypes, bool bTraceComplex, ref FHitResult HitResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = ObjectTypes?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bTraceComplex;

				*(nint*)(__InBuffer + 9) = HitResult?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetHitResultUnderCursorForObjects, __InBuffer, __OutBuffer, __ReturnBuffer);

				HitResult = *(FHitResult*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetHitResultUnderCursorByChannel(ETraceTypeQuery TraceChannel, bool bTraceComplex, ref FHitResult HitResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(byte*)(__InBuffer) = (byte)TraceChannel;

				*(bool*)(__InBuffer + 1) = bTraceComplex;

				*(nint*)(__InBuffer + 2) = HitResult?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetHitResultUnderCursorByChannel, __InBuffer, __OutBuffer, __ReturnBuffer);

				HitResult = *(FHitResult*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetHitResultUnderCursor(ECollisionChannel TraceChannel, bool bTraceComplex, ref FHitResult HitResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(byte*)(__InBuffer) = (byte)TraceChannel;

				*(bool*)(__InBuffer + 1) = bTraceComplex;

				*(nint*)(__InBuffer + 2) = HitResult?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetHitResultUnderCursor, __InBuffer, __OutBuffer, __ReturnBuffer);

				HitResult = *(FHitResult*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FVector GetFocalLocation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetFocalLocation, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual float GetDeprecatedInputYawScale()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetDeprecatedInputYawScale, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetDeprecatedInputRollScale()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetDeprecatedInputRollScale, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetDeprecatedInputPitchScale()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetDeprecatedInputPitchScale, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual UAsyncPhysicsData GetAsyncPhysicsDataToWrite()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAsyncPhysicsDataToWrite, __ReturnBuffer);

				return *(UAsyncPhysicsData*)__ReturnBuffer;
			}
		}

		public virtual UAsyncPhysicsData GetAsyncPhysicsDataToConsume()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAsyncPhysicsDataToConsume, __ReturnBuffer);

				return *(UAsyncPhysicsData*)__ReturnBuffer;
			}
		}

		public virtual void FOV(float NewFOV)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewFOV;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __FOV, __InBuffer);
			}
		}

		public virtual void EnableCheats()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __EnableCheats);
			}
		}

		public virtual bool DeprojectScreenPositionToWorld(float ScreenX, float ScreenY, ref FVector WorldLocation, ref FVector WorldDirection)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(float*)(__InBuffer) = ScreenX;

				*(float*)(__InBuffer + 4) = ScreenY;

				*(nint*)(__InBuffer + 8) = WorldLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = WorldDirection?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __DeprojectScreenPositionToWorld, __InBuffer, __OutBuffer, __ReturnBuffer);

				WorldLocation = *(FVector*)(__OutBuffer);

				WorldDirection = *(FVector*)(__OutBuffer + 8);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool DeprojectMousePositionToWorld(ref FVector WorldLocation, ref FVector WorldDirection)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = WorldDirection?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __DeprojectMousePositionToWorld, __InBuffer, __OutBuffer, __ReturnBuffer);

				WorldLocation = *(FVector*)(__OutBuffer);

				WorldDirection = *(FVector*)(__OutBuffer + 8);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void ConsoleKey(FKey Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ConsoleKey, __InBuffer);
			}
		}

		public virtual void ClientWasKicked(FText KickReason)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = KickReason?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientWasKicked, __InBuffer);
			}
		}

		public virtual void ClientVoiceHandshakeComplete()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __ClientVoiceHandshakeComplete);
			}
		}

		/// <param name="LevelStatuses">
		/// The list of levels the client should have either streamed in or not, depending on state.
		/// </param>
		public virtual void ClientUpdateMultipleLevelsStreamingStatus(TArray<FUpdateLevelStreamingLevelStatus> LevelStatuses)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LevelStatuses?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientUpdateMultipleLevelsStreamingStatus, __InBuffer);
			}
		}

		/// <param name="PackageName">
		/// - Name of the level package name used for loading.
		/// </param>
		/// <param name="bNewShouldBeLoaded">
		/// - Whether the level should be loaded
		/// </param>
		/// <param name="bNewShouldBeVisible">
		/// - Whether the level should be visible if it is loaded	
		/// </param>
		/// <param name="bNewShouldBlockOnLoad">
		/// - Whether we want to force a blocking load
		/// </param>
		/// <param name="LODIndex">
		/// - Current LOD index for a streaming level
		/// </param>
		/// <param name="TransactionId">
		/// - Optional parameter used when communicating LevelVisibility changes between server and client
		/// </param>
		/// <param name="bNewShouldBlockOnUnload">
		/// - Optional parameter used to force a blocking unload or not
		/// </param>
		public virtual void ClientUpdateLevelStreamingStatus(FName PackageName, bool bNewShouldBeLoaded, bool bNewShouldBeVisible, bool bNewShouldBlockOnLoad, int LODIndex, FNetLevelVisibilityTransactionId TransactionId, bool bNewShouldBlockOnUnload)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = PackageName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bNewShouldBeLoaded;

				*(bool*)(__InBuffer + 9) = bNewShouldBeVisible;

				*(bool*)(__InBuffer + 10) = bNewShouldBlockOnLoad;

				*(int*)(__InBuffer + 11) = LODIndex;

				*(nint*)(__InBuffer + 15) = TransactionId?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 23) = bNewShouldBlockOnUnload;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientUpdateLevelStreamingStatus, __InBuffer);
			}
		}

		/// <param name="PlayerIds">
		/// player ids to unmute
		/// </param>
		public virtual void ClientUnmutePlayers(TArray<FUniqueNetIdRepl> PlayerIds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlayerIds?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientUnmutePlayers, __InBuffer);
			}
		}

		/// <param name="PlayerId">
		/// player id to unmute
		/// </param>
		public virtual void ClientUnmutePlayer(FUniqueNetIdRepl PlayerId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlayerId?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientUnmutePlayer, __InBuffer);
			}
		}

		/// <param name="URL">
		/// A string containing the mapname (or IP address) to travel to, along with option key/value pairs
		/// </param>
		/// <param name="TravelType">
		/// specifies whether the client should append URL options used in previous travels; if true is specified
		/// for the bSeamlesss parameter, this value must be TRAVEL_Relative.
		/// </param>
		/// <param name="bSeamless">
		/// Indicates whether to use seamless travel (requires TravelType of TRAVEL_Relative)
		/// </param>
		/// <param name="MapPackageGuid">
		/// The GUID of the map package to travel to - this is used to find the file when it has been autodownloaded,
		/// so it is only needed for clients
		/// </param>
		public virtual void ClientTravelInternal(FString URL, ETravelType TravelType, bool bSeamless, FGuid MapPackageGuid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = URL?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)TravelType;

				*(bool*)(__InBuffer + 9) = bSeamless;

				*(nint*)(__InBuffer + 10) = MapPackageGuid?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientTravelInternal, __InBuffer);
			}
		}

		/// <param name="URL">
		/// A string containing the mapname (or IP address) to travel to, along with option key/value pairs
		/// </param>
		/// <param name="TravelType">
		/// specifies whether the client should append URL options used in previous travels; if true is specified
		/// for the bSeamlesss parameter, this value must be TRAVEL_Relative.
		/// </param>
		/// <param name="bSeamless">
		/// Indicates whether to use seamless travel (requires TravelType of TRAVEL_Relative)
		/// </param>
		/// <param name="MapPackageGuid">
		/// The GUID of the map package to travel to - this is used to find the file when it has been autodownloaded,
		/// so it is only needed for clients
		/// </param>
		public virtual void ClientTravel(FString URL, ETravelType TravelType, bool bSeamless, FGuid MapPackageGuid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = URL?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)TravelType;

				*(bool*)(__InBuffer + 9) = bSeamless;

				*(nint*)(__InBuffer + 10) = MapPackageGuid?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ClientTravel, __InBuffer);
			}
		}

		/// <todo>
		/// document */
		/// </todo>
		public virtual void ClientTeamMessage(APlayerState SenderPlayerState, FString S, FName Type, float MsgLifeTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = SenderPlayerState?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = S?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Type?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = MsgLifeTime;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientTeamMessage, __InBuffer);
			}
		}

		/// <param name="ForceFeedbackEffect">
		/// If set only patterns from that effect will be stopped
		/// </param>
		/// <param name="Tag">
		/// If not none only the pattern with this tag will be stopped
		/// </param>
		public virtual void ClientStopForceFeedback(UForceFeedbackEffect ForceFeedbackEffect, FName Tag)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ForceFeedbackEffect?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Tag?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientStopForceFeedback, __InBuffer);
			}
		}

		public virtual void ClientStopCameraShakesFromSource(UCameraShakeSourceComponent SourceComponent, bool bImmediately = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = SourceComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bImmediately;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ClientStopCameraShakesFromSource, __InBuffer);
			}
		}

		public virtual void ClientStopCameraShake(TSubclassOf<UCameraShakeBase> Shake, bool bImmediately = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Shake?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bImmediately;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientStopCameraShake, __InBuffer);
			}
		}

		public virtual void ClientStartOnlineSession()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __ClientStartOnlineSession);
			}
		}

		/// <param name="Shake">
		/// - Camera shake animation to play
		/// </param>
		/// <param name="SourceComponent">
		/// - The source from which the camera shakes originates
		/// </param>
		public virtual void ClientStartCameraShakeFromSource(TSubclassOf<UCameraShakeBase> Shake, UCameraShakeSourceComponent SourceComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Shake?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SourceComponent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ClientStartCameraShakeFromSource, __InBuffer);
			}
		}

		/// <param name="Shake">
		/// - Camera shake animation to play
		/// </param>
		/// <param name="Scale">
		/// - Scalar defining how "intense" to play the anim
		/// </param>
		/// <param name="PlaySpace">
		/// - Which coordinate system to play the shake in (used for CameraAnims within the shake).
		/// </param>
		/// <param name="UserPlaySpaceRot">
		/// - Matrix used when PlaySpace = CAPS_UserDefined
		/// </param>
		public virtual void ClientStartCameraShake(TSubclassOf<UCameraShakeBase> Shake, float Scale = 1.000000f, ECameraShakePlaySpace PlaySpace = ECameraShakePlaySpace.CameraLocal, FRotator UserPlaySpaceRot = null)
		{
			unsafe
			{
				UserPlaySpaceRot ??= new FRotator();

				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = Shake?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Scale;

				*(byte*)(__InBuffer + 12) = (byte)PlaySpace;

				*(nint*)(__InBuffer + 13) = UserPlaySpaceRot?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientStartCameraShake, __InBuffer);
			}
		}

		public virtual void ClientSpawnGenericCameraLensEffect(TSubclassOf<AActor> LensEffectEmitterClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LensEffectEmitterClass?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientSpawnGenericCameraLensEffect, __InBuffer);
			}
		}

		public virtual void ClientSpawnCameraLensEffect(TSubclassOf<AEmitterCameraLensEffectBase> LensEffectEmitterClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LensEffectEmitterClass?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientSpawnCameraLensEffect, __InBuffer);
			}
		}

		/// <param name="A">
		/// - new actor to set as view target
		/// </param>
		/// <param name="TransitionParams">
		/// - parameters to use for controlling the transition
		/// </param>
		public virtual void ClientSetViewTarget(AActor A, FViewTargetTransitionParams TransitionParams)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TransitionParams?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientSetViewTarget, __InBuffer);
			}
		}

		public virtual void ClientSetSpectatorWaiting(bool bWaiting)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bWaiting;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientSetSpectatorWaiting, __InBuffer);
			}
		}

		public virtual void ClientSetHUD(TSubclassOf<AHUD> NewHUDClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewHUDClass?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientSetHUD, __InBuffer);
			}
		}

		/// <param name="Material">
		/// - The material whose textures should be forced into memory.
		/// </param>
		/// <param name="ForceDuration">
		/// - Number of seconds to keep all mip-levels in memory, disregarding the normal priority logic.
		/// </param>
		/// <param name="CinematicTextureGroups">
		/// - Bitfield indicating which texture groups that use extra high-resolution mips
		/// </param>
		public virtual void ClientSetForceMipLevelsToBeResident(UMaterialInterface Material, float ForceDuration, int CinematicTextureGroups)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = ForceDuration;

				*(int*)(__InBuffer + 12) = CinematicTextureGroups;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientSetForceMipLevelsToBeResident, __InBuffer);
			}
		}

		public virtual void ClientSetCinematicMode(bool bInCinematicMode, bool bAffectsMovement, bool bAffectsTurning, bool bAffectsHUD)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(bool*)(__InBuffer) = bInCinematicMode;

				*(bool*)(__InBuffer + 1) = bAffectsMovement;

				*(bool*)(__InBuffer + 2) = bAffectsTurning;

				*(bool*)(__InBuffer + 3) = bAffectsHUD;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientSetCinematicMode, __InBuffer);
			}
		}

		/// <param name="NewCamMode">
		/// , name defining the new camera mode
		/// </param>
		public virtual void ClientSetCameraMode(FName NewCamMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewCamMode?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientSetCameraMode, __InBuffer);
			}
		}

		/// <param name="bEnableFading">
		/// - true if we should apply FadeColor/FadeAmount to the screen
		/// </param>
		/// <param name="FadeColor">
		/// - Color to fade to
		/// </param>
		/// <param name="FadeAlpha">
		/// - Contains the start fade (X) and end fade (Y) values to apply. A start fade of less than 0 will use the screen's current fade value
		/// </param>
		/// <param name="FadeTime">
		/// - length of time for fade to occur over
		/// </param>
		/// <param name="bFadeAudio">
		/// - true to apply fading of audio alongside the video
		/// </param>
		/// <param name="bHoldWhenFinished">
		/// - True for fade to hold at the ToAlpha until fade is disabled
		/// </param>
		public virtual void ClientSetCameraFade(bool bEnableFading, FColor FadeColor, FVector2D FadeAlpha, float FadeTime, bool bFadeAudio, bool bHoldWhenFinished)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[23];

				*(bool*)(__InBuffer) = bEnableFading;

				*(nint*)(__InBuffer + 1) = FadeColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 9) = FadeAlpha?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 17) = FadeTime;

				*(bool*)(__InBuffer + 21) = bFadeAudio;

				*(bool*)(__InBuffer + 22) = bHoldWhenFinished;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientSetCameraFade, __InBuffer);
			}
		}

		public virtual void ClientSetBlockOnAsyncLoading()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __ClientSetBlockOnAsyncLoading);
			}
		}

		public virtual void ClientReturnToMainMenuWithTextReason(FText ReturnReason)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ReturnReason?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientReturnToMainMenuWithTextReason, __InBuffer);
			}
		}

		public virtual void ClientRetryClientRestart(APawn NewPawn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewPawn?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientRetryClientRestart, __InBuffer);
			}
		}

		public virtual void ClientRestart(APawn NewPawn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewPawn?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientRestart, __InBuffer);
			}
		}

		public virtual void ClientReset()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __ClientReset);
			}
		}

		public virtual void ClientRepObjRef(UObject Object)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientRepObjRef, __InBuffer);
			}
		}

		public virtual void ClientRecvServerAckFrameDebug(byte NumBuffered, float TargetNumBufferedCmds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(byte*)(__InBuffer) = NumBuffered;

				*(float*)(__InBuffer + 1) = TargetNumBufferedCmds;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientRecvServerAckFrameDebug, __InBuffer);
			}
		}

		public virtual void ClientRecvServerAckFrame(int LastProcessedInputFrame, int RecvServerFrameNumber, sbyte TimeDilation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(int*)(__InBuffer) = LastProcessedInputFrame;

				*(int*)(__InBuffer + 4) = RecvServerFrameNumber;

				*(sbyte*)(__InBuffer + 8) = TimeDilation;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientRecvServerAckFrame, __InBuffer);
			}
		}

		public virtual void ClientReceiveLocalizedMessage(TSubclassOf<ULocalMessage> Message, int Switch, APlayerState RelatedPlayerState_1, APlayerState RelatedPlayerState_2, UObject OptionalObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(nint*)(__InBuffer) = Message?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Switch;

				*(nint*)(__InBuffer + 12) = RelatedPlayerState_1?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 20) = RelatedPlayerState_2?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 28) = OptionalObject?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientReceiveLocalizedMessage, __InBuffer);
			}
		}

		/// <param name="ForcedActor">
		/// - The actor whose textures should be forced into memory.
		/// </param>
		/// <param name="ForceDuration">
		/// - Number of seconds to keep all mip-levels in memory, disregarding the normal priority logic.
		/// </param>
		/// <param name="bEnableStreaming">
		/// - Whether to start (true) or stop (false) streaming
		/// </param>
		/// <param name="CinematicTextureGroups">
		/// - Bitfield indicating which texture groups that use extra high-resolution mips
		/// </param>
		public virtual void ClientPrestreamTextures(AActor ForcedActor, float ForceDuration, bool bEnableStreaming, int CinematicTextureGroups)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = ForcedActor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = ForceDuration;

				*(bool*)(__InBuffer + 12) = bEnableStreaming;

				*(int*)(__InBuffer + 13) = CinematicTextureGroups;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientPrestreamTextures, __InBuffer);
			}
		}

		/// <param name="LevelNames">
		/// - the names of the level packages to load. LevelNames[0] will be the new persistent (primary) level
		/// </param>
		/// <param name="bFirst">
		/// - whether this is the first item in the list (so clear the list first)
		/// </param>
		/// <param name="bLast">
		/// - whether this is the last item in the list (so start preparing the change after receiving it)
		/// </param>
		public virtual void ClientPrepareMapChange(FName LevelName, bool bFirst, bool bLast)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = LevelName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bFirst;

				*(bool*)(__InBuffer + 9) = bLast;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientPrepareMapChange, __InBuffer);
			}
		}

		/// <param name="Sound">
		/// - Sound to play
		/// </param>
		/// <param name="Location">
		/// - Location to play the sound at
		/// </param>
		/// <param name="VolumeMultiplier">
		/// - Volume multiplier to apply to the sound
		/// </param>
		/// <param name="PitchMultiplier">
		/// - Pitch multiplier to apply to the sound
		/// </param>
		public virtual void ClientPlaySoundAtLocation(USoundBase Sound, FVector Location, float VolumeMultiplier, float PitchMultiplier)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Sound?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = VolumeMultiplier;

				*(float*)(__InBuffer + 20) = PitchMultiplier;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientPlaySoundAtLocation, __InBuffer);
			}
		}

		/// <param name="Sound">
		/// - Sound to play
		/// </param>
		/// <param name="VolumeMultiplier">
		/// - Volume multiplier to apply to the sound
		/// </param>
		/// <param name="PitchMultiplier">
		/// - Pitch multiplier to apply to the sound
		/// </param>
		public virtual void ClientPlaySound(USoundBase Sound, float VolumeMultiplier, float PitchMultiplier)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Sound?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = VolumeMultiplier;

				*(float*)(__InBuffer + 12) = PitchMultiplier;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientPlaySound, __InBuffer);
			}
		}

		public virtual void ClientPlayForceFeedback_Internal(UForceFeedbackEffect ForceFeedbackEffect, FForceFeedbackParameters Params)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ForceFeedbackEffect?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Params?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientPlayForceFeedback_Internal, __InBuffer);
			}
		}

		/// <param name="PlayerId">
		/// player id to mute
		/// </param>
		public virtual void ClientMutePlayer(FUniqueNetIdRepl PlayerId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlayerId?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientMutePlayer, __InBuffer);
			}
		}

		/// <param name="S">
		/// - message to display
		/// </param>
		/// <param name="Type">
		/// - @todo document
		/// </param>
		/// <param name="MsgLifeTime">
		/// - Optional length of time to display 0 = default time
		/// </param>
		public virtual void ClientMessage(FString S, FName Type, float MsgLifeTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = S?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Type?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = MsgLifeTime;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientMessage, __InBuffer);
			}
		}

		public virtual void ClientIgnoreMoveInput(bool bIgnore)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIgnore;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientIgnoreMoveInput, __InBuffer);
			}
		}

		public virtual void ClientIgnoreLookInput(bool bIgnore)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIgnore;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientIgnoreLookInput, __InBuffer);
			}
		}

		/// <Note>
		/// ALL STATE NAMES NEED TO BE DEFINED IN name table in UnrealNames.h to be correctly replicated (so they are mapped to the same thing on client and server).
		/// </Note>
		public virtual void ClientGotoState(FName NewState)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewState?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientGotoState, __InBuffer);
			}
		}

		/// <param name="EndGameFocus">
		/// - actor to view with camera
		/// </param>
		/// <param name="bIsWinner">
		/// - true if this controller is on winning team
		/// </param>
		public virtual void ClientGameEnded(AActor EndGameFocus, bool bIsWinner)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = EndGameFocus?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIsWinner;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientGameEnded, __InBuffer);
			}
		}

		public virtual void ClientForceGarbageCollection()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __ClientForceGarbageCollection);
			}
		}

		public virtual void ClientFlushLevelStreaming()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __ClientFlushLevelStreaming);
			}
		}

		public virtual void ClientEndOnlineSession()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __ClientEndOnlineSession);
			}
		}

		/// <param name="bEnable">
		/// enable or disable voice chat
		/// </param>
		public virtual void ClientEnableNetworkVoice(bool bEnable)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnable;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientEnableNetworkVoice, __InBuffer);
			}
		}

		public virtual void ClientCorrectionAsyncPhysicsTimestamp(FAsyncPhysicsTimestamp Timestamp)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Timestamp?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientCorrectionAsyncPhysicsTimestamp, __InBuffer);
			}
		}

		public virtual void ClientCommitMapChange()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __ClientCommitMapChange);
			}
		}

		public virtual void ClientClearCameraLensEffects()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __ClientClearCameraLensEffects);
			}
		}

		public virtual void ClientCapBandwidth(int Cap)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Cap;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientCapBandwidth, __InBuffer);
			}
		}

		public virtual void ClientCancelPendingMapChange()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __ClientCancelPendingMapChange);
			}
		}

		public virtual void ClientAddTextureStreamingLoc(FVector InLoc, float Duration, bool bOverrideLocation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = InLoc?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Duration;

				*(bool*)(__InBuffer + 12) = bOverrideLocation;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientAddTextureStreamingLoc, __InBuffer);
			}
		}

		/// <param name="PackageName">
		/// - Identifying the level that we are acknowledging levelvisibility for
		/// </param>
		/// <param name="TransactionId">
		/// - TransactionId being acknowledged
		/// </param>
		public virtual void ClientAckUpdateLevelVisibility(FName PackageName, FNetLevelVisibilityTransactionId TransactionId, bool bClientAckCanMakeVisible)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = PackageName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TransactionId?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bClientAckCanMakeVisible;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientAckUpdateLevelVisibility, __InBuffer);
			}
		}

		public virtual void ClientAckTimeDilation(float TimeDilation, int ServerStep)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = TimeDilation;

				*(int*)(__InBuffer + 4) = ServerStep;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientAckTimeDilation, __InBuffer);
			}
		}

		public virtual void ClearAudioListenerOverride()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearAudioListenerOverride);
			}
		}

		public virtual void ClearAudioListenerAttenuationOverride()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearAudioListenerAttenuationOverride);
			}
		}

		public virtual bool CanRestartPlayer()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __CanRestartPlayer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="New">
		/// camera mode to set
		/// </param>
		public virtual void Camera(FName NewMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewMode?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Camera, __InBuffer);
			}
		}

		/// <param name="Val">
		/// Amount to add to Yaw. This value is multiplied by InputYawScale.
		/// </param>
		public virtual void AddYawInput(float Val)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Val;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddYawInput, __InBuffer);
			}
		}

		/// <param name="Val">
		/// Amount to add to Roll. This value is multiplied by InputRollScale.
		/// </param>
		public virtual void AddRollInput(float Val)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Val;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddRollInput, __InBuffer);
			}
		}

		/// <param name="Val">
		/// Amount to add to Pitch. This value is multiplied by InputPitchScale.
		/// </param>
		public virtual void AddPitchInput(float Val)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Val;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddPitchInput, __InBuffer);
			}
		}

		public virtual void ActivateTouchInterface(UTouchInterface NewTouchInterface)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewTouchInterface?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ActivateTouchInterface, __InBuffer);
			}
		}

		private static uint __Player = 0;

		private static uint __AcknowledgedPawn = 0;

		private static uint __MyHUD = 0;

		private static uint __PlayerCameraManager = 0;

		private static uint __PlayerCameraManagerClass = 0;

		private static uint __bAutoManageActiveCameraTarget = 0;

		private static uint __TargetViewRotation = 0;

		private static uint __SmoothTargetViewRotationSpeed = 0;

		private static uint __HiddenActors = 0;

		private static uint __HiddenPrimitiveComponents = 0;

		private static uint __LastSpectatorStateSynchTime = 0;

		private static uint __LastSpectatorSyncLocation = 0;

		private static uint __LastSpectatorSyncRotation = 0;

		private static uint __ClientCap = 0;

		private static uint __CheatManager = 0;

		private static uint __CheatClass = 0;

		private static uint __PlayerInput = 0;

		private static uint __ActiveForceFeedbackEffects = 0;

		private static uint __AsyncPhysicsDataComponent_DEPRECARED = 0;

		private static uint __bPlayerIsWaiting = 0;

		private static uint __NetPlayerIndex = 0;

		private static uint __PendingSwapConnection = 0;

		private static uint __NetConnection = 0;

		private static uint __bShowMouseCursor = 0;

		private static uint __bEnableClickEvents = 0;

		private static uint __bEnableTouchEvents = 0;

		private static uint __bEnableMouseOverEvents = 0;

		private static uint __bEnableTouchOverEvents = 0;

		private static uint __bForceFeedbackEnabled = 0;

		private static uint __bEnableMotionControls = 0;

		private static uint __bEnableStreamingSource = 0;

		private static uint __bStreamingSourceShouldActivate = 0;

		private static uint __bStreamingSourceShouldBlockOnSlowStreaming = 0;

		private static uint __StreamingSourcePriority = 0;

		private static uint __StreamingSourceDebugColor = 0;

		private static uint __StreamingSourceShapes = 0;

		private static uint __ForceFeedbackScale = 0;

		private static uint __ClickEventKeys = 0;

		private static uint __DefaultMouseCursor = 0;

		private static uint __CurrentMouseCursor = 0;

		private static uint __DefaultClickTraceChannel = 0;

		private static uint __CurrentClickTraceChannel = 0;

		private static uint __HitResultTraceDistance = 0;

		private static uint __SeamlessTravelCount = 0;

		private static uint __LastCompletedSeamlessTravelCount = 0;

		private static uint __InactiveStateInputComponent = 0;

		private static uint __bShouldPerformFullTickWhenPaused = 0;

		private static uint __CurrentTouchInterface = 0;

		private static uint __OverridePlayerInputClass = 0;

		private static uint __SpectatorPawn = 0;

		private static uint __bIsLocalPlayerController = 0;

		private static uint __SpawnLocation = 0;

		private static uint __WasInputKeyJustReleased = 0;

		private static uint __WasInputKeyJustPressed = 0;

		private static uint __ToggleSpeaking = 0;

		private static uint __TestServerLevelVisibilityChange = 0;

		private static uint __SwitchLevel = 0;

		private static uint __StreamingSourceShouldBlockOnSlowStreaming = 0;

		private static uint __StreamingSourceShouldActivate = 0;

		private static uint __StopHapticEffect = 0;

		private static uint __StartFire = 0;

		private static uint __SetVirtualJoystickVisibility = 0;

		private static uint __SetViewTargetWithBlend = 0;

		private static uint __SetName = 0;

		private static uint __SetMouseLocation = 0;

		private static uint __SetMouseCursorWidget = 0;

		private static uint __SetMotionControlsEnabled = 0;

		private static uint __SetHapticsByValue = 0;

		private static uint __SetDisableHaptics = 0;

		private static uint __SetDeprecatedInputYawScale = 0;

		private static uint __SetDeprecatedInputRollScale = 0;

		private static uint __SetDeprecatedInputPitchScale = 0;

		private static uint __SetControllerLightColor = 0;

		private static uint __SetCinematicMode = 0;

		private static uint __SetAudioListenerOverride = 0;

		private static uint __SetAudioListenerAttenuationOverride = 0;

		private static uint __ServerViewSelf = 0;

		private static uint __ServerViewPrevPlayer = 0;

		private static uint __ServerViewNextPlayer = 0;

		private static uint __ServerVerifyViewTarget = 0;

		private static uint __ServerUpdateMultipleLevelsVisibility = 0;

		private static uint __ServerUpdateLevelVisibility = 0;

		private static uint __ServerUpdateCamera = 0;

		private static uint __ServerUnmutePlayer = 0;

		private static uint __ServerUnblockPlayer = 0;

		private static uint __ServerToggleAILogging = 0;

		private static uint __ServerShortTimeout = 0;

		private static uint __ServerSetSpectatorWaiting = 0;

		private static uint __ServerSetSpectatorLocation = 0;

		private static uint __ServerSendLatestAsyncPhysicsTimestamp = 0;

		private static uint __ServerRestartPlayer = 0;

		private static uint __ServerRecvClientInputFrame = 0;

		private static uint __ServerPause = 0;

		private static uint __ServerNotifyLoadedWorld = 0;

		private static uint __ServerMutePlayer = 0;

		private static uint __ServerExecRPC = 0;

		private static uint __ServerExec = 0;

		private static uint __ServerCheckClientPossessionReliable = 0;

		private static uint __ServerCheckClientPossession = 0;

		private static uint __ServerChangeName = 0;

		private static uint __ServerCamera = 0;

		private static uint __ServerBlockPlayer = 0;

		private static uint __ServerAcknowledgePossession = 0;

		private static uint __SendToConsole = 0;

		private static uint __RestartLevel = 0;

		private static uint __ResetControllerLightColor = 0;

		private static uint __ProjectWorldLocationToScreen = 0;

		private static uint __PlayHapticEffect = 0;

		private static uint __PlayDynamicForceFeedback = 0;

		private static uint __Pause = 0;

		private static uint __OnServerStartedVisualLogger = 0;

		private static uint __OnRep_AsyncPhysicsDataComponent = 0;

		private static uint __LocalTravel = 0;

		private static uint __K2_ClientPlayForceFeedback = 0;

		private static uint __IsStreamingSourceEnabled = 0;

		private static uint __IsInputKeyDown = 0;

		private static uint __GetViewportSize = 0;

		private static uint __GetStreamingSourceShapes = 0;

		private static uint __GetStreamingSourcePriority = 0;

		private static uint __GetStreamingSourceLocationAndRotation = 0;

		private static uint __GetSpectatorPawn = 0;

		private static uint __GetPlatformUserId = 0;

		private static uint __GetOverridePlayerInputClass = 0;

		private static uint __GetMousePosition = 0;

		private static uint __GetInputVectorKeyState = 0;

		private static uint __GetInputTouchState = 0;

		private static uint __GetInputMouseDelta = 0;

		private static uint __GetInputMotionState = 0;

		private static uint __GetInputKeyTimeDown = 0;

		private static uint __GetInputAnalogStickState = 0;

		private static uint __GetInputAnalogKeyState = 0;

		private static uint __GetHUD = 0;

		private static uint __GetHitResultUnderFingerForObjects = 0;

		private static uint __GetHitResultUnderFingerByChannel = 0;

		private static uint __GetHitResultUnderFinger = 0;

		private static uint __GetHitResultUnderCursorForObjects = 0;

		private static uint __GetHitResultUnderCursorByChannel = 0;

		private static uint __GetHitResultUnderCursor = 0;

		private static uint __GetFocalLocation = 0;

		private static uint __GetDeprecatedInputYawScale = 0;

		private static uint __GetDeprecatedInputRollScale = 0;

		private static uint __GetDeprecatedInputPitchScale = 0;

		private static uint __GetAsyncPhysicsDataToWrite = 0;

		private static uint __GetAsyncPhysicsDataToConsume = 0;

		private static uint __FOV = 0;

		private static uint __EnableCheats = 0;

		private static uint __DeprojectScreenPositionToWorld = 0;

		private static uint __DeprojectMousePositionToWorld = 0;

		private static uint __ConsoleKey = 0;

		private static uint __ClientWasKicked = 0;

		private static uint __ClientVoiceHandshakeComplete = 0;

		private static uint __ClientUpdateMultipleLevelsStreamingStatus = 0;

		private static uint __ClientUpdateLevelStreamingStatus = 0;

		private static uint __ClientUnmutePlayers = 0;

		private static uint __ClientUnmutePlayer = 0;

		private static uint __ClientTravelInternal = 0;

		private static uint __ClientTravel = 0;

		private static uint __ClientTeamMessage = 0;

		private static uint __ClientStopForceFeedback = 0;

		private static uint __ClientStopCameraShakesFromSource = 0;

		private static uint __ClientStopCameraShake = 0;

		private static uint __ClientStartOnlineSession = 0;

		private static uint __ClientStartCameraShakeFromSource = 0;

		private static uint __ClientStartCameraShake = 0;

		private static uint __ClientSpawnGenericCameraLensEffect = 0;

		private static uint __ClientSpawnCameraLensEffect = 0;

		private static uint __ClientSetViewTarget = 0;

		private static uint __ClientSetSpectatorWaiting = 0;

		private static uint __ClientSetHUD = 0;

		private static uint __ClientSetForceMipLevelsToBeResident = 0;

		private static uint __ClientSetCinematicMode = 0;

		private static uint __ClientSetCameraMode = 0;

		private static uint __ClientSetCameraFade = 0;

		private static uint __ClientSetBlockOnAsyncLoading = 0;

		private static uint __ClientReturnToMainMenuWithTextReason = 0;

		private static uint __ClientRetryClientRestart = 0;

		private static uint __ClientRestart = 0;

		private static uint __ClientReset = 0;

		private static uint __ClientRepObjRef = 0;

		private static uint __ClientRecvServerAckFrameDebug = 0;

		private static uint __ClientRecvServerAckFrame = 0;

		private static uint __ClientReceiveLocalizedMessage = 0;

		private static uint __ClientPrestreamTextures = 0;

		private static uint __ClientPrepareMapChange = 0;

		private static uint __ClientPlaySoundAtLocation = 0;

		private static uint __ClientPlaySound = 0;

		private static uint __ClientPlayForceFeedback_Internal = 0;

		private static uint __ClientMutePlayer = 0;

		private static uint __ClientMessage = 0;

		private static uint __ClientIgnoreMoveInput = 0;

		private static uint __ClientIgnoreLookInput = 0;

		private static uint __ClientGotoState = 0;

		private static uint __ClientGameEnded = 0;

		private static uint __ClientForceGarbageCollection = 0;

		private static uint __ClientFlushLevelStreaming = 0;

		private static uint __ClientEndOnlineSession = 0;

		private static uint __ClientEnableNetworkVoice = 0;

		private static uint __ClientCorrectionAsyncPhysicsTimestamp = 0;

		private static uint __ClientCommitMapChange = 0;

		private static uint __ClientClearCameraLensEffects = 0;

		private static uint __ClientCapBandwidth = 0;

		private static uint __ClientCancelPendingMapChange = 0;

		private static uint __ClientAddTextureStreamingLoc = 0;

		private static uint __ClientAckUpdateLevelVisibility = 0;

		private static uint __ClientAckTimeDilation = 0;

		private static uint __ClearAudioListenerOverride = 0;

		private static uint __ClearAudioListenerAttenuationOverride = 0;

		private static uint __CanRestartPlayer = 0;

		private static uint __Camera = 0;

		private static uint __AddYawInput = 0;

		private static uint __AddRollInput = 0;

		private static uint __AddPitchInput = 0;

		private static uint __ActivateTouchInterface = 0;
	}
}