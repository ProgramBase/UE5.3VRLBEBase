using Script.CoreUObject;
using Script.ModelingComponents;
using Script.MeshModelingToolsExp;
using Script.Engine;
using Script.Library;

namespace Script.MeshLODToolset
{
	[PathName("/Script/MeshLODToolset.GenerateStaticMeshLODAssetTool")]
	public partial class UGenerateStaticMeshLODAssetTool : UMultiSelectionMeshEditingTool, IStaticClass
	{
		public UGenerateStaticMeshLODAssetToolOutputProperties OutputProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OutputProperties, __ReturnBuffer);

					return *(UGenerateStaticMeshLODAssetToolOutputProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OutputProperties, __InBuffer);
				}
			}
		}

		public UGenerateStaticMeshLODAssetToolProperties BasicProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BasicProperties, __ReturnBuffer);

					return *(UGenerateStaticMeshLODAssetToolProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BasicProperties, __InBuffer);
				}
			}
		}

		public UGenerateStaticMeshLODAssetToolPresetProperties PresetProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PresetProperties, __ReturnBuffer);

					return *(UGenerateStaticMeshLODAssetToolPresetProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PresetProperties, __InBuffer);
				}
			}
		}

		public UGenerateStaticMeshLODAssetToolTextureProperties TextureProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TextureProperties, __ReturnBuffer);

					return *(UGenerateStaticMeshLODAssetToolTextureProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TextureProperties, __InBuffer);
				}
			}
		}

		public UCollisionGeometryVisualizationProperties CollisionVizSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CollisionVizSettings, __ReturnBuffer);

					return *(UCollisionGeometryVisualizationProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CollisionVizSettings, __InBuffer);
				}
			}
		}

		public UMeshOpPreviewWithBackgroundCompute PreviewWithBackgroundCompute
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewWithBackgroundCompute, __ReturnBuffer);

					return *(UMeshOpPreviewWithBackgroundCompute*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewWithBackgroundCompute, __InBuffer);
				}
			}
		}

		public TArray<UTexture2D> PreviewTextures
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewTextures, __ReturnBuffer);

					return *(TArray<UTexture2D>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewTextures, __InBuffer);
				}
			}
		}

		public TArray<UMaterialInterface> PreviewMaterials
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewMaterials, __ReturnBuffer);

					return *(TArray<UMaterialInterface>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewMaterials, __InBuffer);
				}
			}
		}

		public UPhysicsObjectToolPropertySet ObjectData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ObjectData, __ReturnBuffer);

					return *(UPhysicsObjectToolPropertySet*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ObjectData, __InBuffer);
				}
			}
		}

		public UPreviewGeometry CollisionPreview
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CollisionPreview, __ReturnBuffer);

					return *(UPreviewGeometry*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CollisionPreview, __InBuffer);
				}
			}
		}

		public UGenerateStaticMeshLODProcess GenerateProcess
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GenerateProcess, __ReturnBuffer);

					return *(UGenerateStaticMeshLODProcess*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GenerateProcess, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshLODToolset.GenerateStaticMeshLODAssetTool");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __OutputProperties = 0;

		private static uint __BasicProperties = 0;

		private static uint __PresetProperties = 0;

		private static uint __TextureProperties = 0;

		private static uint __CollisionVizSettings = 0;

		private static uint __PreviewWithBackgroundCompute = 0;

		private static uint __PreviewTextures = 0;

		private static uint __PreviewMaterials = 0;

		private static uint __ObjectData = 0;

		private static uint __CollisionPreview = 0;

		private static uint __GenerateProcess = 0;
	}
}