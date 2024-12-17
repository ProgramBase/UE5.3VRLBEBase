using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SceneComponent")]
	public partial class USceneComponent : UActorComponent, IStaticClass
	{
		public TWeakObjectPtr<APhysicsVolume> PhysicsVolume
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PhysicsVolume, __ReturnBuffer);

					return *(TWeakObjectPtr<APhysicsVolume>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PhysicsVolume, __InBuffer);
				}
			}
		}

		public USceneComponent AttachParent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AttachParent, __ReturnBuffer);

					return *(USceneComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AttachParent, __InBuffer);
				}
			}
		}

		public FName AttachSocketName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AttachSocketName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AttachSocketName, __InBuffer);
				}
			}
		}

		public TArray<USceneComponent> AttachChildren
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AttachChildren, __ReturnBuffer);

					return *(TArray<USceneComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AttachChildren, __InBuffer);
				}
			}
		}

		public TArray<USceneComponent> ClientAttachedChildren
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ClientAttachedChildren, __ReturnBuffer);

					return *(TArray<USceneComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ClientAttachedChildren, __InBuffer);
				}
			}
		}

		public FVector RelativeLocation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RelativeLocation, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RelativeLocation, __InBuffer);
				}
			}
		}

		public FRotator RelativeRotation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RelativeRotation, __ReturnBuffer);

					return *(FRotator*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RelativeRotation, __InBuffer);
				}
			}
		}

		public FVector RelativeScale3D
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RelativeScale3D, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RelativeScale3D, __InBuffer);
				}
			}
		}

		public FVector ComponentVelocity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ComponentVelocity, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ComponentVelocity, __InBuffer);
				}
			}
		}

		public bool bComponentToWorldUpdated
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bComponentToWorldUpdated, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bComponentToWorldUpdated, __InBuffer);
				}
			}
		}

		public bool bAbsoluteLocation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAbsoluteLocation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAbsoluteLocation, __InBuffer);
				}
			}
		}

		public bool bAbsoluteRotation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAbsoluteRotation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAbsoluteRotation, __InBuffer);
				}
			}
		}

		public bool bAbsoluteScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAbsoluteScale, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAbsoluteScale, __InBuffer);
				}
			}
		}

		public bool bVisible
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bVisible, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bVisible, __InBuffer);
				}
			}
		}

		public bool bShouldBeAttached
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldBeAttached, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldBeAttached, __InBuffer);
				}
			}
		}

		public bool bShouldSnapLocationWhenAttached
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldSnapLocationWhenAttached, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldSnapLocationWhenAttached, __InBuffer);
				}
			}
		}

		public bool bShouldSnapRotationWhenAttached
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldSnapRotationWhenAttached, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldSnapRotationWhenAttached, __InBuffer);
				}
			}
		}

		public bool bShouldSnapScaleWhenAttached
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldSnapScaleWhenAttached, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldSnapScaleWhenAttached, __InBuffer);
				}
			}
		}

		public bool bShouldUpdatePhysicsVolume
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldUpdatePhysicsVolume, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldUpdatePhysicsVolume, __InBuffer);
				}
			}
		}

		public bool bHiddenInGame
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHiddenInGame, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHiddenInGame, __InBuffer);
				}
			}
		}

		public bool bBoundsChangeTriggersStreamingDataRebuild
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bBoundsChangeTriggersStreamingDataRebuild, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bBoundsChangeTriggersStreamingDataRebuild, __InBuffer);
				}
			}
		}

		public bool bUseAttachParentBound
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseAttachParentBound, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseAttachParentBound, __InBuffer);
				}
			}
		}

		public bool bComputeFastLocalBounds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bComputeFastLocalBounds, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bComputeFastLocalBounds, __InBuffer);
				}
			}
		}

		public bool bComputeBoundsOnceForGame
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bComputeBoundsOnceForGame, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bComputeBoundsOnceForGame, __InBuffer);
				}
			}
		}

		public bool bComputedBoundsOnceForGame
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bComputedBoundsOnceForGame, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bComputedBoundsOnceForGame, __InBuffer);
				}
			}
		}

		public bool bIsNotRenderAttachmentRoot
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsNotRenderAttachmentRoot, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsNotRenderAttachmentRoot, __InBuffer);
				}
			}
		}

		public bool bVisualizeComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bVisualizeComponent, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bVisualizeComponent, __InBuffer);
				}
			}
		}

		public EComponentMobility Mobility
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Mobility, __ReturnBuffer);

					return *(EComponentMobility*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Mobility, __InBuffer);
				}
			}
		}

		public EDetailMode DetailMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DetailMode, __ReturnBuffer);

					return *(EDetailMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DetailMode, __InBuffer);
				}
			}
		}

		public FPhysicsVolumeChanged PhysicsVolumeChangedDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PhysicsVolumeChangedDelegate, __ReturnBuffer);

					return *(FPhysicsVolumeChanged*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PhysicsVolumeChangedDelegate, __InBuffer);
				}
			}
		}

		public USceneComponent ReplacementSceneComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReplacementSceneComponent, __ReturnBuffer);

					return *(USceneComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReplacementSceneComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SceneComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void ToggleVisibility(bool bPropagateToChildren = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bPropagateToChildren;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ToggleVisibility, __InBuffer);
			}
		}

		/// <param name="NewScale">
		/// New scale in world space for this component.
		/// </param>
		public virtual void SetWorldScale3D(FVector NewScale)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewScale?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetWorldScale3D, __InBuffer);
			}
		}

		public virtual void SetVisibility(bool bNewVisibility, bool bPropagateToChildren = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = bNewVisibility;

				*(bool*)(__InBuffer + 1) = bPropagateToChildren;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVisibility, __InBuffer);
			}
		}

		public virtual void SetShouldUpdatePhysicsVolume(bool bInShouldUpdatePhysicsVolume)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInShouldUpdatePhysicsVolume;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetShouldUpdatePhysicsVolume, __InBuffer);
			}
		}

		public virtual void SetRelativeScale3D(FVector NewScale3D)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewScale3D?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRelativeScale3D, __InBuffer);
			}
		}

		public virtual void SetMobility(EComponentMobility NewMobility)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)NewMobility;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMobility, __InBuffer);
			}
		}

		public virtual void SetHiddenInGame(bool NewHidden, bool bPropagateToChildren = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = NewHidden;

				*(bool*)(__InBuffer + 1) = bPropagateToChildren;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetHiddenInGame, __InBuffer);
			}
		}

		public virtual void SetAbsolute(bool bNewAbsoluteLocation = false, bool bNewAbsoluteRotation = false, bool bNewAbsoluteScale = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[3];

				*(bool*)(__InBuffer) = bNewAbsoluteLocation;

				*(bool*)(__InBuffer + 1) = bNewAbsoluteRotation;

				*(bool*)(__InBuffer + 2) = bNewAbsoluteScale;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAbsolute, __InBuffer);
			}
		}

		public virtual void ResetRelativeTransform()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetRelativeTransform);
			}
		}

		public virtual void OnRep_Visibility(bool OldValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = OldValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnRep_Visibility, __InBuffer);
			}
		}

		public virtual void OnRep_Transform()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_Transform);
			}
		}

		public virtual void OnRep_AttachSocketName()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_AttachSocketName);
			}
		}

		public virtual void OnRep_AttachParent()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_AttachParent);
			}
		}

		public virtual void OnRep_AttachChildren()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_AttachChildren);
			}
		}

		/// <param name="NewTransform">
		/// New transform in world space for the component.
		/// </param>
		/// <param name="SweepHitResult">
		/// Hit result from any impact if sweep is true.
		/// </param>
		/// <param name="bSweep">
		/// Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		/// Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// </param>
		/// <param name="bTeleport">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
		/// </param>
		public virtual void K2_SetWorldTransform(FTransform NewTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = NewTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSweep;

				*(nint*)(__InBuffer + 9) = SweepHitResult?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_SetWorldTransform, __InBuffer, __OutBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

			}
		}

		/// <param name="NewRotation">
		/// New rotation in world space for the component.
		/// </param>
		/// <param name="SweepHitResult">
		/// Hit result from any impact if sweep is true.
		/// </param>
		/// <param name="bSweep">
		/// Whether we sweep to the destination (currently not supported for rotation).
		/// </param>
		/// <param name="bTeleport">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
		/// </param>
		public virtual void K2_SetWorldRotation(FRotator NewRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = NewRotation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSweep;

				*(nint*)(__InBuffer + 9) = SweepHitResult?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_SetWorldRotation, __InBuffer, __OutBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

			}
		}

		/// <param name="NewLocation">
		/// New location in world space for the component.
		/// </param>
		/// <param name="NewRotation">
		/// New rotation in world space for the component.
		/// </param>
		/// <param name="SweepHitResult">
		/// Hit result from any impact if sweep is true.
		/// </param>
		/// <param name="bSweep">
		/// Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		/// Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// </param>
		/// <param name="bTeleport">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
		/// </param>
		public virtual void K2_SetWorldLocationAndRotation(FVector NewLocation, FRotator NewRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
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

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_SetWorldLocationAndRotation, __InBuffer, __OutBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

			}
		}

		/// <param name="NewLocation">
		/// New location in world space for the component.
		/// </param>
		/// <param name="SweepHitResult">
		/// Hit result from any impact if sweep is true.
		/// </param>
		/// <param name="bSweep">
		/// Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		/// Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// </param>
		/// <param name="bTeleport">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
		/// </param>
		public virtual void K2_SetWorldLocation(FVector NewLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = NewLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSweep;

				*(nint*)(__InBuffer + 9) = SweepHitResult?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_SetWorldLocation, __InBuffer, __OutBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

			}
		}

		/// <param name="NewTransform">
		/// New transform of the component relative to its parent.
		/// </param>
		/// <param name="SweepHitResult">
		/// Hit result from any impact if sweep is true.
		/// </param>
		/// <param name="bSweep">
		/// Whether we sweep to the destination (currently not supported for rotation).
		/// </param>
		/// <param name="bTeleport">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// </param>
		public virtual void K2_SetRelativeTransform(FTransform NewTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = NewTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSweep;

				*(nint*)(__InBuffer + 9) = SweepHitResult?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_SetRelativeTransform, __InBuffer, __OutBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

			}
		}

		/// <param name="NewRotation">
		/// New rotation of the component relative to its parent
		/// </param>
		/// <param name="SweepHitResult">
		/// Hit result from any impact if sweep is true.
		/// </param>
		/// <param name="bSweep">
		/// Whether we sweep to the destination (currently not supported for rotation).
		/// </param>
		/// <param name="bTeleport">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// </param>
		public virtual void K2_SetRelativeRotation(FRotator NewRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = NewRotation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSweep;

				*(nint*)(__InBuffer + 9) = SweepHitResult?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_SetRelativeRotation, __InBuffer, __OutBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

			}
		}

		/// <param name="NewLocation">
		/// New location of the component relative to its parent.
		/// </param>
		/// <param name="NewRotation">
		/// New rotation of the component relative to its parent.
		/// </param>
		/// <param name="SweepHitResult">
		/// Hit result from any impact if sweep is true.
		/// </param>
		/// <param name="bSweep">
		/// Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		/// Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// </param>
		/// <param name="bTeleport">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
		/// </param>
		public virtual void K2_SetRelativeLocationAndRotation(FVector NewLocation, FRotator NewRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
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

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_SetRelativeLocationAndRotation, __InBuffer, __OutBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

			}
		}

		/// <param name="NewLocation">
		/// New location of the component relative to its parent.		
		/// </param>
		/// <param name="SweepHitResult">
		/// Hit result from any impact if sweep is true.
		/// </param>
		/// <param name="bSweep">
		/// Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		/// Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// </param>
		/// <param name="bTeleport">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
		/// </param>
		public virtual void K2_SetRelativeLocation(FVector NewLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = NewLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSweep;

				*(nint*)(__InBuffer + 9) = SweepHitResult?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_SetRelativeLocation, __InBuffer, __OutBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

			}
		}

		public virtual FTransform K2_GetComponentToWorld()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __K2_GetComponentToWorld, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public virtual FVector K2_GetComponentScale()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __K2_GetComponentScale, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FRotator K2_GetComponentRotation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __K2_GetComponentRotation, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public virtual FVector K2_GetComponentLocation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __K2_GetComponentLocation, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="LocationRule">
		/// How to handle translations when detaching.
		/// </param>
		/// <param name="RotationRule">
		/// How to handle rotation when detaching.
		/// </param>
		/// <param name="ScaleRule">
		/// How to handle scales when detaching.
		/// </param>
		/// <param name="bCallModify">
		/// If true, call Modify() on the component and the current attach parent component
		/// </param>
		public virtual void K2_DetachFromComponent(EDetachmentRule LocationRule = EDetachmentRule.KeepRelative, EDetachmentRule RotationRule = EDetachmentRule.KeepRelative, EDetachmentRule ScaleRule = EDetachmentRule.KeepRelative, bool bCallModify = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(byte*)(__InBuffer) = (byte)LocationRule;

				*(byte*)(__InBuffer + 1) = (byte)RotationRule;

				*(byte*)(__InBuffer + 2) = (byte)ScaleRule;

				*(bool*)(__InBuffer + 3) = bCallModify;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __K2_DetachFromComponent, __InBuffer);
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
		/// True if attachment is successful (or already attached to requested parent/socket), false if attachment is rejected and there is no change in AttachParent.
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

		public virtual bool K2_AttachTo(USceneComponent InParent, FName InSocketName = null, EAttachLocation AttachType = EAttachLocation.KeepRelativeOffset, bool bWeldSimulatedBodies = true)
		{
			unsafe
			{
				InSocketName ??= new FName("None");

				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = InParent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSocketName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)AttachType;

				*(bool*)(__InBuffer + 17) = bWeldSimulatedBodies;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __K2_AttachTo, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="DeltaTransform">
		/// Change in transform in world space for the component. Scale is ignored since we preserve the original scale.
		/// </param>
		/// <param name="SweepHitResult">
		/// Hit result from any impact if sweep is true.
		/// </param>
		/// <param name="bSweep">
		/// Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		/// Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// </param>
		/// <param name="bTeleport">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
		/// </param>
		public virtual void K2_AddWorldTransformKeepScale(FTransform DeltaTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = DeltaTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSweep;

				*(nint*)(__InBuffer + 9) = SweepHitResult?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_AddWorldTransformKeepScale, __InBuffer, __OutBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

			}
		}

		/// <param name="DeltaTransform">
		/// Change in transform in world space for the component. Scale is ignored.
		/// </param>
		/// <param name="SweepHitResult">
		/// Hit result from any impact if sweep is true.
		/// </param>
		/// <param name="bSweep">
		/// Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		/// Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// </param>
		/// <param name="bTeleport">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
		/// </param>
		public virtual void K2_AddWorldTransform(FTransform DeltaTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = DeltaTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSweep;

				*(nint*)(__InBuffer + 9) = SweepHitResult?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_AddWorldTransform, __InBuffer, __OutBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

			}
		}

		/// <param name="DeltaRotation">
		/// Change in rotation in world space for the component.
		/// </param>
		/// <param name="SweepHitResult">
		/// Hit result from any impact if sweep is true.
		/// </param>
		/// <param name="bSweep">
		/// Whether we sweep to the destination (currently not supported for rotation).
		/// </param>
		/// <param name="bTeleport">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
		/// </param>
		public virtual void K2_AddWorldRotation(FRotator DeltaRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = DeltaRotation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSweep;

				*(nint*)(__InBuffer + 9) = SweepHitResult?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_AddWorldRotation, __InBuffer, __OutBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

			}
		}

		/// <param name="DeltaLocation">
		/// Change in location in world space for the component.
		/// </param>
		/// <param name="SweepHitResult">
		/// Hit result from any impact if sweep is true.
		/// </param>
		/// <param name="bSweep">
		/// Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		/// Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// </param>
		/// <param name="bTeleport">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
		/// </param>
		public virtual void K2_AddWorldOffset(FVector DeltaLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = DeltaLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSweep;

				*(nint*)(__InBuffer + 9) = SweepHitResult?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_AddWorldOffset, __InBuffer, __OutBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

			}
		}

		/// <param name="DeltaRotation">
		/// Change in rotation of the component relative to is parent.
		/// </param>
		/// <param name="SweepHitResult">
		/// Hit result from any impact if sweep is true.
		/// </param>
		/// <param name="bSweep">
		/// Whether we sweep to the destination (currently not supported for rotation).
		/// </param>
		/// <param name="bTeleport">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// </param>
		public virtual void K2_AddRelativeRotation(FRotator DeltaRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = DeltaRotation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSweep;

				*(nint*)(__InBuffer + 9) = SweepHitResult?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_AddRelativeRotation, __InBuffer, __OutBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

			}
		}

		/// <param name="DeltaLocation">
		/// Change in location of the component relative to its parent
		/// </param>
		/// <param name="SweepHitResult">
		/// Hit result from any impact if sweep is true.
		/// </param>
		/// <param name="bSweep">
		/// Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		/// Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// </param>
		/// <param name="bTeleport">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
		/// </param>
		public virtual void K2_AddRelativeLocation(FVector DeltaLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = DeltaLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSweep;

				*(nint*)(__InBuffer + 9) = SweepHitResult?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_AddRelativeLocation, __InBuffer, __OutBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

			}
		}

		/// <param name="DeltaTransform">
		/// Change in transform of the component in its local reference frame. Scale is unchanged.
		/// </param>
		/// <param name="SweepHitResult">
		/// Hit result from any impact if sweep is true.
		/// </param>
		/// <param name="bSweep">
		/// Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		/// Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// </param>
		/// <param name="bTeleport">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
		/// </param>
		public virtual void K2_AddLocalTransform(FTransform DeltaTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = DeltaTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSweep;

				*(nint*)(__InBuffer + 9) = SweepHitResult?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_AddLocalTransform, __InBuffer, __OutBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

			}
		}

		/// <param name="DeltaRotation">
		/// Change in rotation of the component in its local reference frame.
		/// </param>
		/// <param name="SweepHitResult">
		/// Hit result from any impact if sweep is true.
		/// </param>
		/// <param name="bSweep">
		/// Whether we sweep to the destination (currently not supported for rotation).
		/// </param>
		/// <param name="bTeleport">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// </param>
		public virtual void K2_AddLocalRotation(FRotator DeltaRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = DeltaRotation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSweep;

				*(nint*)(__InBuffer + 9) = SweepHitResult?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_AddLocalRotation, __InBuffer, __OutBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

			}
		}

		/// <param name="DeltaLocation">
		/// Change in location of the component in its local reference frame.
		/// </param>
		/// <param name="SweepHitResult">
		/// Hit result from any impact if sweep is true.
		/// </param>
		/// <param name="bSweep">
		/// Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		/// Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// </param>
		/// <param name="bTeleport">
		/// Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
		/// </param>
		public virtual void K2_AddLocalOffset(FVector DeltaLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = DeltaLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSweep;

				*(nint*)(__InBuffer + 9) = SweepHitResult?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_AddLocalOffset, __InBuffer, __OutBuffer);

				SweepHitResult = *(FHitResult*)(__OutBuffer);

			}
		}

		public virtual bool IsVisible()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsVisible, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsSimulatingPhysics(FName BoneName = null)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsSimulatingPhysics, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsAnySimulatingPhysics()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsAnySimulatingPhysics, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FVector GetUpVector()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetUpVector, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="InSocketName">
		/// Name of the socket or the bone to get the transform 
		/// </param>
		/// <returns>
		/// Socket transform in world space if socket if found. Otherwise it will return component's transform in world space.
		/// </returns>
		public virtual FTransform GetSocketTransform(FName InSocketName, ERelativeTransformSpace TransformSpace = ERelativeTransformSpace.RTS_World)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InSocketName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)TransformSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetSocketTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="InSocketName">
		/// Name of the socket or the bone to get the transform 
		/// </param>
		/// <returns>
		/// Socket transform in world space if socket if found. Otherwise it will return component's transform in world space.
		/// </returns>
		public virtual FRotator GetSocketRotation(FName InSocketName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSocketName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetSocketRotation, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		/// <param name="InSocketName">
		/// Name of the socket or the bone to get the transform 
		/// </param>
		/// <returns>
		/// Socket transform in world space if socket if found. Otherwise it will return component's transform in world space.
		/// </returns>
		public virtual FQuat GetSocketQuaternion(FName InSocketName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSocketName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetSocketQuaternion, __InBuffer, __ReturnBuffer);

				return *(FQuat*)__ReturnBuffer;
			}
		}

		/// <param name="InSocketName">
		/// Name of the socket or the bone to get the transform 
		/// </param>
		/// <returns>
		/// Socket transform in world space if socket is found. Otherwise it will return component's transform in world space.
		/// </returns>
		public virtual FVector GetSocketLocation(FName InSocketName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSocketName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetSocketLocation, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual bool GetShouldUpdatePhysicsVolume()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetShouldUpdatePhysicsVolume, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FVector GetRightVector()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetRightVector, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FTransform GetRelativeTransform()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetRelativeTransform, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public virtual APhysicsVolume GetPhysicsVolume()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPhysicsVolume, __ReturnBuffer);

				return *(APhysicsVolume*)__ReturnBuffer;
			}
		}

		public virtual void GetParentComponents(ref TArray<USceneComponent> Parents)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Parents?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetParentComponents, __InBuffer, __OutBuffer);

				Parents = *(TArray<USceneComponent>*)(__OutBuffer);

			}
		}

		public virtual int GetNumChildrenComponents()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumChildrenComponents, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual FVector GetForwardVector()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetForwardVector, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Velocity of the component
		/// </returns>
		public virtual FVector GetComponentVelocity()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetComponentVelocity, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="bIncludeAllDescendants">
		/// Whether to include all descendants in the list of children (i.e. grandchildren, great grandchildren, etc.)
		/// </param>
		/// <param name="Children">
		/// The list of attached child components
		/// </param>
		public virtual void GetChildrenComponents(bool bIncludeAllDescendants, ref TArray<USceneComponent> Children)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(bool*)(__InBuffer) = bIncludeAllDescendants;

				*(nint*)(__InBuffer + 1) = Children?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetChildrenComponents, __InBuffer, __OutBuffer);

				Children = *(TArray<USceneComponent>*)(__OutBuffer);

			}
		}

		public virtual USceneComponent GetChildComponent(int ChildIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = ChildIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetChildComponent, __InBuffer, __ReturnBuffer);

				return *(USceneComponent*)__ReturnBuffer;
			}
		}

		public virtual FName GetAttachSocketName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAttachSocketName, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual USceneComponent GetAttachParent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAttachParent, __ReturnBuffer);

				return *(USceneComponent*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Get the names of all the sockets on the component.
		/// </returns>
		public virtual TArray<FName> GetAllSocketNames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAllSocketNames, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		/// <param name="InSocketName">
		/// Name of the socket or the bone to get the transform 
		/// </param>
		public virtual bool DoesSocketExist(FName InSocketName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSocketName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DoesSocketExist, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void DetachFromParent(bool bMaintainWorldPosition = false, bool bCallModify = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = bMaintainWorldPosition;

				*(bool*)(__InBuffer + 1) = bCallModify;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DetachFromParent, __InBuffer);
			}
		}

		private static uint __PhysicsVolume = 0;

		private static uint __AttachParent = 0;

		private static uint __AttachSocketName = 0;

		private static uint __AttachChildren = 0;

		private static uint __ClientAttachedChildren = 0;

		private static uint __RelativeLocation = 0;

		private static uint __RelativeRotation = 0;

		private static uint __RelativeScale3D = 0;

		private static uint __ComponentVelocity = 0;

		private static uint __bComponentToWorldUpdated = 0;

		private static uint __bAbsoluteLocation = 0;

		private static uint __bAbsoluteRotation = 0;

		private static uint __bAbsoluteScale = 0;

		private static uint __bVisible = 0;

		private static uint __bShouldBeAttached = 0;

		private static uint __bShouldSnapLocationWhenAttached = 0;

		private static uint __bShouldSnapRotationWhenAttached = 0;

		private static uint __bShouldSnapScaleWhenAttached = 0;

		private static uint __bShouldUpdatePhysicsVolume = 0;

		private static uint __bHiddenInGame = 0;

		private static uint __bBoundsChangeTriggersStreamingDataRebuild = 0;

		private static uint __bUseAttachParentBound = 0;

		private static uint __bComputeFastLocalBounds = 0;

		private static uint __bComputeBoundsOnceForGame = 0;

		private static uint __bComputedBoundsOnceForGame = 0;

		private static uint __bIsNotRenderAttachmentRoot = 0;

		private static uint __bVisualizeComponent = 0;

		private static uint __Mobility = 0;

		private static uint __DetailMode = 0;

		private static uint __PhysicsVolumeChangedDelegate = 0;

		private static uint __ReplacementSceneComponent = 0;

		private static uint __ToggleVisibility = 0;

		private static uint __SetWorldScale3D = 0;

		private static uint __SetVisibility = 0;

		private static uint __SetShouldUpdatePhysicsVolume = 0;

		private static uint __SetRelativeScale3D = 0;

		private static uint __SetMobility = 0;

		private static uint __SetHiddenInGame = 0;

		private static uint __SetAbsolute = 0;

		private static uint __ResetRelativeTransform = 0;

		private static uint __OnRep_Visibility = 0;

		private static uint __OnRep_Transform = 0;

		private static uint __OnRep_AttachSocketName = 0;

		private static uint __OnRep_AttachParent = 0;

		private static uint __OnRep_AttachChildren = 0;

		private static uint __K2_SetWorldTransform = 0;

		private static uint __K2_SetWorldRotation = 0;

		private static uint __K2_SetWorldLocationAndRotation = 0;

		private static uint __K2_SetWorldLocation = 0;

		private static uint __K2_SetRelativeTransform = 0;

		private static uint __K2_SetRelativeRotation = 0;

		private static uint __K2_SetRelativeLocationAndRotation = 0;

		private static uint __K2_SetRelativeLocation = 0;

		private static uint __K2_GetComponentToWorld = 0;

		private static uint __K2_GetComponentScale = 0;

		private static uint __K2_GetComponentRotation = 0;

		private static uint __K2_GetComponentLocation = 0;

		private static uint __K2_DetachFromComponent = 0;

		private static uint __K2_AttachToComponent = 0;

		private static uint __K2_AttachTo = 0;

		private static uint __K2_AddWorldTransformKeepScale = 0;

		private static uint __K2_AddWorldTransform = 0;

		private static uint __K2_AddWorldRotation = 0;

		private static uint __K2_AddWorldOffset = 0;

		private static uint __K2_AddRelativeRotation = 0;

		private static uint __K2_AddRelativeLocation = 0;

		private static uint __K2_AddLocalTransform = 0;

		private static uint __K2_AddLocalRotation = 0;

		private static uint __K2_AddLocalOffset = 0;

		private static uint __IsVisible = 0;

		private static uint __IsSimulatingPhysics = 0;

		private static uint __IsAnySimulatingPhysics = 0;

		private static uint __GetUpVector = 0;

		private static uint __GetSocketTransform = 0;

		private static uint __GetSocketRotation = 0;

		private static uint __GetSocketQuaternion = 0;

		private static uint __GetSocketLocation = 0;

		private static uint __GetShouldUpdatePhysicsVolume = 0;

		private static uint __GetRightVector = 0;

		private static uint __GetRelativeTransform = 0;

		private static uint __GetPhysicsVolume = 0;

		private static uint __GetParentComponents = 0;

		private static uint __GetNumChildrenComponents = 0;

		private static uint __GetForwardVector = 0;

		private static uint __GetComponentVelocity = 0;

		private static uint __GetChildrenComponents = 0;

		private static uint __GetChildComponent = 0;

		private static uint __GetAttachSocketName = 0;

		private static uint __GetAttachParent = 0;

		private static uint __GetAllSocketNames = 0;

		private static uint __DoesSocketExist = 0;

		private static uint __DetachFromParent = 0;
	}
}