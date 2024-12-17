using Script.CoreUObject;
using Script.ViewportInteraction;
using Script.UMG;
using Script.Library;

namespace Script.VREditor
{
	[PathName("/Script/VREditor.VREditorPlacement")]
	public partial class UVREditorPlacement : UObject, IStaticClass
	{
		public UVREditorMode VRMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VRMode, __ReturnBuffer);

					return *(UVREditorMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VRMode, __InBuffer);
				}
			}
		}

		public UViewportWorldInteraction ViewportWorldInteraction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ViewportWorldInteraction, __ReturnBuffer);

					return *(UViewportWorldInteraction*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ViewportWorldInteraction, __InBuffer);
				}
			}
		}

		public UWidgetComponent FloatingUIAssetDraggedFrom
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FloatingUIAssetDraggedFrom, __ReturnBuffer);

					return *(UWidgetComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FloatingUIAssetDraggedFrom, __InBuffer);
				}
			}
		}

		public UObject PlacingMaterialOrTextureAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlacingMaterialOrTextureAsset, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlacingMaterialOrTextureAsset, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VREditor.VREditorPlacement");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __VRMode = 0;

		private static uint __ViewportWorldInteraction = 0;

		private static uint __FloatingUIAssetDraggedFrom = 0;

		private static uint __PlacingMaterialOrTextureAsset = 0;
	}
}