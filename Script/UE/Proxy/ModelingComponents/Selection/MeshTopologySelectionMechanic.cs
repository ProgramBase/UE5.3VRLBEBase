using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Engine;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.MeshTopologySelectionMechanic")]
	public partial class UMeshTopologySelectionMechanic : UInteractionMechanic, IStaticClass
	{
		public UMeshTopologySelectionMechanicProperties Properties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Properties, __ReturnBuffer);

					return *(UMeshTopologySelectionMechanicProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Properties, __InBuffer);
				}
			}
		}

		public UMouseHoverBehavior HoverBehavior
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HoverBehavior, __ReturnBuffer);

					return *(UMouseHoverBehavior*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HoverBehavior, __InBuffer);
				}
			}
		}

		public USingleClickOrDragInputBehavior ClickOrDragBehavior
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ClickOrDragBehavior, __ReturnBuffer);

					return *(USingleClickOrDragInputBehavior*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ClickOrDragBehavior, __InBuffer);
				}
			}
		}

		public URectangleMarqueeMechanic MarqueeMechanic
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MarqueeMechanic, __ReturnBuffer);

					return *(URectangleMarqueeMechanic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MarqueeMechanic, __InBuffer);
				}
			}
		}

		public APreviewGeometryActor PreviewGeometryActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewGeometryActor, __ReturnBuffer);

					return *(APreviewGeometryActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewGeometryActor, __InBuffer);
				}
			}
		}

		public UTriangleSetComponent DrawnTriangleSetComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DrawnTriangleSetComponent, __ReturnBuffer);

					return *(UTriangleSetComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DrawnTriangleSetComponent, __InBuffer);
				}
			}
		}

		public UMaterialInterface HighlightedFaceMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HighlightedFaceMaterial, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HighlightedFaceMaterial, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.MeshTopologySelectionMechanic");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Properties = 0;

		private static uint __HoverBehavior = 0;

		private static uint __ClickOrDragBehavior = 0;

		private static uint __MarqueeMechanic = 0;

		private static uint __PreviewGeometryActor = 0;

		private static uint __DrawnTriangleSetComponent = 0;

		private static uint __HighlightedFaceMaterial = 0;
	}
}