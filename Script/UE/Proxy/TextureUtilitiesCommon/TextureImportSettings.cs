using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.TextureUtilitiesCommon
{
	[PathName("/Script/TextureUtilitiesCommon.TextureImportSettings")]
	public partial class UTextureImportSettings : UDeveloperSettings, IStaticClass
	{
		public int AutoVTSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AutoVTSize, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AutoVTSize, __InBuffer);
				}
			}
		}

		public bool bEnableNormalizeNormals
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableNormalizeNormals, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableNormalizeNormals, __InBuffer);
				}
			}
		}

		public bool bEnableFastMipFilter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableFastMipFilter, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableFastMipFilter, __InBuffer);
				}
			}
		}

		public ETextureImportFloatingPointFormat CompressedFormatForFloatTextures
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CompressedFormatForFloatTextures, __ReturnBuffer);

					return *(ETextureImportFloatingPointFormat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CompressedFormatForFloatTextures, __InBuffer);
				}
			}
		}

		public ETextureImportPNGInfill PNGInfill
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PNGInfill, __ReturnBuffer);

					return *(ETextureImportPNGInfill*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PNGInfill, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TextureUtilitiesCommon.TextureImportSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __AutoVTSize = 0;

		private static uint __bEnableNormalizeNormals = 0;

		private static uint __bEnableFastMipFilter = 0;

		private static uint __CompressedFormatForFloatTextures = 0;

		private static uint __PNGInfill = 0;
	}
}