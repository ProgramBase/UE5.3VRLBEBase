using Script.CoreUObject;
using Script.InputCore;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.Actor")]
	public partial class AActor : UObject, IStaticClass
	{
		public FActorTickFunction PrimaryActorTick
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PrimaryActorTick, __ReturnBuffer);

					return *(FActorTickFunction*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PrimaryActorTick, __InBuffer);
				}
			}
		}

		public bool bNetTemporary
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNetTemporary, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNetTemporary, __InBuffer);
				}
			}
		}

		public bool bOnlyRelevantToOwner
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOnlyRelevantToOwner, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOnlyRelevantToOwner, __InBuffer);
				}
			}
		}

		public bool bAlwaysRelevant
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAlwaysRelevant, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAlwaysRelevant, __InBuffer);
				}
			}
		}

		public bool bReplicateMovement
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bReplicateMovement, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bReplicateMovement, __InBuffer);
				}
			}
		}

		public bool bCallPreReplication
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCallPreReplication, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCallPreReplication, __InBuffer);
				}
			}
		}

		public bool bCallPreReplicationForReplay
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCallPreReplicationForReplay, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCallPreReplicationForReplay, __InBuffer);
				}
			}
		}

		public bool bHidden
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHidden, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHidden, __InBuffer);
				}
			}
		}

		public bool bTearOff
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bTearOff, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bTearOff, __InBuffer);
				}
			}
		}

		public bool bForceNetAddressable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bForceNetAddressable, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bForceNetAddressable, __InBuffer);
				}
			}
		}

		public bool bIsInEditingLevelInstance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsInEditingLevelInstance, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsInEditingLevelInstance, __InBuffer);
				}
			}
		}

		public bool bIsMainWorldOnly
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsMainWorldOnly, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsMainWorldOnly, __InBuffer);
				}
			}
		}

		public bool bExchangedRoles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bExchangedRoles, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bExchangedRoles, __InBuffer);
				}
			}
		}

		public bool bNetLoadOnClient
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNetLoadOnClient, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNetLoadOnClient, __InBuffer);
				}
			}
		}

		public bool bNetUseOwnerRelevancy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNetUseOwnerRelevancy, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNetUseOwnerRelevancy, __InBuffer);
				}
			}
		}

		public bool bRelevantForNetworkReplays
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bRelevantForNetworkReplays, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bRelevantForNetworkReplays, __InBuffer);
				}
			}
		}

		public bool bRelevantForLevelBounds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bRelevantForLevelBounds, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bRelevantForLevelBounds, __InBuffer);
				}
			}
		}

		public bool bReplayRewindable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bReplayRewindable, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bReplayRewindable, __InBuffer);
				}
			}
		}

		public bool bAllowTickBeforeBeginPlay
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowTickBeforeBeginPlay, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowTickBeforeBeginPlay, __InBuffer);
				}
			}
		}

		public bool bAutoDestroyWhenFinished
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoDestroyWhenFinished, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoDestroyWhenFinished, __InBuffer);
				}
			}
		}

		public bool bCanBeDamaged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCanBeDamaged, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCanBeDamaged, __InBuffer);
				}
			}
		}

		public bool bBlockInput
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bBlockInput, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bBlockInput, __InBuffer);
				}
			}
		}

		public bool bCollideWhenPlacing
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCollideWhenPlacing, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCollideWhenPlacing, __InBuffer);
				}
			}
		}

		public bool bFindCameraComponentWhenViewTarget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bFindCameraComponentWhenViewTarget, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bFindCameraComponentWhenViewTarget, __InBuffer);
				}
			}
		}

		public bool bGenerateOverlapEventsDuringLevelStreaming
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bGenerateOverlapEventsDuringLevelStreaming, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bGenerateOverlapEventsDuringLevelStreaming, __InBuffer);
				}
			}
		}

		public bool bIgnoresOriginShifting
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIgnoresOriginShifting, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIgnoresOriginShifting, __InBuffer);
				}
			}
		}

		public bool bEnableAutoLODGeneration
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableAutoLODGeneration, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableAutoLODGeneration, __InBuffer);
				}
			}
		}

		public bool bIsEditorOnlyActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsEditorOnlyActor, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsEditorOnlyActor, __InBuffer);
				}
			}
		}

		public bool bActorSeamlessTraveled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bActorSeamlessTraveled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bActorSeamlessTraveled, __InBuffer);
				}
			}
		}

		public bool bReplicates
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bReplicates, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bReplicates, __InBuffer);
				}
			}
		}

		public bool bCanBeInCluster
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCanBeInCluster, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCanBeInCluster, __InBuffer);
				}
			}
		}

		public bool bAllowReceiveTickEventOnDedicatedServer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowReceiveTickEventOnDedicatedServer, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowReceiveTickEventOnDedicatedServer, __InBuffer);
				}
			}
		}

		public bool bReplicateUsingRegisteredSubObjectList
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bReplicateUsingRegisteredSubObjectList, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bReplicateUsingRegisteredSubObjectList, __InBuffer);
				}
			}
		}

		public bool bActorEnableCollision
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bActorEnableCollision, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bActorEnableCollision, __InBuffer);
				}
			}
		}

		public bool bActorIsBeingDestroyed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bActorIsBeingDestroyed, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bActorIsBeingDestroyed, __InBuffer);
				}
			}
		}

		public bool bAsyncPhysicsTickEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAsyncPhysicsTickEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAsyncPhysicsTickEnabled, __InBuffer);
				}
			}
		}

		public EActorUpdateOverlapsMethod UpdateOverlapsMethodDuringLevelStreaming
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UpdateOverlapsMethodDuringLevelStreaming, __ReturnBuffer);

					return *(EActorUpdateOverlapsMethod*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UpdateOverlapsMethodDuringLevelStreaming, __InBuffer);
				}
			}
		}

		public EActorUpdateOverlapsMethod DefaultUpdateOverlapsMethodDuringLevelStreaming
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultUpdateOverlapsMethodDuringLevelStreaming, __ReturnBuffer);

					return *(EActorUpdateOverlapsMethod*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultUpdateOverlapsMethodDuringLevelStreaming, __InBuffer);
				}
			}
		}

		public float InitialLifeSpan
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InitialLifeSpan, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InitialLifeSpan, __InBuffer);
				}
			}
		}

		public float CustomTimeDilation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CustomTimeDilation, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CustomTimeDilation, __InBuffer);
				}
			}
		}

		public ENetRole RemoteRole
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RemoteRole, __ReturnBuffer);

					return *(ENetRole*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RemoteRole, __InBuffer);
				}
			}
		}

		public int RayTracingGroupId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RayTracingGroupId, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RayTracingGroupId, __InBuffer);
				}
			}
		}

		public FName RuntimeGrid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RuntimeGrid, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RuntimeGrid, __InBuffer);
				}
			}
		}

		public FRepAttachment AttachmentReplication
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AttachmentReplication, __ReturnBuffer);

					return *(FRepAttachment*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AttachmentReplication, __InBuffer);
				}
			}
		}

		public FRepMovement ReplicatedMovement
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReplicatedMovement, __ReturnBuffer);

					return *(FRepMovement*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReplicatedMovement, __InBuffer);
				}
			}
		}

		public AActor Owner
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Owner, __ReturnBuffer);

					return *(AActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Owner, __InBuffer);
				}
			}
		}

		public FName NetDriverName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NetDriverName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NetDriverName, __InBuffer);
				}
			}
		}

		public ENetRole Role
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Role, __ReturnBuffer);

					return *(ENetRole*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Role, __InBuffer);
				}
			}
		}

		public ENetDormancy NetDormancy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NetDormancy, __ReturnBuffer);

					return *(ENetDormancy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NetDormancy, __InBuffer);
				}
			}
		}

		public ESpawnActorCollisionHandlingMethod SpawnCollisionHandlingMethod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SpawnCollisionHandlingMethod, __ReturnBuffer);

					return *(ESpawnActorCollisionHandlingMethod*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SpawnCollisionHandlingMethod, __InBuffer);
				}
			}
		}

		public EAutoReceiveInput AutoReceiveInput
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AutoReceiveInput, __ReturnBuffer);

					return *(EAutoReceiveInput*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AutoReceiveInput, __InBuffer);
				}
			}
		}

		public int InputPriority
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InputPriority, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InputPriority, __InBuffer);
				}
			}
		}

		public UInputComponent InputComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InputComponent, __ReturnBuffer);

					return *(UInputComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InputComponent, __InBuffer);
				}
			}
		}

		public float NetCullDistanceSquared
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NetCullDistanceSquared, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NetCullDistanceSquared, __InBuffer);
				}
			}
		}

		public int NetTag
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NetTag, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NetTag, __InBuffer);
				}
			}
		}

		public float NetUpdateFrequency
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NetUpdateFrequency, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NetUpdateFrequency, __InBuffer);
				}
			}
		}

		public float MinNetUpdateFrequency
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MinNetUpdateFrequency, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MinNetUpdateFrequency, __InBuffer);
				}
			}
		}

		public float NetPriority
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NetPriority, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NetPriority, __InBuffer);
				}
			}
		}

		public EPhysicsReplicationMode PhysicsReplicationMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PhysicsReplicationMode, __ReturnBuffer);

					return *(EPhysicsReplicationMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PhysicsReplicationMode, __InBuffer);
				}
			}
		}

		public APawn Instigator
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Instigator, __ReturnBuffer);

					return *(APawn*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Instigator, __InBuffer);
				}
			}
		}

		public TArray<AActor> Children
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Children, __ReturnBuffer);

					return *(TArray<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Children, __InBuffer);
				}
			}
		}

		public USceneComponent RootComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RootComponent, __ReturnBuffer);

					return *(USceneComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RootComponent, __InBuffer);
				}
			}
		}

		public FVector PivotOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PivotOffset, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PivotOffset, __InBuffer);
				}
			}
		}

		public UHLODLayer HLODLayer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HLODLayer, __ReturnBuffer);

					return *(UHLODLayer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HLODLayer, __InBuffer);
				}
			}
		}

		public TArray<FName> Layers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Layers, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Layers, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<UChildActorComponent> ParentComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ParentComponent, __ReturnBuffer);

					return *(TWeakObjectPtr<UChildActorComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ParentComponent, __InBuffer);
				}
			}
		}

		public FGuid ActorGuid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActorGuid, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActorGuid, __InBuffer);
				}
			}
		}

		public FGuid ActorInstanceGuid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActorInstanceGuid, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActorInstanceGuid, __InBuffer);
				}
			}
		}

		public FGuid ContentBundleGuid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ContentBundleGuid, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ContentBundleGuid, __InBuffer);
				}
			}
		}

		public TArray<FActorDataLayer> DataLayers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DataLayers, __ReturnBuffer);

					return *(TArray<FActorDataLayer>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DataLayers, __InBuffer);
				}
			}
		}

		public TArray<TSoftObjectPtr<UDataLayerAsset>> DataLayerAssets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DataLayerAssets, __ReturnBuffer);

					return *(TArray<TSoftObjectPtr<UDataLayerAsset>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DataLayerAssets, __InBuffer);
				}
			}
		}

		public AActor GroupActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GroupActor, __ReturnBuffer);

					return *(AActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GroupActor, __InBuffer);
				}
			}
		}

		public float SpriteScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SpriteScale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SpriteScale, __InBuffer);
				}
			}
		}

		public ulong HiddenEditorViews
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HiddenEditorViews, __ReturnBuffer);

					return *(ulong*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(ulong*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HiddenEditorViews, __InBuffer);
				}
			}
		}

		public FString ActorLabel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActorLabel, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActorLabel, __InBuffer);
				}
			}
		}

		public FName FolderPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FolderPath, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FolderPath, __InBuffer);
				}
			}
		}

		public FGuid FolderGuid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FolderGuid, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FolderGuid, __InBuffer);
				}
			}
		}

		public bool bHiddenEd
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHiddenEd, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHiddenEd, __InBuffer);
				}
			}
		}

		public bool bIsEditorPreviewActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsEditorPreviewActor, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsEditorPreviewActor, __InBuffer);
				}
			}
		}

		public bool bHiddenEdLayer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHiddenEdLayer, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHiddenEdLayer, __InBuffer);
				}
			}
		}

		public bool bHiddenEdLevel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHiddenEdLevel, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHiddenEdLevel, __InBuffer);
				}
			}
		}

		public bool bLockLocation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bLockLocation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bLockLocation, __InBuffer);
				}
			}
		}

		public bool bActorLabelEditable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bActorLabelEditable, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bActorLabelEditable, __InBuffer);
				}
			}
		}

		public bool bEditable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEditable, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEditable, __InBuffer);
				}
			}
		}

		public bool bListedInSceneOutliner
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bListedInSceneOutliner, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bListedInSceneOutliner, __InBuffer);
				}
			}
		}

		public bool bOptimizeBPComponentData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOptimizeBPComponentData, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOptimizeBPComponentData, __InBuffer);
				}
			}
		}

		public bool bCanPlayFromHere
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCanPlayFromHere, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCanPlayFromHere, __InBuffer);
				}
			}
		}

		public bool bIsSpatiallyLoaded
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsSpatiallyLoaded, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsSpatiallyLoaded, __InBuffer);
				}
			}
		}

		public bool bHiddenEdTemporary
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHiddenEdTemporary, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHiddenEdTemporary, __InBuffer);
				}
			}
		}

		public bool bForceExternalActorLevelReferenceForPIE
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bForceExternalActorLevelReferenceForPIE, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bForceExternalActorLevelReferenceForPIE, __InBuffer);
				}
			}
		}

		public TArray<FName> Tags
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Tags, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Tags, __InBuffer);
				}
			}
		}

		public FTakeAnyDamageSignature OnTakeAnyDamage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnTakeAnyDamage, __ReturnBuffer);

					return *(FTakeAnyDamageSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnTakeAnyDamage, __InBuffer);
				}
			}
		}

		public FTakePointDamageSignature OnTakePointDamage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnTakePointDamage, __ReturnBuffer);

					return *(FTakePointDamageSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnTakePointDamage, __InBuffer);
				}
			}
		}

		public FTakeRadialDamageSignature OnTakeRadialDamage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnTakeRadialDamage, __ReturnBuffer);

					return *(FTakeRadialDamageSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnTakeRadialDamage, __InBuffer);
				}
			}
		}

		public FActorBeginOverlapSignature OnActorBeginOverlap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnActorBeginOverlap, __ReturnBuffer);

					return *(FActorBeginOverlapSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnActorBeginOverlap, __InBuffer);
				}
			}
		}

		public FActorEndOverlapSignature OnActorEndOverlap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnActorEndOverlap, __ReturnBuffer);

					return *(FActorEndOverlapSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnActorEndOverlap, __InBuffer);
				}
			}
		}

		public FActorBeginCursorOverSignature OnBeginCursorOver
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnBeginCursorOver, __ReturnBuffer);

					return *(FActorBeginCursorOverSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnBeginCursorOver, __InBuffer);
				}
			}
		}

		public FActorEndCursorOverSignature OnEndCursorOver
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnEndCursorOver, __ReturnBuffer);

					return *(FActorEndCursorOverSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnEndCursorOver, __InBuffer);
				}
			}
		}

		public FActorOnClickedSignature OnClicked
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnClicked, __ReturnBuffer);

					return *(FActorOnClickedSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnClicked, __InBuffer);
				}
			}
		}

		public FActorOnReleasedSignature OnReleased
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnReleased, __ReturnBuffer);

					return *(FActorOnReleasedSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnReleased, __InBuffer);
				}
			}
		}

		public FActorOnInputTouchBeginSignature OnInputTouchBegin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnInputTouchBegin, __ReturnBuffer);

					return *(FActorOnInputTouchBeginSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnInputTouchBegin, __InBuffer);
				}
			}
		}

		public FActorOnInputTouchEndSignature OnInputTouchEnd
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnInputTouchEnd, __ReturnBuffer);

					return *(FActorOnInputTouchEndSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnInputTouchEnd, __InBuffer);
				}
			}
		}

		public FActorBeginTouchOverSignature OnInputTouchEnter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnInputTouchEnter, __ReturnBuffer);

					return *(FActorBeginTouchOverSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnInputTouchEnter, __InBuffer);
				}
			}
		}

		public FActorEndTouchOverSignature OnInputTouchLeave
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnInputTouchLeave, __ReturnBuffer);

					return *(FActorEndTouchOverSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnInputTouchLeave, __InBuffer);
				}
			}
		}

		public FActorHitSignature OnActorHit
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnActorHit, __ReturnBuffer);

					return *(FActorHitSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnActorHit, __InBuffer);
				}
			}
		}

		public FActorDestroyedSignature OnDestroyed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnDestroyed, __ReturnBuffer);

					return *(FActorDestroyedSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnDestroyed, __InBuffer);
				}
			}
		}

		public FActorEndPlaySignature OnEndPlay
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnEndPlay, __ReturnBuffer);

					return *(FActorEndPlaySignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnEndPlay, __InBuffer);
				}
			}
		}

		public TArray<UActorComponent> InstanceComponents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InstanceComponents, __ReturnBuffer);

					return *(TArray<UActorComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InstanceComponents, __InBuffer);
				}
			}
		}

		public TArray<UActorComponent> BlueprintCreatedComponents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BlueprintCreatedComponents, __ReturnBuffer);

					return *(TArray<UActorComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BlueprintCreatedComponents, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.Actor");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Tolerance">
		/// How many seconds ago the actor last render time can be and still count as having been "recently" rendered.
		/// </param>
		/// <returns>
		/// Whether this actor was recently rendered.
		/// </returns>
		public virtual bool WasRecentlyRendered(float Tolerance = 0.200000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Tolerance;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __WasRecentlyRendered, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Name used in CreateBlueprint function
		/// </note>
		public virtual void UserConstructionScript()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __UserConstructionScript);
			}
		}

		public virtual void TearOff()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __TearOff);
			}
		}

		/// <param name="NewTickGroup">
		/// the new value to assign
		/// </param>
		public virtual void SetTickGroup(ETickingGroup NewTickGroup)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)NewTickGroup;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTickGroup, __InBuffer);
			}
		}

		public virtual void SetTickableWhenPaused(bool bTickableWhenPaused)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bTickableWhenPaused;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTickableWhenPaused, __InBuffer);
			}
		}

		/// <param name="bInReplicates">
		/// Whether this Actor replicates to network clients.
		/// </param>
		/// <see>
		/// https://docs.unrealengine.com/InteractiveExperiences/Networking/Actors
		/// </see>
		public virtual void SetReplicates(bool bInReplicates)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInReplicates;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetReplicates, __InBuffer);
			}
		}

		/// <param name="bInReplicateMovement">
		/// Whether this Actor's movement replicates to clients.
		/// </param>
		public virtual void SetReplicateMovement(bool bInReplicateMovement)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInReplicateMovement;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetReplicateMovement, __InBuffer);
			}
		}

		public virtual void SetRayTracingGroupId(int InRaytracingGroupId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InRaytracingGroupId;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRayTracingGroupId, __InBuffer);
			}
		}

		public virtual void SetPhysicsReplicationMode(EPhysicsReplicationMode ReplicationMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)ReplicationMode;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPhysicsReplicationMode, __InBuffer);
			}
		}

		/// <param name="NewOwner">
		/// The Actor who takes over ownership of this Actor
		/// </param>
		public virtual void SetOwner(AActor NewOwner)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewOwner?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOwner, __InBuffer);
			}
		}

		public virtual void SetNetDormancy(ENetDormancy NewDormancy)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)NewDormancy;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNetDormancy, __InBuffer);
			}
		}

		public virtual void SetLifeSpan(float InLifespan)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InLifespan;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLifeSpan, __InBuffer);
			}
		}

		/// <param name="bIsHidden">
		/// True if the actor is hidden
		/// </param>
		public virtual void SetIsTemporarilyHiddenInEditor(bool bIsHidden)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIsHidden;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetIsTemporarilyHiddenInEditor, __InBuffer);
			}
		}

		/// <param name="NewFolderPath">
		/// The new folder to assign to the actor.
		/// </param>
		public virtual void SetFolderPath(FName NewFolderPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewFolderPath?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFolderPath, __InBuffer);
			}
		}

		public virtual void SetAutoDestroyWhenFinished(bool bVal)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bVal;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAutoDestroyWhenFinished, __InBuffer);
			}
		}

		/// <param name="TickInterval">
		/// The rate at which this actor should be ticking
		/// </param>
		public virtual void SetActorTickInterval(float TickInterval)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = TickInterval;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetActorTickInterval, __InBuffer);
			}
		}

		/// <param name="bEnabled">
		/// Whether it should be enabled or not
		/// </param>
		public virtual void SetActorTickEnabled(bool bEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetActorTickEnabled, __InBuffer);
			}
		}

		public virtual void SetActorScale3D(FVector NewScale3D)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewScale3D?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetActorScale3D, __InBuffer);
			}
		}

		/// <param name="NewRelativeScale">
		/// New scale to set the actor's RootComponent to
		/// </param>
		public virtual void SetActorRelativeScale3D(FVector NewRelativeScale)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewRelativeScale?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetActorRelativeScale3D, __InBuffer);
			}
		}

		/// <param name="NewActorLabel">
		/// The new label string to assign to the actor.  If empty, the actor will have a default label.
		/// </param>
		/// <param name="bMarkDirty">
		/// If true the actor's package will be marked dirty for saving.  Otherwise it will not be.  You should pass false for this parameter if dirtying is not allowed (like during loads)
		/// </param>
		public virtual void SetActorLabel(FString NewActorLabel, bool bMarkDirty = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = NewActorLabel?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bMarkDirty;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetActorLabel, __InBuffer);
			}
		}

		/// <param name="bNewHidden">
		/// Whether or not to hide the actor and all its components
		/// </param>
		public virtual void SetActorHiddenInGame(bool bNewHidden)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewHidden;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetActorHiddenInGame, __InBuffer);
			}
		}

		public virtual void SetActorEnableCollision(bool bNewActorEnableCollision)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewActorEnableCollision;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetActorEnableCollision, __InBuffer);
			}
		}

		public virtual void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PrerequisiteComponent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveTickPrerequisiteComponent, __InBuffer);
			}
		}

		public virtual void RemoveTickPrerequisiteActor(AActor PrerequisiteActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PrerequisiteActor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveTickPrerequisiteActor, __InBuffer);
			}
		}

		public virtual void ReceiveTick(float DeltaSeconds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = DeltaSeconds;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveTick, __InBuffer);
			}
		}

		public virtual void ReceiveRadialDamage(float DamageReceived, UDamageType DamageType, FVector Origin, FHitResult HitInfo, AController InstigatedBy, AActor DamageCauser)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[44];

				*(float*)(__InBuffer) = DamageReceived;

				*(nint*)(__InBuffer + 4) = DamageType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 12) = Origin?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 20) = HitInfo?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 28) = InstigatedBy?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 36) = DamageCauser?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveRadialDamage, __InBuffer);
			}
		}

		public virtual void ReceivePointDamage(float Damage, UDamageType DamageType, FVector HitLocation, FVector HitNormal, UPrimitiveComponent HitComponent, FName BoneName, FVector ShotFromDirection, AController InstigatedBy, AActor DamageCauser, FHitResult HitInfo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[76];

				*(float*)(__InBuffer) = Damage;

				*(nint*)(__InBuffer + 4) = DamageType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 12) = HitLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 20) = HitNormal?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 28) = HitComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 36) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 44) = ShotFromDirection?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 52) = InstigatedBy?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 60) = DamageCauser?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 68) = HitInfo?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceivePointDamage, __InBuffer);
			}
		}

		/// <note>
		/// For collisions during physics simulation to generate hit events, 'Simulation Generates Hit Events' must be enabled.
		/// </note>
		/// <note>
		/// When receiving a hit from another object's movement (bSelfMoved is false), the directions of 'Hit.Normal' and 'Hit.ImpactNormal'
		/// will be adjusted to indicate force from the other object against this object.
		/// </note>
		/// <note>
		/// NormalImpulse will be filled in for physics-simulating bodies, but will be zero for swept-component blocking collisions.
		/// </note>
		public virtual void ReceiveHit(UPrimitiveComponent MyComp, AActor Other, UPrimitiveComponent OtherComp, bool bSelfMoved, FVector HitLocation, FVector HitNormal, FVector NormalImpulse, FHitResult Hit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[57];

				*(nint*)(__InBuffer) = MyComp?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Other?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OtherComp?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bSelfMoved;

				*(nint*)(__InBuffer + 25) = HitLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 33) = HitNormal?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 41) = NormalImpulse?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 49) = Hit?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveHit, __InBuffer);
			}
		}

		public virtual void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)EndPlayReason;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveEndPlay, __InBuffer);
			}
		}

		public virtual void ReceiveDestroyed()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __ReceiveDestroyed);
			}
		}

		public virtual void ReceiveBeginPlay()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __ReceiveBeginPlay);
			}
		}

		public virtual void ReceiveAsyncPhysicsTick(float DeltaSeconds, float SimSeconds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = DeltaSeconds;

				*(float*)(__InBuffer + 4) = SimSeconds;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveAsyncPhysicsTick, __InBuffer);
			}
		}

		public virtual void ReceiveAnyDamage(float Damage, UDamageType DamageType, AController InstigatedBy, AActor DamageCauser)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(float*)(__InBuffer) = Damage;

				*(nint*)(__InBuffer + 4) = DamageType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 12) = InstigatedBy?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 20) = DamageCauser?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveAnyDamage, __InBuffer);
			}
		}

		public virtual void ReceiveActorOnReleased(FKey ButtonReleased)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ButtonReleased?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveActorOnReleased, __InBuffer);
			}
		}

		public virtual void ReceiveActorOnInputTouchLeave(ETouchIndex FingerIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)FingerIndex;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveActorOnInputTouchLeave, __InBuffer);
			}
		}

		public virtual void ReceiveActorOnInputTouchEnter(ETouchIndex FingerIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)FingerIndex;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveActorOnInputTouchEnter, __InBuffer);
			}
		}

		public virtual void ReceiveActorOnInputTouchEnd(ETouchIndex FingerIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)FingerIndex;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveActorOnInputTouchEnd, __InBuffer);
			}
		}

		public virtual void ReceiveActorOnInputTouchBegin(ETouchIndex FingerIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)FingerIndex;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveActorOnInputTouchBegin, __InBuffer);
			}
		}

		public virtual void ReceiveActorOnClicked(FKey ButtonPressed)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ButtonPressed?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveActorOnClicked, __InBuffer);
			}
		}

		/// <note>
		/// Components on both this and the other Actor must have bGenerateOverlapEvents set to true to generate overlap events.
		/// </note>
		public virtual void ReceiveActorEndOverlap(AActor OtherActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OtherActor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveActorEndOverlap, __InBuffer);
			}
		}

		public virtual void ReceiveActorEndCursorOver()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __ReceiveActorEndCursorOver);
			}
		}

		/// <note>
		/// Components on both this and the other Actor must have bGenerateOverlapEvents set to true to generate overlap events.
		/// </note>
		public virtual void ReceiveActorBeginOverlap(AActor OtherActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OtherActor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveActorBeginOverlap, __InBuffer);
			}
		}

		public virtual void ReceiveActorBeginCursorOver()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __ReceiveActorBeginCursorOver);
			}
		}

		/// <param name="Seconds">
		/// - Number of seconds to force all mip-levels to be resident
		/// </param>
		/// <param name="bEnableStreaming">
		/// - Whether to start (true) or stop (false) streaming
		/// </param>
		/// <param name="CinematicTextureGroups">
		/// - Bitfield indicating which texture groups that use extra high-resolution mips
		/// </param>
		public virtual void PrestreamTextures(float Seconds, bool bEnableStreaming, int CinematicTextureGroups = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(float*)(__InBuffer) = Seconds;

				*(bool*)(__InBuffer + 4) = bEnableStreaming;

				*(int*)(__InBuffer + 5) = CinematicTextureGroups;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __PrestreamTextures, __InBuffer);
			}
		}

		public virtual void OnRep_ReplicateMovement()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_ReplicateMovement);
			}
		}

		public virtual void OnRep_ReplicatedMovement()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_ReplicatedMovement);
			}
		}

		public virtual void OnRep_Owner()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_Owner);
			}
		}

		public virtual void OnRep_Instigator()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_Instigator);
			}
		}

		public virtual void OnRep_AttachmentReplication()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_AttachmentReplication);
			}
		}

		/// <param name="Loudness">
		/// The relative loudness of this noise. Usual range is 0 (no noise) to 1 (full volume). If MaxRange is used, this scales the max range, otherwise it affects the hearing range specified by the sensor.
		/// </param>
		/// <param name="NoiseInstigator">
		/// Pawn responsible for this noise.  Uses the actor's Instigator if NoiseInstigator is null
		/// </param>
		/// <param name="NoiseLocation">
		/// Position of noise source.  If zero vector, use the actor's location.
		/// </param>
		/// <param name="MaxRange">
		/// Max range at which the sound may be heard. A value of 0 indicates no max range (though perception may have its own range). Loudness scales the range. (Note: not supported for legacy PawnSensingComponent, only for AIPerception)
		/// </param>
		/// <param name="Tag">
		/// Identifier for the noise.
		/// </param>
		public virtual void MakeNoise(float Loudness = 1.000000f, APawn NoiseInstigator = null, FVector NoiseLocation = null, float MaxRange = 0.000000f, FName Tag = null)
		{
			unsafe
			{
				NoiseLocation ??= new FVector();

				Tag ??= new FName("None");

				var __InBuffer = stackalloc byte[32];

				*(float*)(__InBuffer) = Loudness;

				*(nint*)(__InBuffer + 4) = NoiseInstigator?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 12) = NoiseLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 20) = MaxRange;

				*(nint*)(__InBuffer + 24) = Tag?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __MakeNoise, __InBuffer);
			}
		}

		/// <param name="DestLocation">
		/// The target destination point
		/// </param>
		/// <param name="DestRotation">
		/// The target rotation at the destination
		/// </param>
		/// <returns>
		/// true if the actor has been successfully moved, or false if it couldn't fit.
		/// </returns>
		public virtual bool K2_TeleportTo(FVector DestLocation, FRotator DestRotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = DestLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DestRotation?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __K2_TeleportTo, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="NewTransform">
		/// The new transform.
		/// </param>
		/// <param name="bSweep">
		/// Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		/// Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// </param>
		/// <param name="bTeleport">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// If CCD is on and not teleporting, this will affect objects along the entire swept volume.
		/// </param>
		public virtual bool K2_SetActorTransform(FTransform NewTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = NewTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSweep;

				*(nint*)(__InBuffer + 9) = SweepHitResult?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __K2_SetActorTransform, __InBuffer, __OutBuffer, __ReturnBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="NewRotation">
		/// The new rotation for the Actor.
		/// </param>
		/// <param name="bTeleportPhysics">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// </param>
		/// <returns>
		/// Whether the rotation was successfully set.
		/// </returns>
		public virtual bool K2_SetActorRotation(FRotator NewRotation, bool bTeleportPhysics)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = NewRotation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bTeleportPhysics;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __K2_SetActorRotation, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="NewRelativeTransform">
		/// New relative transform of the actor's root component
		/// </param>
		/// <param name="bSweep">
		/// Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		/// Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// </param>
		/// <param name="bTeleport">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// If CCD is on and not teleporting, this will affect objects along the entire swept volume.
		/// </param>
		public virtual void K2_SetActorRelativeTransform(FTransform NewRelativeTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = NewRelativeTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSweep;

				*(nint*)(__InBuffer + 9) = SweepHitResult?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_SetActorRelativeTransform, __InBuffer, __OutBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

			}
		}

		/// <param name="NewRelativeRotation">
		/// New relative rotation of the actor's root component
		/// </param>
		/// <param name="bSweep">
		/// Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		/// Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// </param>
		/// <param name="bTeleport">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// If CCD is on and not teleporting, this will affect objects along the entire swept volume.
		/// </param>
		public virtual void K2_SetActorRelativeRotation(FRotator NewRelativeRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = NewRelativeRotation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSweep;

				*(nint*)(__InBuffer + 9) = SweepHitResult?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_SetActorRelativeRotation, __InBuffer, __OutBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

			}
		}

		/// <param name="NewRelativeLocation">
		/// New relative location of the actor's root component
		/// </param>
		/// <param name="bSweep">
		/// Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		/// Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// </param>
		/// <param name="bTeleport">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// If CCD is on and not teleporting, this will affect objects along the entire swept volume.
		/// </param>
		public virtual void K2_SetActorRelativeLocation(FVector NewRelativeLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = NewRelativeLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSweep;

				*(nint*)(__InBuffer + 9) = SweepHitResult?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_SetActorRelativeLocation, __InBuffer, __OutBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

			}
		}

		/// <param name="NewLocation">
		/// The new location to teleport the Actor to.
		/// </param>
		/// <param name="NewRotation">
		/// The new rotation for the Actor.
		/// </param>
		/// <param name="bSweep">
		/// Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		/// Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// </param>
		/// <param name="bTeleport">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// If CCD is on and not teleporting, this will affect objects along the entire swept volume.
		/// </param>
		/// <param name="SweepHitResult">
		/// The hit result from the move if swept.
		/// </param>
		/// <returns>
		/// Whether the rotation was successfully set.
		/// </returns>
		public virtual bool K2_SetActorLocationAndRotation(FVector NewLocation, FRotator NewRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = NewLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewRotation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSweep;

				*(nint*)(__InBuffer + 17) = SweepHitResult?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 25) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __K2_SetActorLocationAndRotation, __InBuffer, __OutBuffer, __ReturnBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="NewLocation">
		/// The new location to move the Actor to.
		/// </param>
		/// <param name="bSweep">
		/// Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		/// Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// </param>
		/// <param name="bTeleport">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// If CCD is on and not teleporting, this will affect objects along the entire swept volume.
		/// </param>
		/// <param name="SweepHitResult">
		/// The hit result from the move if swept.
		/// </param>
		/// <returns>
		/// Whether the location was successfully set (if not swept), or whether movement occurred at all (if swept).
		/// </returns>
		public virtual bool K2_SetActorLocation(FVector NewLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = NewLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSweep;

				*(nint*)(__InBuffer + 9) = SweepHitResult?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __K2_SetActorLocation, __InBuffer, __OutBuffer, __ReturnBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void K2_OnReset()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __K2_OnReset);
			}
		}

		public virtual void K2_OnEndViewTarget(APlayerController PC)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PC?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __K2_OnEndViewTarget, __InBuffer);
			}
		}

		public virtual void K2_OnBecomeViewTarget(APlayerController PC)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PC?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __K2_OnBecomeViewTarget, __InBuffer);
			}
		}

		public virtual USceneComponent K2_GetRootComponent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __K2_GetRootComponent, __ReturnBuffer);

				return *(USceneComponent*)__ReturnBuffer;
			}
		}

		public virtual TArray<UActorComponent> K2_GetComponentsByClass(TSubclassOf<UActorComponent> ComponentClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ComponentClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __K2_GetComponentsByClass, __InBuffer, __ReturnBuffer);

				return *(TArray<UActorComponent>*)__ReturnBuffer;
			}
		}

		public virtual FRotator K2_GetActorRotation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __K2_GetActorRotation, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public virtual FVector K2_GetActorLocation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __K2_GetActorLocation, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="LocationRule">
		/// How to handle translation when detaching.
		/// </param>
		/// <param name="RotationRule">
		/// How to handle rotation when detaching.
		/// </param>
		/// <param name="ScaleRule">
		/// How to handle scale when detaching.
		/// </param>
		public virtual void K2_DetachFromActor(EDetachmentRule LocationRule = EDetachmentRule.KeepRelative, EDetachmentRule RotationRule = EDetachmentRule.KeepRelative, EDetachmentRule ScaleRule = EDetachmentRule.KeepRelative)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[3];

				*(byte*)(__InBuffer) = (byte)LocationRule;

				*(byte*)(__InBuffer + 1) = (byte)RotationRule;

				*(byte*)(__InBuffer + 2) = (byte)ScaleRule;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __K2_DetachFromActor, __InBuffer);
			}
		}

		public virtual void K2_DestroyActor()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __K2_DestroyActor);
			}
		}

		/// <param name="Parent">
		/// Parent to attach to.
		/// </param>
		/// <param name="SocketName">
		/// Optional socket to attach to on the parent.
		/// </param>
		/// <param name="LocationRule">
		/// How to handle translation when attaching.
		/// </param>
		/// <param name="RotationRule">
		/// How to handle rotation when attaching.
		/// </param>
		/// <param name="ScaleRule">
		/// How to handle scale when attaching.
		/// </param>
		/// <param name="bWeldSimulatedBodies">
		/// Whether to weld together simulated physics bodies.
		/// </param>
		/// <returns>
		/// Whether the attachment was successful or not
		/// </returns>
		public virtual bool K2_AttachToComponent(USceneComponent Parent, FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Parent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SocketName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)LocationRule;

				*(byte*)(__InBuffer + 17) = (byte)RotationRule;

				*(byte*)(__InBuffer + 18) = (byte)ScaleRule;

				*(bool*)(__InBuffer + 19) = bWeldSimulatedBodies;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __K2_AttachToComponent, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="ParentActor">
		/// Actor to attach this actor's RootComponent to
		/// </param>
		/// <param name="SocketName">
		/// Socket name to attach to, if any
		/// </param>
		/// <param name="LocationRule">
		/// How to handle translation when attaching.
		/// </param>
		/// <param name="RotationRule">
		/// How to handle rotation when attaching.
		/// </param>
		/// <param name="ScaleRule">
		/// How to handle scale when attaching.
		/// </param>
		/// <param name="bWeldSimulatedBodies">
		/// Whether to weld together simulated physics bodies.
		/// </param>
		/// <returns>
		/// Whether the attachment was successful or not
		/// </returns>
		public virtual bool K2_AttachToActor(AActor ParentActor, FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = ParentActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SocketName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)LocationRule;

				*(byte*)(__InBuffer + 17) = (byte)RotationRule;

				*(byte*)(__InBuffer + 18) = (byte)ScaleRule;

				*(bool*)(__InBuffer + 19) = bWeldSimulatedBodies;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __K2_AttachToActor, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void K2_AttachRootComponentToActor(AActor InParentActor, FName InSocketName = null, EAttachLocation AttachLocationType = EAttachLocation.KeepRelativeOffset, bool bWeldSimulatedBodies = true)
		{
			unsafe
			{
				InSocketName ??= new FName("None");

				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = InParentActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSocketName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)AttachLocationType;

				*(bool*)(__InBuffer + 17) = bWeldSimulatedBodies;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __K2_AttachRootComponentToActor, __InBuffer);
			}
		}

		public virtual void K2_AttachRootComponentTo(USceneComponent InParent, FName InSocketName = null, EAttachLocation AttachLocationType = EAttachLocation.KeepRelativeOffset, bool bWeldSimulatedBodies = true)
		{
			unsafe
			{
				InSocketName ??= new FName("None");

				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = InParent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSocketName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)AttachLocationType;

				*(bool*)(__InBuffer + 17) = bWeldSimulatedBodies;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __K2_AttachRootComponentTo, __InBuffer);
			}
		}

		public virtual void K2_AddActorWorldTransformKeepScale(FTransform DeltaTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = DeltaTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSweep;

				*(nint*)(__InBuffer + 9) = SweepHitResult?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_AddActorWorldTransformKeepScale, __InBuffer, __OutBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

			}
		}

		public virtual void K2_AddActorWorldTransform(FTransform DeltaTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = DeltaTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSweep;

				*(nint*)(__InBuffer + 9) = SweepHitResult?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_AddActorWorldTransform, __InBuffer, __OutBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

			}
		}

		/// <param name="DeltaRotation">
		/// The change in rotation.
		/// </param>
		/// <param name="bSweep">
		/// Whether to sweep to the target rotation (not currently supported for rotation).
		/// </param>
		/// <param name="bTeleport">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// If CCD is on and not teleporting, this will affect objects along the entire swept volume.
		/// </param>
		/// <param name="SweepHitResult">
		/// The hit result from the move if swept.
		/// </param>
		public virtual void K2_AddActorWorldRotation(FRotator DeltaRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = DeltaRotation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSweep;

				*(nint*)(__InBuffer + 9) = SweepHitResult?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_AddActorWorldRotation, __InBuffer, __OutBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

			}
		}

		/// <param name="DeltaLocation">
		/// The change in location.
		/// </param>
		/// <param name="bSweep">
		/// Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		/// Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// </param>
		/// <param name="bTeleport">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// If CCD is on and not teleporting, this will affect objects along the entire swept volume.
		/// </param>
		/// <param name="SweepHitResult">
		/// The hit result from the move if swept.
		/// </param>
		public virtual void K2_AddActorWorldOffset(FVector DeltaLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = DeltaLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSweep;

				*(nint*)(__InBuffer + 9) = SweepHitResult?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_AddActorWorldOffset, __InBuffer, __OutBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

			}
		}

		/// <param name="NewTransform">
		/// The change in transform in local space.
		/// </param>
		/// <param name="bSweep">
		/// Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		/// Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// </param>
		/// <param name="bTeleport">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// If CCD is on and not teleporting, this will affect objects along the entire swept volume.
		/// </param>
		public virtual void K2_AddActorLocalTransform(FTransform NewTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = NewTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSweep;

				*(nint*)(__InBuffer + 9) = SweepHitResult?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_AddActorLocalTransform, __InBuffer, __OutBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

			}
		}

		/// <param name="DeltaRotation">
		/// The change in rotation in local space.
		/// </param>
		/// <param name="bSweep">
		/// Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		/// Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// </param>
		/// <param name="bTeleport">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// If CCD is on and not teleporting, this will affect objects along the entire swept volume.
		/// </param>
		public virtual void K2_AddActorLocalRotation(FRotator DeltaRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = DeltaRotation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSweep;

				*(nint*)(__InBuffer + 9) = SweepHitResult?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_AddActorLocalRotation, __InBuffer, __OutBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

			}
		}

		/// <param name="DelatLocation">
		/// The change in location in local space.
		/// </param>
		/// <param name="bSweep">
		/// Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		/// Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// </param>
		/// <param name="bTeleport">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// If CCD is on and not teleporting, this will affect objects along the entire swept volume.
		/// </param>
		public virtual void K2_AddActorLocalOffset(FVector DeltaLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = DeltaLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSweep;

				*(nint*)(__InBuffer + 9) = SweepHitResult?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_AddActorLocalOffset, __InBuffer, __OutBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

			}
		}

		/// <param name="bIncludeParent">
		/// - Whether to recurse up child actor hierarchy or not
		/// </param>
		public virtual bool IsTemporarilyHiddenInEditor(bool bIncludeParent = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIncludeParent;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsTemporarilyHiddenInEditor, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsSelectable()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsSelectable, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Other">
		/// The other Actor to test against
		/// </param>
		/// <returns>
		/// Whether any component of this Actor is overlapping any component of another Actor.
		/// </returns>
		public virtual bool IsOverlappingActor(AActor Other)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Other?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsOverlappingActor, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsHiddenEdAtStartup()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsHiddenEdAtStartup, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsHiddenEd()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsHiddenEd, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsEditable()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsEditable, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsChildActor()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsChildActor, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsActorTickEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsActorTickEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsActorBeingDestroyed()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsActorBeingDestroyed, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool HasAuthority()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __HasAuthority, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual float GetVerticalDistanceTo(AActor OtherActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OtherActor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetVerticalDistanceTo, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FVector GetVelocity()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetVelocity, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The transform that transforms from actor space to world space.
		/// </returns>
		public virtual FTransform GetTransform()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetTransform, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public virtual bool GetTickableWhenPaused()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetTickableWhenPaused, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual float GetSquaredHorizontalDistanceTo(AActor OtherActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OtherActor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetSquaredHorizontalDistanceTo, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetSquaredDistanceTo(AActor OtherActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OtherActor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetSquaredDistanceTo, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetResimulationThreshold()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetResimulationThreshold, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual ENetRole GetRemoteRole()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetRemoteRole, __ReturnBuffer);

				return *(ENetRole*)__ReturnBuffer;
			}
		}

		public virtual int GetRayTracingGroupId()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetRayTracingGroupId, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual EPhysicsReplicationMode GetPhysicsReplicationMode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPhysicsReplicationMode, __ReturnBuffer);

				return *(EPhysicsReplicationMode*)__ReturnBuffer;
			}
		}

		public virtual UChildActorComponent GetParentComponent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetParentComponent, __ReturnBuffer);

				return *(UChildActorComponent*)__ReturnBuffer;
			}
		}

		public virtual AActor GetParentActor()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetParentActor, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		public virtual AActor GetOwner()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetOwner, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		public virtual void GetOverlappingComponents(ref TArray<UPrimitiveComponent> OverlappingComponents)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OverlappingComponents?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetOverlappingComponents, __InBuffer, __OutBuffer);

				OverlappingComponents = *(TArray<UPrimitiveComponent>*)(__OutBuffer);

			}
		}

		/// <param name="OverlappingActors">
		/// [out] Returned list of overlapping actors
		/// </param>
		/// <param name="ClassFilter">
		/// [optional] If set, only returns actors of this class or subclasses
		/// </param>
		public virtual void GetOverlappingActors(ref TArray<AActor> OverlappingActors, TSubclassOf<AActor> ClassFilter = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OverlappingActors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ClassFilter?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetOverlappingActors, __InBuffer, __OutBuffer);

				OverlappingActors = *(TArray<AActor>*)(__OutBuffer);

			}
		}

		public virtual ENetRole GetLocalRole()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetLocalRole, __ReturnBuffer);

				return *(ENetRole*)__ReturnBuffer;
			}
		}

		public virtual float GetLifeSpan()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetLifeSpan, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FTransform GetLevelTransform()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLevelTransform, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public virtual ULevel GetLevel()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLevel, __ReturnBuffer);

				return *(ULevel*)__ReturnBuffer;
			}
		}

		public virtual AController GetInstigatorController()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetInstigatorController, __ReturnBuffer);

				return *(AController*)__ReturnBuffer;
			}
		}

		public virtual APawn GetInstigator()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetInstigator, __ReturnBuffer);

				return *(APawn*)__ReturnBuffer;
			}
		}

		public virtual FVector GetInputVectorAxisValue(FKey InputAxisKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InputAxisKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetInputVectorAxisValue, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual float GetInputAxisValue(FName InputAxisName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InputAxisName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetInputAxisValue, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetInputAxisKeyValue(FKey InputAxisKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InputAxisKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetInputAxisKeyValue, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetHorizontalDotProductTo(AActor OtherActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OtherActor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetHorizontalDotProductTo, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetHorizontalDistanceTo(AActor OtherActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OtherActor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetHorizontalDistanceTo, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetGameTimeSinceCreation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetGameTimeSinceCreation, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FName GetFolderPath()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetFolderPath, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual float GetDotProductTo(AActor OtherActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OtherActor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetDotProductTo, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetDistanceTo(AActor OtherActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OtherActor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetDistanceTo, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FString GetDefaultActorLabel()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDefaultActorLabel, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual TArray<UActorComponent> GetComponentsByTag(TSubclassOf<UActorComponent> ComponentClass, FName Tag)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ComponentClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Tag?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetComponentsByTag, __InBuffer, __ReturnBuffer);

				return *(TArray<UActorComponent>*)__ReturnBuffer;
			}
		}

		public virtual TArray<UActorComponent> GetComponentsByInterface(TSubclassOf<UInterface> Interface)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Interface?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetComponentsByInterface, __InBuffer, __ReturnBuffer);

				return *(TArray<UActorComponent>*)__ReturnBuffer;
			}
		}

		public virtual UActorComponent GetComponentByClass(TSubclassOf<UActorComponent> ComponentClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ComponentClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetComponentByClass, __InBuffer, __ReturnBuffer);

				return *(UActorComponent*)__ReturnBuffer;
			}
		}

		public virtual FName GetAttachParentSocketName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAttachParentSocketName, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual AActor GetAttachParentActor()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAttachParentActor, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		public virtual void GetAttachedActors(ref TArray<AActor> OutActors, bool bResetArray = true, bool bRecursivelyIncludeAttachedActors = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = OutActors?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bResetArray;

				*(bool*)(__InBuffer + 9) = bRecursivelyIncludeAttachedActors;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetAttachedActors, __InBuffer, __OutBuffer);

				OutActors = *(TArray<AActor>*)(__OutBuffer);

			}
		}

		public virtual void GetAllChildActors(ref TArray<AActor> ChildActors, bool bIncludeDescendants = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = ChildActors?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIncludeDescendants;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetAllChildActors, __InBuffer, __OutBuffer);

				ChildActors = *(TArray<AActor>*)(__OutBuffer);

			}
		}

		public virtual FVector GetActorUpVector()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetActorUpVector, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual float GetActorTimeDilation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetActorTimeDilation, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetActorTickInterval()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetActorTickInterval, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FVector GetActorScale3D()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetActorScale3D, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetActorRightVector()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetActorRightVector, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetActorRelativeScale3D()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetActorRelativeScale3D, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FString GetActorLabel(bool bCreateIfNone = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bCreateIfNone;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetActorLabel, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual FVector GetActorForwardVector()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetActorForwardVector, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="OutLocation">
		/// - location of view point
		/// </param>
		/// <param name="OutRotation">
		/// - view rotation of actor.
		/// </param>
		public virtual void GetActorEyesViewPoint(ref FVector OutLocation, ref FRotator OutRotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OutLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutRotation?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetActorEyesViewPoint, __InBuffer, __OutBuffer);

				OutLocation = *(FVector*)(__OutBuffer);

				OutRotation = *(FRotator*)(__OutBuffer + 8);

			}
		}

		public virtual bool GetActorEnableCollision()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetActorEnableCollision, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="bOnlyCollidingComponents">
		/// If true, will only return the bounding box for components with collision enabled.
		/// </param>
		/// <param name="Origin">
		/// Set to the center of the actor in world space
		/// </param>
		/// <param name="BoxExtent">
		/// Set to half the actor's size in 3d space
		/// </param>
		/// <param name="bIncludeFromChildActors">
		/// If true then recurse in to ChildActor components 
		/// </param>
		public virtual void GetActorBounds(bool bOnlyCollidingComponents, ref FVector Origin, ref FVector BoxExtent, bool bIncludeFromChildActors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(bool*)(__InBuffer) = bOnlyCollidingComponents;

				*(nint*)(__InBuffer + 1) = Origin?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 9) = BoxExtent?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bIncludeFromChildActors;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetActorBounds, __InBuffer, __OutBuffer);

				Origin = *(FVector*)(__OutBuffer);

				BoxExtent = *(FVector*)(__OutBuffer + 8);

			}
		}

		public virtual void ForceNetUpdate()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ForceNetUpdate);
			}
		}

		public virtual void FlushNetDormancy()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __FlushNetDormancy);
			}
		}

		/// <see>
		/// UK2Node_AddComponent	DO NOT CALL MANUALLY - BLUEPRINT INTERNAL USE ONLY (for Add Component nodes)
		/// </see>
		/// <param name="Component">
		/// The component created in AddComponent to finish creation of
		/// </param>
		/// <param name="bManualAttachment">
		/// Whether manual or automatic attachment is to be used
		/// </param>
		/// <param name="RelativeTransform">
		/// The relative transform between the new component and its attach parent (automatic only)
		/// </param>
		public virtual void FinishAddComponent(UActorComponent Component, bool bManualAttachment, FTransform RelativeTransform)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bManualAttachment;

				*(nint*)(__InBuffer + 9) = RelativeTransform?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __FinishAddComponent, __InBuffer);
			}
		}

		public virtual UActorComponent FindComponentByTag(TSubclassOf<UActorComponent> ComponentClass, FName Tag)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ComponentClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Tag?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindComponentByTag, __InBuffer, __ReturnBuffer);

				return *(UActorComponent*)__ReturnBuffer;
			}
		}

		/// <param name="PlayerController">
		/// The PlayerController whose input events we want to receive.
		/// </param>
		public virtual void EnableInput(APlayerController PlayerController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __EnableInput, __InBuffer);
			}
		}

		/// <param name="PlayerController">
		/// The PlayerController whose input events we no longer want to receive. If null, this actor will stop receiving input from all PlayerControllers.
		/// </param>
		public virtual void DisableInput(APlayerController PlayerController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DisableInput, __InBuffer);
			}
		}

		public virtual void DetachRootComponentFromParent(bool bMaintainWorldPosition = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bMaintainWorldPosition;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DetachRootComponentFromParent, __InBuffer);
			}
		}

		/// <param name="InputComponentToCreate">
		/// The UInputComponent to create.
		/// </param>
		public virtual void CreateInputComponent(TSubclassOf<UInputComponent> InputComponentToCreate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InputComponentToCreate?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __CreateInputComponent, __InBuffer);
			}
		}

		public virtual bool CanTriggerResimulation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __CanTriggerResimulation, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PrerequisiteComponent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddTickPrerequisiteComponent, __InBuffer);
			}
		}

		public virtual void AddTickPrerequisiteActor(AActor PrerequisiteActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PrerequisiteActor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddTickPrerequisiteActor, __InBuffer);
			}
		}

		/// <see>
		/// UK2Node_AddComponentByClass		DO NOT CALL MANUALLY - BLUEPRINT INTERNAL USE ONLY (for Add Component nodes)
		/// </see>
		/// <param name="Class">
		/// The class of component to create
		/// </param>
		/// <param name="bManualAttachment">
		/// Whether manual or automatic attachment is to be used
		/// </param>
		/// <param name="RelativeTransform">
		/// The relative transform between the new component and its attach parent (automatic only)
		/// </param>
		/// <param name="bDeferredFinish">
		/// Whether or not to immediately complete the creation and registration process for this component. Will be false if there are expose on spawn properties being set
		/// </param>
		public virtual UActorComponent AddComponentByClass(TSubclassOf<UActorComponent> Class, bool bManualAttachment, FTransform RelativeTransform, bool bDeferredFinish)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = Class?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bManualAttachment;

				*(nint*)(__InBuffer + 9) = RelativeTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bDeferredFinish;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddComponentByClass, __InBuffer, __ReturnBuffer);

				return *(UActorComponent*)__ReturnBuffer;
			}
		}

		/// <see>
		/// UK2Node_AddComponent	DO NOT CALL MANUALLY - BLUEPRINT INTERNAL USE ONLY (for Add Component nodes)
		/// </see>
		/// <param name="TemplateName">
		/// The name of the Component Template to use.
		/// </param>
		/// <param name="bManualAttachment">
		/// Whether manual or automatic attachment is to be used
		/// </param>
		/// <param name="RelativeTransform">
		/// The relative transform between the new component and its attach parent (automatic only)
		/// </param>
		/// <param name="ComponentTemplateContext">
		/// Optional UBlueprintGeneratedClass reference to use to find the template in. If null (or not a BPGC), component is sought in this Actor's class
		/// </param>
		/// <param name="bDeferredFinish">
		/// Whether or not to immediately complete the creation and registration process for this component. Will be false if there are expose on spawn properties being set
		/// </param>
		public virtual UActorComponent AddComponent(FName TemplateName, bool bManualAttachment, FTransform RelativeTransform, UObject ComponentTemplateContext, bool bDeferredFinish = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = TemplateName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bManualAttachment;

				*(nint*)(__InBuffer + 9) = RelativeTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 17) = ComponentTemplateContext?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 25) = bDeferredFinish;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddComponent, __InBuffer, __ReturnBuffer);

				return *(UActorComponent*)__ReturnBuffer;
			}
		}

		public virtual bool ActorHasTag(FName Tag)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Tag?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ActorHasTag, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __PrimaryActorTick = 0;

		private static uint __bNetTemporary = 0;

		private static uint __bOnlyRelevantToOwner = 0;

		private static uint __bAlwaysRelevant = 0;

		private static uint __bReplicateMovement = 0;

		private static uint __bCallPreReplication = 0;

		private static uint __bCallPreReplicationForReplay = 0;

		private static uint __bHidden = 0;

		private static uint __bTearOff = 0;

		private static uint __bForceNetAddressable = 0;

		private static uint __bIsInEditingLevelInstance = 0;

		private static uint __bIsMainWorldOnly = 0;

		private static uint __bExchangedRoles = 0;

		private static uint __bNetLoadOnClient = 0;

		private static uint __bNetUseOwnerRelevancy = 0;

		private static uint __bRelevantForNetworkReplays = 0;

		private static uint __bRelevantForLevelBounds = 0;

		private static uint __bReplayRewindable = 0;

		private static uint __bAllowTickBeforeBeginPlay = 0;

		private static uint __bAutoDestroyWhenFinished = 0;

		private static uint __bCanBeDamaged = 0;

		private static uint __bBlockInput = 0;

		private static uint __bCollideWhenPlacing = 0;

		private static uint __bFindCameraComponentWhenViewTarget = 0;

		private static uint __bGenerateOverlapEventsDuringLevelStreaming = 0;

		private static uint __bIgnoresOriginShifting = 0;

		private static uint __bEnableAutoLODGeneration = 0;

		private static uint __bIsEditorOnlyActor = 0;

		private static uint __bActorSeamlessTraveled = 0;

		private static uint __bReplicates = 0;

		private static uint __bCanBeInCluster = 0;

		private static uint __bAllowReceiveTickEventOnDedicatedServer = 0;

		private static uint __bReplicateUsingRegisteredSubObjectList = 0;

		private static uint __bActorEnableCollision = 0;

		private static uint __bActorIsBeingDestroyed = 0;

		private static uint __bAsyncPhysicsTickEnabled = 0;

		private static uint __UpdateOverlapsMethodDuringLevelStreaming = 0;

		private static uint __DefaultUpdateOverlapsMethodDuringLevelStreaming = 0;

		private static uint __InitialLifeSpan = 0;

		private static uint __CustomTimeDilation = 0;

		private static uint __RemoteRole = 0;

		private static uint __RayTracingGroupId = 0;

		private static uint __RuntimeGrid = 0;

		private static uint __AttachmentReplication = 0;

		private static uint __ReplicatedMovement = 0;

		private static uint __Owner = 0;

		private static uint __NetDriverName = 0;

		private static uint __Role = 0;

		private static uint __NetDormancy = 0;

		private static uint __SpawnCollisionHandlingMethod = 0;

		private static uint __AutoReceiveInput = 0;

		private static uint __InputPriority = 0;

		private static uint __InputComponent = 0;

		private static uint __NetCullDistanceSquared = 0;

		private static uint __NetTag = 0;

		private static uint __NetUpdateFrequency = 0;

		private static uint __MinNetUpdateFrequency = 0;

		private static uint __NetPriority = 0;

		private static uint __PhysicsReplicationMode = 0;

		private static uint __Instigator = 0;

		private static uint __Children = 0;

		private static uint __RootComponent = 0;

		private static uint __PivotOffset = 0;

		private static uint __HLODLayer = 0;

		private static uint __Layers = 0;

		private static uint __ParentComponent = 0;

		private static uint __ActorGuid = 0;

		private static uint __ActorInstanceGuid = 0;

		private static uint __ContentBundleGuid = 0;

		private static uint __DataLayers = 0;

		private static uint __DataLayerAssets = 0;

		private static uint __GroupActor = 0;

		private static uint __SpriteScale = 0;

		private static uint __HiddenEditorViews = 0;

		private static uint __ActorLabel = 0;

		private static uint __FolderPath = 0;

		private static uint __FolderGuid = 0;

		private static uint __bHiddenEd = 0;

		private static uint __bIsEditorPreviewActor = 0;

		private static uint __bHiddenEdLayer = 0;

		private static uint __bHiddenEdLevel = 0;

		private static uint __bLockLocation = 0;

		private static uint __bActorLabelEditable = 0;

		private static uint __bEditable = 0;

		private static uint __bListedInSceneOutliner = 0;

		private static uint __bOptimizeBPComponentData = 0;

		private static uint __bCanPlayFromHere = 0;

		private static uint __bIsSpatiallyLoaded = 0;

		private static uint __bHiddenEdTemporary = 0;

		private static uint __bForceExternalActorLevelReferenceForPIE = 0;

		private static uint __Tags = 0;

		private static uint __OnTakeAnyDamage = 0;

		private static uint __OnTakePointDamage = 0;

		private static uint __OnTakeRadialDamage = 0;

		private static uint __OnActorBeginOverlap = 0;

		private static uint __OnActorEndOverlap = 0;

		private static uint __OnBeginCursorOver = 0;

		private static uint __OnEndCursorOver = 0;

		private static uint __OnClicked = 0;

		private static uint __OnReleased = 0;

		private static uint __OnInputTouchBegin = 0;

		private static uint __OnInputTouchEnd = 0;

		private static uint __OnInputTouchEnter = 0;

		private static uint __OnInputTouchLeave = 0;

		private static uint __OnActorHit = 0;

		private static uint __OnDestroyed = 0;

		private static uint __OnEndPlay = 0;

		private static uint __InstanceComponents = 0;

		private static uint __BlueprintCreatedComponents = 0;

		private static uint __WasRecentlyRendered = 0;

		private static uint __UserConstructionScript = 0;

		private static uint __TearOff = 0;

		private static uint __SetTickGroup = 0;

		private static uint __SetTickableWhenPaused = 0;

		private static uint __SetReplicates = 0;

		private static uint __SetReplicateMovement = 0;

		private static uint __SetRayTracingGroupId = 0;

		private static uint __SetPhysicsReplicationMode = 0;

		private static uint __SetOwner = 0;

		private static uint __SetNetDormancy = 0;

		private static uint __SetLifeSpan = 0;

		private static uint __SetIsTemporarilyHiddenInEditor = 0;

		private static uint __SetFolderPath = 0;

		private static uint __SetAutoDestroyWhenFinished = 0;

		private static uint __SetActorTickInterval = 0;

		private static uint __SetActorTickEnabled = 0;

		private static uint __SetActorScale3D = 0;

		private static uint __SetActorRelativeScale3D = 0;

		private static uint __SetActorLabel = 0;

		private static uint __SetActorHiddenInGame = 0;

		private static uint __SetActorEnableCollision = 0;

		private static uint __RemoveTickPrerequisiteComponent = 0;

		private static uint __RemoveTickPrerequisiteActor = 0;

		private static uint __ReceiveTick = 0;

		private static uint __ReceiveRadialDamage = 0;

		private static uint __ReceivePointDamage = 0;

		private static uint __ReceiveHit = 0;

		private static uint __ReceiveEndPlay = 0;

		private static uint __ReceiveDestroyed = 0;

		private static uint __ReceiveBeginPlay = 0;

		private static uint __ReceiveAsyncPhysicsTick = 0;

		private static uint __ReceiveAnyDamage = 0;

		private static uint __ReceiveActorOnReleased = 0;

		private static uint __ReceiveActorOnInputTouchLeave = 0;

		private static uint __ReceiveActorOnInputTouchEnter = 0;

		private static uint __ReceiveActorOnInputTouchEnd = 0;

		private static uint __ReceiveActorOnInputTouchBegin = 0;

		private static uint __ReceiveActorOnClicked = 0;

		private static uint __ReceiveActorEndOverlap = 0;

		private static uint __ReceiveActorEndCursorOver = 0;

		private static uint __ReceiveActorBeginOverlap = 0;

		private static uint __ReceiveActorBeginCursorOver = 0;

		private static uint __PrestreamTextures = 0;

		private static uint __OnRep_ReplicateMovement = 0;

		private static uint __OnRep_ReplicatedMovement = 0;

		private static uint __OnRep_Owner = 0;

		private static uint __OnRep_Instigator = 0;

		private static uint __OnRep_AttachmentReplication = 0;

		private static uint __MakeNoise = 0;

		private static uint __K2_TeleportTo = 0;

		private static uint __K2_SetActorTransform = 0;

		private static uint __K2_SetActorRotation = 0;

		private static uint __K2_SetActorRelativeTransform = 0;

		private static uint __K2_SetActorRelativeRotation = 0;

		private static uint __K2_SetActorRelativeLocation = 0;

		private static uint __K2_SetActorLocationAndRotation = 0;

		private static uint __K2_SetActorLocation = 0;

		private static uint __K2_OnReset = 0;

		private static uint __K2_OnEndViewTarget = 0;

		private static uint __K2_OnBecomeViewTarget = 0;

		private static uint __K2_GetRootComponent = 0;

		private static uint __K2_GetComponentsByClass = 0;

		private static uint __K2_GetActorRotation = 0;

		private static uint __K2_GetActorLocation = 0;

		private static uint __K2_DetachFromActor = 0;

		private static uint __K2_DestroyActor = 0;

		private static uint __K2_AttachToComponent = 0;

		private static uint __K2_AttachToActor = 0;

		private static uint __K2_AttachRootComponentToActor = 0;

		private static uint __K2_AttachRootComponentTo = 0;

		private static uint __K2_AddActorWorldTransformKeepScale = 0;

		private static uint __K2_AddActorWorldTransform = 0;

		private static uint __K2_AddActorWorldRotation = 0;

		private static uint __K2_AddActorWorldOffset = 0;

		private static uint __K2_AddActorLocalTransform = 0;

		private static uint __K2_AddActorLocalRotation = 0;

		private static uint __K2_AddActorLocalOffset = 0;

		private static uint __IsTemporarilyHiddenInEditor = 0;

		private static uint __IsSelectable = 0;

		private static uint __IsOverlappingActor = 0;

		private static uint __IsHiddenEdAtStartup = 0;

		private static uint __IsHiddenEd = 0;

		private static uint __IsEditable = 0;

		private static uint __IsChildActor = 0;

		private static uint __IsActorTickEnabled = 0;

		private static uint __IsActorBeingDestroyed = 0;

		private static uint __HasAuthority = 0;

		private static uint __GetVerticalDistanceTo = 0;

		private static uint __GetVelocity = 0;

		private static uint __GetTransform = 0;

		private static uint __GetTickableWhenPaused = 0;

		private static uint __GetSquaredHorizontalDistanceTo = 0;

		private static uint __GetSquaredDistanceTo = 0;

		private static uint __GetResimulationThreshold = 0;

		private static uint __GetRemoteRole = 0;

		private static uint __GetRayTracingGroupId = 0;

		private static uint __GetPhysicsReplicationMode = 0;

		private static uint __GetParentComponent = 0;

		private static uint __GetParentActor = 0;

		private static uint __GetOwner = 0;

		private static uint __GetOverlappingComponents = 0;

		private static uint __GetOverlappingActors = 0;

		private static uint __GetLocalRole = 0;

		private static uint __GetLifeSpan = 0;

		private static uint __GetLevelTransform = 0;

		private static uint __GetLevel = 0;

		private static uint __GetInstigatorController = 0;

		private static uint __GetInstigator = 0;

		private static uint __GetInputVectorAxisValue = 0;

		private static uint __GetInputAxisValue = 0;

		private static uint __GetInputAxisKeyValue = 0;

		private static uint __GetHorizontalDotProductTo = 0;

		private static uint __GetHorizontalDistanceTo = 0;

		private static uint __GetGameTimeSinceCreation = 0;

		private static uint __GetFolderPath = 0;

		private static uint __GetDotProductTo = 0;

		private static uint __GetDistanceTo = 0;

		private static uint __GetDefaultActorLabel = 0;

		private static uint __GetComponentsByTag = 0;

		private static uint __GetComponentsByInterface = 0;

		private static uint __GetComponentByClass = 0;

		private static uint __GetAttachParentSocketName = 0;

		private static uint __GetAttachParentActor = 0;

		private static uint __GetAttachedActors = 0;

		private static uint __GetAllChildActors = 0;

		private static uint __GetActorUpVector = 0;

		private static uint __GetActorTimeDilation = 0;

		private static uint __GetActorTickInterval = 0;

		private static uint __GetActorScale3D = 0;

		private static uint __GetActorRightVector = 0;

		private static uint __GetActorRelativeScale3D = 0;

		private static uint __GetActorLabel = 0;

		private static uint __GetActorForwardVector = 0;

		private static uint __GetActorEyesViewPoint = 0;

		private static uint __GetActorEnableCollision = 0;

		private static uint __GetActorBounds = 0;

		private static uint __ForceNetUpdate = 0;

		private static uint __FlushNetDormancy = 0;

		private static uint __FinishAddComponent = 0;

		private static uint __FindComponentByTag = 0;

		private static uint __EnableInput = 0;

		private static uint __DisableInput = 0;

		private static uint __DetachRootComponentFromParent = 0;

		private static uint __CreateInputComponent = 0;

		private static uint __CanTriggerResimulation = 0;

		private static uint __AddTickPrerequisiteComponent = 0;

		private static uint __AddTickPrerequisiteActor = 0;

		private static uint __AddComponentByClass = 0;

		private static uint __AddComponent = 0;

		private static uint __ActorHasTag = 0;
	}
}