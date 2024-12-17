using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ActorComponent")]
	public partial class UActorComponent : UObject, IStaticClass, IInterface_AssetUserData
	{
		public FActorComponentTickFunction PrimaryComponentTick
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PrimaryComponentTick, __ReturnBuffer);

					return *(FActorComponentTickFunction*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PrimaryComponentTick, __InBuffer);
				}
			}
		}

		public TArray<FName> ComponentTags
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ComponentTags, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ComponentTags, __InBuffer);
				}
			}
		}

		public TArray<UAssetUserData> AssetUserData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AssetUserData, __ReturnBuffer);

					return *(TArray<UAssetUserData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AssetUserData, __InBuffer);
				}
			}
		}

		public int UCSSerializationIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UCSSerializationIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UCSSerializationIndex, __InBuffer);
				}
			}
		}

		public bool bNetAddressable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNetAddressable, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNetAddressable, __InBuffer);
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

		public bool bAutoActivate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoActivate, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoActivate, __InBuffer);
				}
			}
		}

		public bool bIsActive
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsActive, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsActive, __InBuffer);
				}
			}
		}

		public bool bEditableWhenInherited
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEditableWhenInherited, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEditableWhenInherited, __InBuffer);
				}
			}
		}

		public bool bCanEverAffectNavigation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCanEverAffectNavigation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCanEverAffectNavigation, __InBuffer);
				}
			}
		}

		public bool bIsEditorOnly
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsEditorOnly, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsEditorOnly, __InBuffer);
				}
			}
		}

		public bool bIsVisualizationComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsVisualizationComponent, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsVisualizationComponent, __InBuffer);
				}
			}
		}

		public bool bNeedsUCSSerializationIndexEvaluted
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNeedsUCSSerializationIndexEvaluted, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNeedsUCSSerializationIndexEvaluted, __InBuffer);
				}
			}
		}

		public EComponentCreationMethod CreationMethod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CreationMethod, __ReturnBuffer);

					return *(EComponentCreationMethod*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CreationMethod, __InBuffer);
				}
			}
		}

		public FActorComponentActivatedSignature OnComponentActivated
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnComponentActivated, __ReturnBuffer);

					return *(FActorComponentActivatedSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnComponentActivated, __InBuffer);
				}
			}
		}

		public FActorComponentDeactivateSignature OnComponentDeactivated
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnComponentDeactivated, __ReturnBuffer);

					return *(FActorComponentDeactivateSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnComponentDeactivated, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ActorComponent");
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

		public virtual void ToggleActive()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ToggleActive);
			}
		}

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

		public virtual void SetIsReplicated(bool ShouldReplicate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = ShouldReplicate;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetIsReplicated, __InBuffer);
			}
		}

		/// <param name="TickInterval">
		/// The duration between ticks for this component's primary tick function
		/// </param>
		public virtual void SetComponentTickIntervalAndCooldown(float TickInterval)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = TickInterval;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetComponentTickIntervalAndCooldown, __InBuffer);
			}
		}

		/// <param name="TickInterval">
		/// The duration between ticks for this component's primary tick function
		/// </param>
		public virtual void SetComponentTickInterval(float TickInterval)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = TickInterval;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetComponentTickInterval, __InBuffer);
			}
		}

		/// <param name="bEnabled">
		/// - Whether it should be enabled or not
		/// </param>
		public virtual void SetComponentTickEnabled(bool bEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetComponentTickEnabled, __InBuffer);
			}
		}

		/// <param name="bNewAutoActivate">
		/// - The new auto activate state of the component
		/// </param>
		public virtual void SetAutoActivate(bool bNewAutoActivate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewAutoActivate;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAutoActivate, __InBuffer);
			}
		}

		/// <param name="bNewActive">
		/// - The new active state of the component
		/// </param>
		/// <param name="bReset">
		/// - Whether the activation should happen even if ShouldActivate returns false.
		/// </param>
		public virtual void SetActive(bool bNewActive, bool bReset = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = bNewActive;

				*(bool*)(__InBuffer + 1) = bReset;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetActive, __InBuffer);
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

		public virtual void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)EndPlayReason;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveEndPlay, __InBuffer);
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

		public virtual void OnRep_IsActive()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_IsActive);
			}
		}

		public virtual void K2_DestroyComponent(UObject Object)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __K2_DestroyComponent, __InBuffer);
			}
		}

		public virtual bool IsComponentTickEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsComponentTickEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsBeingDestroyed()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsBeingDestroyed, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// - The active state of the component.
		/// </returns>
		public virtual bool IsActive()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsActive, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
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

		public virtual float GetComponentTickInterval()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetComponentTickInterval, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual void Deactivate()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Deactivate);
			}
		}

		public virtual bool ComponentHasTag(FName Tag)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Tag?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ComponentHasTag, __InBuffer, __ReturnBuffer);

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

		/// <param name="bReset">
		/// - Whether the activation should happen even if ShouldActivate returns false.
		/// </param>
		public virtual void Activate(bool bReset = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bReset;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Activate, __InBuffer);
			}
		}

		private static uint __PrimaryComponentTick = 0;

		private static uint __ComponentTags = 0;

		private static uint __AssetUserData = 0;

		private static uint __UCSSerializationIndex = 0;

		private static uint __bNetAddressable = 0;

		private static uint __bReplicateUsingRegisteredSubObjectList = 0;

		private static uint __bReplicates = 0;

		private static uint __bAutoActivate = 0;

		private static uint __bIsActive = 0;

		private static uint __bEditableWhenInherited = 0;

		private static uint __bCanEverAffectNavigation = 0;

		private static uint __bIsEditorOnly = 0;

		private static uint __bIsVisualizationComponent = 0;

		private static uint __bNeedsUCSSerializationIndexEvaluted = 0;

		private static uint __CreationMethod = 0;

		private static uint __OnComponentActivated = 0;

		private static uint __OnComponentDeactivated = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __ToggleActive = 0;

		private static uint __SetTickGroup = 0;

		private static uint __SetTickableWhenPaused = 0;

		private static uint __SetIsReplicated = 0;

		private static uint __SetComponentTickIntervalAndCooldown = 0;

		private static uint __SetComponentTickInterval = 0;

		private static uint __SetComponentTickEnabled = 0;

		private static uint __SetAutoActivate = 0;

		private static uint __SetActive = 0;

		private static uint __RemoveTickPrerequisiteComponent = 0;

		private static uint __RemoveTickPrerequisiteActor = 0;

		private static uint __ReceiveTick = 0;

		private static uint __ReceiveEndPlay = 0;

		private static uint __ReceiveBeginPlay = 0;

		private static uint __ReceiveAsyncPhysicsTick = 0;

		private static uint __OnRep_IsActive = 0;

		private static uint __K2_DestroyComponent = 0;

		private static uint __IsComponentTickEnabled = 0;

		private static uint __IsBeingDestroyed = 0;

		private static uint __IsActive = 0;

		private static uint __GetOwner = 0;

		private static uint __GetComponentTickInterval = 0;

		private static uint __Deactivate = 0;

		private static uint __ComponentHasTag = 0;

		private static uint __AddTickPrerequisiteComponent = 0;

		private static uint __AddTickPrerequisiteActor = 0;

		private static uint __Activate = 0;
	}
}