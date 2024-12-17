using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.ModelingComponents;
using Script.Engine;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.UVEditorMeshSelectionMechanic")]
	public partial class UUVEditorMeshSelectionMechanic : UInteractionMechanic, IStaticClass
	{
		public UUVToolSelectionAPI SelectionAPI
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SelectionAPI, __ReturnBuffer);

					return *(UUVToolSelectionAPI*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SelectionAPI, __InBuffer);
				}
			}
		}

		public UUVToolViewportButtonsAPI ViewportButtonsAPI
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ViewportButtonsAPI, __ReturnBuffer);

					return *(UUVToolViewportButtonsAPI*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ViewportButtonsAPI, __InBuffer);
				}
			}
		}

		public UUVToolEmitChangeAPI EmitChangeAPI
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EmitChangeAPI, __ReturnBuffer);

					return *(UUVToolEmitChangeAPI*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EmitChangeAPI, __InBuffer);
				}
			}
		}

		public UUVToolLivePreviewAPI LivePreviewAPI
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LivePreviewAPI, __ReturnBuffer);

					return *(UUVToolLivePreviewAPI*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LivePreviewAPI, __InBuffer);
				}
			}
		}

		public ULocalSingleClickInputBehavior UnwrapClickTargetRouter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UnwrapClickTargetRouter, __ReturnBuffer);

					return *(ULocalSingleClickInputBehavior*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UnwrapClickTargetRouter, __InBuffer);
				}
			}
		}

		public ULocalSingleClickInputBehavior LivePreviewClickTargetRouter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LivePreviewClickTargetRouter, __ReturnBuffer);

					return *(ULocalSingleClickInputBehavior*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LivePreviewClickTargetRouter, __InBuffer);
				}
			}
		}

		public ULocalMouseHoverBehavior UnwrapHoverBehaviorTargetRouter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UnwrapHoverBehaviorTargetRouter, __ReturnBuffer);

					return *(ULocalMouseHoverBehavior*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UnwrapHoverBehaviorTargetRouter, __InBuffer);
				}
			}
		}

		public ULocalMouseHoverBehavior LivePreviewHoverBehaviorTargetRouter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LivePreviewHoverBehaviorTargetRouter, __ReturnBuffer);

					return *(ULocalMouseHoverBehavior*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LivePreviewHoverBehaviorTargetRouter, __InBuffer);
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

		public URectangleMarqueeMechanic LivePreviewMarqueeMechanic
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LivePreviewMarqueeMechanic, __ReturnBuffer);

					return *(URectangleMarqueeMechanic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LivePreviewMarqueeMechanic, __InBuffer);
				}
			}
		}

		public UMaterialInstanceDynamic HoverTriangleSetMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HoverTriangleSetMaterial, __ReturnBuffer);

					return *(UMaterialInstanceDynamic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HoverTriangleSetMaterial, __InBuffer);
				}
			}
		}

		public APreviewGeometryActor HoverGeometryActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HoverGeometryActor, __ReturnBuffer);

					return *(APreviewGeometryActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HoverGeometryActor, __InBuffer);
				}
			}
		}

		public UInputBehaviorSet LivePreviewBehaviorSet
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LivePreviewBehaviorSet, __ReturnBuffer);

					return *(UInputBehaviorSet*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LivePreviewBehaviorSet, __InBuffer);
				}
			}
		}

		public ULocalInputBehaviorSource LivePreviewBehaviorSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LivePreviewBehaviorSource, __ReturnBuffer);

					return *(ULocalInputBehaviorSource*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LivePreviewBehaviorSource, __InBuffer);
				}
			}
		}

		public APreviewGeometryActor LivePreviewHoverGeometryActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LivePreviewHoverGeometryActor, __ReturnBuffer);

					return *(APreviewGeometryActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LivePreviewHoverGeometryActor, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.UVEditorMeshSelectionMechanic");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SelectionAPI = 0;

		private static uint __ViewportButtonsAPI = 0;

		private static uint __EmitChangeAPI = 0;

		private static uint __LivePreviewAPI = 0;

		private static uint __UnwrapClickTargetRouter = 0;

		private static uint __LivePreviewClickTargetRouter = 0;

		private static uint __UnwrapHoverBehaviorTargetRouter = 0;

		private static uint __LivePreviewHoverBehaviorTargetRouter = 0;

		private static uint __MarqueeMechanic = 0;

		private static uint __LivePreviewMarqueeMechanic = 0;

		private static uint __HoverTriangleSetMaterial = 0;

		private static uint __HoverGeometryActor = 0;

		private static uint __LivePreviewBehaviorSet = 0;

		private static uint __LivePreviewBehaviorSource = 0;

		private static uint __LivePreviewHoverGeometryActor = 0;
	}
}