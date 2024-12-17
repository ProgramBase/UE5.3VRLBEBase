using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.PivotTransformGizmo")]
	public partial class APivotTransformGizmo : ABaseTransformGizmo, IStaticClass
	{
		public UUniformScaleGizmoHandleGroup UniformScaleGizmoHandleGroup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UniformScaleGizmoHandleGroup, __ReturnBuffer);

					return *(UUniformScaleGizmoHandleGroup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UniformScaleGizmoHandleGroup, __InBuffer);
				}
			}
		}

		public UPivotTranslationGizmoHandleGroup TranslationGizmoHandleGroup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TranslationGizmoHandleGroup, __ReturnBuffer);

					return *(UPivotTranslationGizmoHandleGroup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TranslationGizmoHandleGroup, __InBuffer);
				}
			}
		}

		public UPivotScaleGizmoHandleGroup ScaleGizmoHandleGroup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ScaleGizmoHandleGroup, __ReturnBuffer);

					return *(UPivotScaleGizmoHandleGroup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ScaleGizmoHandleGroup, __InBuffer);
				}
			}
		}

		public UPivotPlaneTranslationGizmoHandleGroup PlaneTranslationGizmoHandleGroup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlaneTranslationGizmoHandleGroup, __ReturnBuffer);

					return *(UPivotPlaneTranslationGizmoHandleGroup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlaneTranslationGizmoHandleGroup, __InBuffer);
				}
			}
		}

		public UPivotRotationGizmoHandleGroup RotationGizmoHandleGroup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RotationGizmoHandleGroup, __ReturnBuffer);

					return *(UPivotRotationGizmoHandleGroup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RotationGizmoHandleGroup, __InBuffer);
				}
			}
		}

		public UStretchGizmoHandleGroup StretchGizmoHandleGroup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StretchGizmoHandleGroup, __ReturnBuffer);

					return *(UStretchGizmoHandleGroup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StretchGizmoHandleGroup, __InBuffer);
				}
			}
		}

		public UActorComponent LastDraggingHandle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastDraggingHandle, __ReturnBuffer);

					return *(UActorComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastDraggingHandle, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ViewportInteraction.PivotTransformGizmo");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __UniformScaleGizmoHandleGroup = 0;

		private static uint __TranslationGizmoHandleGroup = 0;

		private static uint __ScaleGizmoHandleGroup = 0;

		private static uint __PlaneTranslationGizmoHandleGroup = 0;

		private static uint __RotationGizmoHandleGroup = 0;

		private static uint __StretchGizmoHandleGroup = 0;

		private static uint __LastDraggingHandle = 0;
	}
}