using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.PivotRotationGizmoHandleGroup")]
	public partial class UPivotRotationGizmoHandleGroup : UAxisGizmoHandleGroup, IStaticClass
	{
		public USceneComponent RootFullRotationHandleComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RootFullRotationHandleComponent, __ReturnBuffer);

					return *(USceneComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RootFullRotationHandleComponent, __InBuffer);
				}
			}
		}

		public UGizmoHandleMeshComponent FullRotationHandleMeshComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FullRotationHandleMeshComponent, __ReturnBuffer);

					return *(UGizmoHandleMeshComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FullRotationHandleMeshComponent, __InBuffer);
				}
			}
		}

		public UGizmoHandleMeshComponent StartRotationIndicatorMeshComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StartRotationIndicatorMeshComponent, __ReturnBuffer);

					return *(UGizmoHandleMeshComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StartRotationIndicatorMeshComponent, __InBuffer);
				}
			}
		}

		public USceneComponent RootStartRotationIdicatorComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RootStartRotationIdicatorComponent, __ReturnBuffer);

					return *(USceneComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RootStartRotationIdicatorComponent, __InBuffer);
				}
			}
		}

		public UGizmoHandleMeshComponent DeltaRotationIndicatorMeshComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DeltaRotationIndicatorMeshComponent, __ReturnBuffer);

					return *(UGizmoHandleMeshComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DeltaRotationIndicatorMeshComponent, __InBuffer);
				}
			}
		}

		public USceneComponent RootDeltaRotationIndicatorComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RootDeltaRotationIndicatorComponent, __ReturnBuffer);

					return *(USceneComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RootDeltaRotationIndicatorComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ViewportInteraction.PivotRotationGizmoHandleGroup");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __RootFullRotationHandleComponent = 0;

		private static uint __FullRotationHandleMeshComponent = 0;

		private static uint __StartRotationIndicatorMeshComponent = 0;

		private static uint __RootStartRotationIdicatorComponent = 0;

		private static uint __DeltaRotationIndicatorMeshComponent = 0;

		private static uint __RootDeltaRotationIndicatorComponent = 0;
	}
}