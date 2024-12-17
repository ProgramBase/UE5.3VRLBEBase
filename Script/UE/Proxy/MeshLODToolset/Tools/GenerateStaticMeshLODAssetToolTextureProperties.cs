using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;
using Script.Engine;

namespace Script.MeshLODToolset
{
	[PathName("/Script/MeshLODToolset.GenerateStaticMeshLODAssetToolTextureProperties")]
	public partial class UGenerateStaticMeshLODAssetToolTextureProperties : UInteractiveToolPropertySet, IStaticClass
	{
		public TArray<FGenerateStaticMeshLOD_MaterialConfig> Materials
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Materials, __ReturnBuffer);

					return *(TArray<FGenerateStaticMeshLOD_MaterialConfig>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Materials, __InBuffer);
				}
			}
		}

		public TArray<FGenerateStaticMeshLOD_TextureConfig> Textures
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Textures, __ReturnBuffer);

					return *(TArray<FGenerateStaticMeshLOD_TextureConfig>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Textures, __InBuffer);
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

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshLODToolset.GenerateStaticMeshLODAssetToolTextureProperties");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Materials = 0;

		private static uint __Textures = 0;

		private static uint __PreviewTextures = 0;
	}
}