using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.ModelingComponents;
using Script.Engine;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.UVToolSelectionHighlightMechanic")]
	public partial class UUVToolSelectionHighlightMechanic : UInteractionMechanic, IStaticClass
	{
		public APreviewGeometryActor UnwrapGeometryActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UnwrapGeometryActor, __ReturnBuffer);

					return *(APreviewGeometryActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UnwrapGeometryActor, __InBuffer);
				}
			}
		}

		public UMaterialInstanceDynamic TriangleSetMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TriangleSetMaterial, __ReturnBuffer);

					return *(UMaterialInstanceDynamic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TriangleSetMaterial, __InBuffer);
				}
			}
		}

		public APreviewGeometryActor UnwrapStationaryGeometryActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UnwrapStationaryGeometryActor, __ReturnBuffer);

					return *(APreviewGeometryActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UnwrapStationaryGeometryActor, __InBuffer);
				}
			}
		}

		public APreviewGeometryActor LivePreviewGeometryActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LivePreviewGeometryActor, __ReturnBuffer);

					return *(APreviewGeometryActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LivePreviewGeometryActor, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.UVToolSelectionHighlightMechanic");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __UnwrapGeometryActor = 0;

		private static uint __TriangleSetMaterial = 0;

		private static uint __UnwrapStationaryGeometryActor = 0;

		private static uint __LivePreviewGeometryActor = 0;
	}
}