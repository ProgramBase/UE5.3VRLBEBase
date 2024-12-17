using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.FbxSceneImportFactory")]
	public partial class UFbxSceneImportFactory : USceneImportFactory, IStaticClass
	{
		public UFbxSceneImportOptions SceneImportOptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SceneImportOptions, __ReturnBuffer);

					return *(UFbxSceneImportOptions*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SceneImportOptions, __InBuffer);
				}
			}
		}

		public UFbxSceneImportOptionsStaticMesh SceneImportOptionsStaticMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SceneImportOptionsStaticMesh, __ReturnBuffer);

					return *(UFbxSceneImportOptionsStaticMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SceneImportOptionsStaticMesh, __InBuffer);
				}
			}
		}

		public UFbxSceneImportOptionsSkeletalMesh SceneImportOptionsSkeletalMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SceneImportOptionsSkeletalMesh, __ReturnBuffer);

					return *(UFbxSceneImportOptionsSkeletalMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SceneImportOptionsSkeletalMesh, __InBuffer);
				}
			}
		}

		public UFbxStaticMeshImportData StaticMeshImportData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StaticMeshImportData, __ReturnBuffer);

					return *(UFbxStaticMeshImportData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StaticMeshImportData, __InBuffer);
				}
			}
		}

		public UFbxSkeletalMeshImportData SkeletalMeshImportData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SkeletalMeshImportData, __ReturnBuffer);

					return *(UFbxSkeletalMeshImportData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SkeletalMeshImportData, __InBuffer);
				}
			}
		}

		public UFbxAnimSequenceImportData AnimSequenceImportData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimSequenceImportData, __ReturnBuffer);

					return *(UFbxAnimSequenceImportData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimSequenceImportData, __InBuffer);
				}
			}
		}

		public UFbxTextureImportData TextureImportData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TextureImportData, __ReturnBuffer);

					return *(UFbxTextureImportData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TextureImportData, __InBuffer);
				}
			}
		}

		public UFbxSceneImportData ReimportData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReimportData, __ReturnBuffer);

					return *(UFbxSceneImportData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReimportData, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.FbxSceneImportFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SceneImportOptions = 0;

		private static uint __SceneImportOptionsStaticMesh = 0;

		private static uint __SceneImportOptionsSkeletalMesh = 0;

		private static uint __StaticMeshImportData = 0;

		private static uint __SkeletalMeshImportData = 0;

		private static uint __AnimSequenceImportData = 0;

		private static uint __TextureImportData = 0;

		private static uint __ReimportData = 0;
	}
}