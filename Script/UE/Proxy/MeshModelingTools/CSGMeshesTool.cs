using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;
using Script.Engine;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.CSGMeshesTool")]
	public partial class UCSGMeshesTool : UBaseCreateFromSelectedTool, IStaticClass
	{
		public UCSGMeshesToolProperties CSGProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CSGProperties, __ReturnBuffer);

					return *(UCSGMeshesToolProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CSGProperties, __InBuffer);
				}
			}
		}

		public UTrimMeshesToolProperties TrimProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TrimProperties, __ReturnBuffer);

					return *(UTrimMeshesToolProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TrimProperties, __InBuffer);
				}
			}
		}

		public TArray<UPreviewMesh> OriginalMeshPreviews
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OriginalMeshPreviews, __ReturnBuffer);

					return *(TArray<UPreviewMesh>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OriginalMeshPreviews, __InBuffer);
				}
			}
		}

		public UMaterialInstanceDynamic PreviewsGhostMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewsGhostMaterial, __ReturnBuffer);

					return *(UMaterialInstanceDynamic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewsGhostMaterial, __InBuffer);
				}
			}
		}

		public ULineSetComponent DrawnLineSet
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DrawnLineSet, __ReturnBuffer);

					return *(ULineSetComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DrawnLineSet, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.CSGMeshesTool");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CSGProperties = 0;

		private static uint __TrimProperties = 0;

		private static uint __OriginalMeshPreviews = 0;

		private static uint __PreviewsGhostMaterial = 0;

		private static uint __DrawnLineSet = 0;
	}
}