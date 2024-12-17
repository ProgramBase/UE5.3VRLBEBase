using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SceneCaptureComponent")]
	public partial class USceneCaptureComponent : USceneComponent, IStaticClass
	{
		public ESceneCapturePrimitiveRenderMode PrimitiveRenderMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PrimitiveRenderMode, __ReturnBuffer);

					return *(ESceneCapturePrimitiveRenderMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PrimitiveRenderMode, __InBuffer);
				}
			}
		}

		public ESceneCaptureSource CaptureSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CaptureSource, __ReturnBuffer);

					return *(ESceneCaptureSource*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CaptureSource, __InBuffer);
				}
			}
		}

		public bool bCaptureEveryFrame
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCaptureEveryFrame, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCaptureEveryFrame, __InBuffer);
				}
			}
		}

		public bool bCaptureOnMovement
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCaptureOnMovement, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCaptureOnMovement, __InBuffer);
				}
			}
		}

		public bool bAlwaysPersistRenderingState
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAlwaysPersistRenderingState, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAlwaysPersistRenderingState, __InBuffer);
				}
			}
		}

		public TArray<TWeakObjectPtr<UPrimitiveComponent>> HiddenComponents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HiddenComponents, __ReturnBuffer);

					return *(TArray<TWeakObjectPtr<UPrimitiveComponent>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HiddenComponents, __InBuffer);
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

		public TArray<TWeakObjectPtr<UPrimitiveComponent>> ShowOnlyComponents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShowOnlyComponents, __ReturnBuffer);

					return *(TArray<TWeakObjectPtr<UPrimitiveComponent>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShowOnlyComponents, __InBuffer);
				}
			}
		}

		public TArray<AActor> ShowOnlyActors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShowOnlyActors, __ReturnBuffer);

					return *(TArray<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShowOnlyActors, __InBuffer);
				}
			}
		}

		public float LODDistanceFactor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LODDistanceFactor, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LODDistanceFactor, __InBuffer);
				}
			}
		}

		public float MaxViewDistanceOverride
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxViewDistanceOverride, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxViewDistanceOverride, __InBuffer);
				}
			}
		}

		public int CaptureSortPriority
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CaptureSortPriority, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CaptureSortPriority, __InBuffer);
				}
			}
		}

		public bool bUseRayTracingIfEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseRayTracingIfEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseRayTracingIfEnabled, __InBuffer);
				}
			}
		}

		public TArray<FEngineShowFlagsSetting> ShowFlagSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShowFlagSettings, __ReturnBuffer);

					return *(TArray<FEngineShowFlagsSetting>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShowFlagSettings, __InBuffer);
				}
			}
		}

		public FString ProfilingEventName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ProfilingEventName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ProfilingEventName, __InBuffer);
				}
			}
		}

		public UStaticMesh CaptureMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CaptureMesh, __ReturnBuffer);

					return *(UStaticMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CaptureMesh, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SceneCaptureComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void ShowOnlyComponent(UPrimitiveComponent InComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InComponent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ShowOnlyComponent, __InBuffer);
			}
		}

		/// <param name="bIncludeFromChildActors">
		/// Whether to include the components from child actors
		/// </param>
		public virtual void ShowOnlyActorComponents(AActor InActor, bool bIncludeFromChildActors = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InActor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIncludeFromChildActors;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ShowOnlyActorComponents, __InBuffer);
			}
		}

		public virtual void SetCaptureSortPriority(int NewCaptureSortPriority)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = NewCaptureSortPriority;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCaptureSortPriority, __InBuffer);
			}
		}

		public virtual void RemoveShowOnlyComponent(UPrimitiveComponent InComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InComponent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveShowOnlyComponent, __InBuffer);
			}
		}

		/// <param name="bIncludeFromChildActors">
		/// Whether to remove the components from child actors
		/// </param>
		public virtual void RemoveShowOnlyActorComponents(AActor InActor, bool bIncludeFromChildActors = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InActor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIncludeFromChildActors;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveShowOnlyActorComponents, __InBuffer);
			}
		}

		public virtual void HideComponent(UPrimitiveComponent InComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InComponent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __HideComponent, __InBuffer);
			}
		}

		/// <param name="bIncludeFromChildActors">
		/// Whether to include the components from child actors
		/// </param>
		public virtual void HideActorComponents(AActor InActor, bool bIncludeFromChildActors = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InActor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIncludeFromChildActors;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __HideActorComponents, __InBuffer);
			}
		}

		public virtual void ClearShowOnlyComponents()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearShowOnlyComponents);
			}
		}

		public virtual void ClearHiddenComponents()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearHiddenComponents);
			}
		}

		private static uint __PrimitiveRenderMode = 0;

		private static uint __CaptureSource = 0;

		private static uint __bCaptureEveryFrame = 0;

		private static uint __bCaptureOnMovement = 0;

		private static uint __bAlwaysPersistRenderingState = 0;

		private static uint __HiddenComponents = 0;

		private static uint __HiddenActors = 0;

		private static uint __ShowOnlyComponents = 0;

		private static uint __ShowOnlyActors = 0;

		private static uint __LODDistanceFactor = 0;

		private static uint __MaxViewDistanceOverride = 0;

		private static uint __CaptureSortPriority = 0;

		private static uint __bUseRayTracingIfEnabled = 0;

		private static uint __ShowFlagSettings = 0;

		private static uint __ProfilingEventName = 0;

		private static uint __CaptureMesh = 0;

		private static uint __ShowOnlyComponent = 0;

		private static uint __ShowOnlyActorComponents = 0;

		private static uint __SetCaptureSortPriority = 0;

		private static uint __RemoveShowOnlyComponent = 0;

		private static uint __RemoveShowOnlyActorComponents = 0;

		private static uint __HideComponent = 0;

		private static uint __HideActorComponents = 0;

		private static uint __ClearShowOnlyComponents = 0;

		private static uint __ClearHiddenComponents = 0;
	}
}