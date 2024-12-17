using Script.CoreUObject;
using Script.ModelingComponents;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.MeshSpaceDeformerTool")]
	public partial class UMeshSpaceDeformerTool : USingleSelectionMeshEditingTool, IStaticClass
	{
		public UMeshSpaceDeformerToolProperties Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(UMeshSpaceDeformerToolProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __InBuffer);
				}
			}
		}

		public UMeshSpaceDeformerToolActionPropertySet ToolActions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ToolActions, __ReturnBuffer);

					return *(UMeshSpaceDeformerToolActionPropertySet*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ToolActions, __InBuffer);
				}
			}
		}

		public UGizmoTransformChangeStateTarget StateTarget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StateTarget, __ReturnBuffer);

					return *(UGizmoTransformChangeStateTarget*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StateTarget, __InBuffer);
				}
			}
		}

		public UDragAlignmentMechanic DragAlignmentMechanic
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DragAlignmentMechanic, __ReturnBuffer);

					return *(UDragAlignmentMechanic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DragAlignmentMechanic, __InBuffer);
				}
			}
		}

		public UMeshOpPreviewWithBackgroundCompute Preview
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Preview, __ReturnBuffer);

					return *(UMeshOpPreviewWithBackgroundCompute*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Preview, __InBuffer);
				}
			}
		}

		public UPreviewMesh OriginalMeshPreview
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OriginalMeshPreview, __ReturnBuffer);

					return *(UPreviewMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OriginalMeshPreview, __InBuffer);
				}
			}
		}

		public UIntervalGizmo IntervalGizmo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __IntervalGizmo, __ReturnBuffer);

					return *(UIntervalGizmo*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __IntervalGizmo, __InBuffer);
				}
			}
		}

		public UCombinedTransformGizmo TransformGizmo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TransformGizmo, __ReturnBuffer);

					return *(UCombinedTransformGizmo*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TransformGizmo, __InBuffer);
				}
			}
		}

		public UTransformProxy TransformProxy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TransformProxy, __ReturnBuffer);

					return *(UTransformProxy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TransformProxy, __InBuffer);
				}
			}
		}

		public UGizmoLocalFloatParameterSource UpIntervalSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UpIntervalSource, __ReturnBuffer);

					return *(UGizmoLocalFloatParameterSource*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UpIntervalSource, __InBuffer);
				}
			}
		}

		public UGizmoLocalFloatParameterSource DownIntervalSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DownIntervalSource, __ReturnBuffer);

					return *(UGizmoLocalFloatParameterSource*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DownIntervalSource, __InBuffer);
				}
			}
		}

		public UGizmoLocalFloatParameterSource ForwardIntervalSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ForwardIntervalSource, __ReturnBuffer);

					return *(UGizmoLocalFloatParameterSource*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ForwardIntervalSource, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.MeshSpaceDeformerTool");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Settings = 0;

		private static uint __ToolActions = 0;

		private static uint __StateTarget = 0;

		private static uint __DragAlignmentMechanic = 0;

		private static uint __Preview = 0;

		private static uint __OriginalMeshPreview = 0;

		private static uint __IntervalGizmo = 0;

		private static uint __TransformGizmo = 0;

		private static uint __TransformProxy = 0;

		private static uint __UpIntervalSource = 0;

		private static uint __DownIntervalSource = 0;

		private static uint __ForwardIntervalSource = 0;
	}
}