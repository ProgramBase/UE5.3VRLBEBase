using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.GizmoHandleGroup")]
	public partial class UGizmoHandleGroup : USceneComponent, IStaticClass
	{
		public UMaterialInterface GizmoMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GizmoMaterial, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GizmoMaterial, __InBuffer);
				}
			}
		}

		public UMaterialInterface TranslucentGizmoMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TranslucentGizmoMaterial, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TranslucentGizmoMaterial, __InBuffer);
				}
			}
		}

		public TArray<FGizmoHandle> Handles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Handles, __ReturnBuffer);

					return *(TArray<FGizmoHandle>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Handles, __InBuffer);
				}
			}
		}

		public ABaseTransformGizmo OwningTransformGizmoActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OwningTransformGizmoActor, __ReturnBuffer);

					return *(ABaseTransformGizmo*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OwningTransformGizmoActor, __InBuffer);
				}
			}
		}

		public UViewportDragOperationComponent DragOperationComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DragOperationComponent, __ReturnBuffer);

					return *(UViewportDragOperationComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DragOperationComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ViewportInteraction.GizmoHandleGroup");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __GizmoMaterial = 0;

		private static uint __TranslucentGizmoMaterial = 0;

		private static uint __Handles = 0;

		private static uint __OwningTransformGizmoActor = 0;

		private static uint __DragOperationComponent = 0;
	}
}