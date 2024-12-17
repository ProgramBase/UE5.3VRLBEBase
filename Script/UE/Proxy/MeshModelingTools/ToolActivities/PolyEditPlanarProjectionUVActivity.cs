using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.PolyEditPlanarProjectionUVActivity")]
	public partial class UPolyEditPlanarProjectionUVActivity : UInteractiveToolActivity, IStaticClass
	{
		public UPolyEditSetUVProperties SetUVProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SetUVProperties, __ReturnBuffer);

					return *(UPolyEditSetUVProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SetUVProperties, __InBuffer);
				}
			}
		}

		public UPolyEditPreviewMesh EditPreview
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EditPreview, __ReturnBuffer);

					return *(UPolyEditPreviewMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EditPreview, __InBuffer);
				}
			}
		}

		public UCollectSurfacePathMechanic SurfacePathMechanic
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SurfacePathMechanic, __ReturnBuffer);

					return *(UCollectSurfacePathMechanic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SurfacePathMechanic, __InBuffer);
				}
			}
		}

		public UPolyEditActivityContext ActivityContext
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActivityContext, __ReturnBuffer);

					return *(UPolyEditActivityContext*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActivityContext, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.PolyEditPlanarProjectionUVActivity");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SetUVProperties = 0;

		private static uint __EditPreview = 0;

		private static uint __SurfacePathMechanic = 0;

		private static uint __ActivityContext = 0;
	}
}