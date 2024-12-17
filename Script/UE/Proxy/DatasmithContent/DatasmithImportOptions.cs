using Script.CoreUObject;
using Script.Library;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.DatasmithImportOptions")]
	public partial class UDatasmithImportOptions : UDatasmithOptionsBase, IStaticClass
	{
		public EDatasmithImportSearchPackagePolicy SearchPackagePolicy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SearchPackagePolicy, __ReturnBuffer);

					return *(EDatasmithImportSearchPackagePolicy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SearchPackagePolicy, __InBuffer);
				}
			}
		}

		public EDatasmithImportAssetConflictPolicy MaterialConflictPolicy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaterialConflictPolicy, __ReturnBuffer);

					return *(EDatasmithImportAssetConflictPolicy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaterialConflictPolicy, __InBuffer);
				}
			}
		}

		public EDatasmithImportAssetConflictPolicy TextureConflictPolicy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TextureConflictPolicy, __ReturnBuffer);

					return *(EDatasmithImportAssetConflictPolicy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TextureConflictPolicy, __InBuffer);
				}
			}
		}

		public EDatasmithImportActorPolicy StaticMeshActorImportPolicy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StaticMeshActorImportPolicy, __ReturnBuffer);

					return *(EDatasmithImportActorPolicy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StaticMeshActorImportPolicy, __InBuffer);
				}
			}
		}

		public EDatasmithImportActorPolicy LightImportPolicy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LightImportPolicy, __ReturnBuffer);

					return *(EDatasmithImportActorPolicy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LightImportPolicy, __InBuffer);
				}
			}
		}

		public EDatasmithImportActorPolicy CameraImportPolicy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CameraImportPolicy, __ReturnBuffer);

					return *(EDatasmithImportActorPolicy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CameraImportPolicy, __InBuffer);
				}
			}
		}

		public EDatasmithImportActorPolicy OtherActorImportPolicy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OtherActorImportPolicy, __ReturnBuffer);

					return *(EDatasmithImportActorPolicy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OtherActorImportPolicy, __InBuffer);
				}
			}
		}

		public EDatasmithImportMaterialQuality MaterialQuality
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaterialQuality, __ReturnBuffer);

					return *(EDatasmithImportMaterialQuality*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaterialQuality, __InBuffer);
				}
			}
		}

		public FDatasmithImportBaseOptions BaseOptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BaseOptions, __ReturnBuffer);

					return *(FDatasmithImportBaseOptions*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BaseOptions, __InBuffer);
				}
			}
		}

		public FDatasmithReimportOptions ReimportOptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReimportOptions, __ReturnBuffer);

					return *(FDatasmithReimportOptions*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReimportOptions, __InBuffer);
				}
			}
		}

		public FString FileName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FileName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FileName, __InBuffer);
				}
			}
		}

		public FString FilePath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FilePath, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FilePath, __InBuffer);
				}
			}
		}

		public FString SourceUri
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SourceUri, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SourceUri, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DatasmithContent.DatasmithImportOptions");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SearchPackagePolicy = 0;

		private static uint __MaterialConflictPolicy = 0;

		private static uint __TextureConflictPolicy = 0;

		private static uint __StaticMeshActorImportPolicy = 0;

		private static uint __LightImportPolicy = 0;

		private static uint __CameraImportPolicy = 0;

		private static uint __OtherActorImportPolicy = 0;

		private static uint __MaterialQuality = 0;

		private static uint __BaseOptions = 0;

		private static uint __ReimportOptions = 0;

		private static uint __FileName = 0;

		private static uint __FilePath = 0;

		private static uint __SourceUri = 0;
	}
}