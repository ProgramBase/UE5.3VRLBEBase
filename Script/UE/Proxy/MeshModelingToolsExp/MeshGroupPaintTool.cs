using Script.CoreUObject;
using Script.ModelingComponents;
using Script.InteractiveToolsFramework;
using Script.GeometryFramework;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.MeshGroupPaintTool")]
	public partial class UMeshGroupPaintTool : UMeshSculptToolBase, IStaticClass
	{
		public UPolygroupLayersProperties PolygroupLayerProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PolygroupLayerProperties, __ReturnBuffer);

					return *(UPolygroupLayersProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PolygroupLayerProperties, __InBuffer);
				}
			}
		}

		public UGroupPaintBrushFilterProperties FilterProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FilterProperties, __ReturnBuffer);

					return *(UGroupPaintBrushFilterProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FilterProperties, __InBuffer);
				}
			}
		}

		public UGroupPaintBrushOpProps PaintBrushOpProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PaintBrushOpProperties, __ReturnBuffer);

					return *(UGroupPaintBrushOpProps*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PaintBrushOpProperties, __InBuffer);
				}
			}
		}

		public UGroupEraseBrushOpProps EraseBrushOpProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EraseBrushOpProperties, __ReturnBuffer);

					return *(UGroupEraseBrushOpProps*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EraseBrushOpProperties, __InBuffer);
				}
			}
		}

		public UMeshGroupPaintToolFreezeActions FreezeActions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FreezeActions, __ReturnBuffer);

					return *(UMeshGroupPaintToolFreezeActions*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FreezeActions, __InBuffer);
				}
			}
		}

		public UPolyLassoMarqueeMechanic PolyLassoMechanic
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PolyLassoMechanic, __ReturnBuffer);

					return *(UPolyLassoMarqueeMechanic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PolyLassoMechanic, __InBuffer);
				}
			}
		}

		public AInternalToolFrameworkActor PreviewMeshActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewMeshActor, __ReturnBuffer);

					return *(AInternalToolFrameworkActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewMeshActor, __InBuffer);
				}
			}
		}

		public UDynamicMeshComponent DynamicMeshComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DynamicMeshComponent, __ReturnBuffer);

					return *(UDynamicMeshComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DynamicMeshComponent, __InBuffer);
				}
			}
		}

		public UMeshElementsVisualizer MeshElementsDisplay
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MeshElementsDisplay, __ReturnBuffer);

					return *(UMeshElementsVisualizer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MeshElementsDisplay, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.MeshGroupPaintTool");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PolygroupLayerProperties = 0;

		private static uint __FilterProperties = 0;

		private static uint __PaintBrushOpProperties = 0;

		private static uint __EraseBrushOpProperties = 0;

		private static uint __FreezeActions = 0;

		private static uint __PolyLassoMechanic = 0;

		private static uint __PreviewMeshActor = 0;

		private static uint __DynamicMeshComponent = 0;

		private static uint __MeshElementsDisplay = 0;
	}
}