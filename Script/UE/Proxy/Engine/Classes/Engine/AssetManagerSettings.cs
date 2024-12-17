using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AssetManagerSettings")]
	public partial class UAssetManagerSettings : UDeveloperSettings, IStaticClass
	{
		public TArray<FPrimaryAssetTypeInfo> PrimaryAssetTypesToScan
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PrimaryAssetTypesToScan, __ReturnBuffer);

					return *(TArray<FPrimaryAssetTypeInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PrimaryAssetTypesToScan, __InBuffer);
				}
			}
		}

		public TArray<FDirectoryPath> DirectoriesToExclude
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DirectoriesToExclude, __ReturnBuffer);

					return *(TArray<FDirectoryPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DirectoriesToExclude, __InBuffer);
				}
			}
		}

		public TArray<FPrimaryAssetRulesOverride> PrimaryAssetRules
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PrimaryAssetRules, __ReturnBuffer);

					return *(TArray<FPrimaryAssetRulesOverride>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PrimaryAssetRules, __InBuffer);
				}
			}
		}

		public TArray<FPrimaryAssetRulesCustomOverride> CustomPrimaryAssetRules
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CustomPrimaryAssetRules, __ReturnBuffer);

					return *(TArray<FPrimaryAssetRulesCustomOverride>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CustomPrimaryAssetRules, __InBuffer);
				}
			}
		}

		public bool bOnlyCookProductionAssets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOnlyCookProductionAssets, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOnlyCookProductionAssets, __InBuffer);
				}
			}
		}

		public bool bShouldManagerDetermineTypeAndName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldManagerDetermineTypeAndName, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldManagerDetermineTypeAndName, __InBuffer);
				}
			}
		}

		public bool bShouldGuessTypeAndNameInEditor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldGuessTypeAndNameInEditor, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldGuessTypeAndNameInEditor, __InBuffer);
				}
			}
		}

		public bool bShouldAcquireMissingChunksOnLoad
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldAcquireMissingChunksOnLoad, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldAcquireMissingChunksOnLoad, __InBuffer);
				}
			}
		}

		public bool bShouldWarnAboutInvalidAssets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldWarnAboutInvalidAssets, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldWarnAboutInvalidAssets, __InBuffer);
				}
			}
		}

		public TArray<FAssetManagerRedirect> PrimaryAssetIdRedirects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PrimaryAssetIdRedirects, __ReturnBuffer);

					return *(TArray<FAssetManagerRedirect>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PrimaryAssetIdRedirects, __InBuffer);
				}
			}
		}

		public TArray<FAssetManagerRedirect> PrimaryAssetTypeRedirects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PrimaryAssetTypeRedirects, __ReturnBuffer);

					return *(TArray<FAssetManagerRedirect>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PrimaryAssetTypeRedirects, __InBuffer);
				}
			}
		}

		public TArray<FAssetManagerRedirect> AssetPathRedirects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AssetPathRedirects, __ReturnBuffer);

					return *(TArray<FAssetManagerRedirect>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AssetPathRedirects, __InBuffer);
				}
			}
		}

		public TSet<FName> MetaDataTagsForAssetRegistry
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MetaDataTagsForAssetRegistry, __ReturnBuffer);

					return *(TSet<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MetaDataTagsForAssetRegistry, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AssetManagerSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PrimaryAssetTypesToScan = 0;

		private static uint __DirectoriesToExclude = 0;

		private static uint __PrimaryAssetRules = 0;

		private static uint __CustomPrimaryAssetRules = 0;

		private static uint __bOnlyCookProductionAssets = 0;

		private static uint __bShouldManagerDetermineTypeAndName = 0;

		private static uint __bShouldGuessTypeAndNameInEditor = 0;

		private static uint __bShouldAcquireMissingChunksOnLoad = 0;

		private static uint __bShouldWarnAboutInvalidAssets = 0;

		private static uint __PrimaryAssetIdRedirects = 0;

		private static uint __PrimaryAssetTypeRedirects = 0;

		private static uint __AssetPathRedirects = 0;

		private static uint __MetaDataTagsForAssetRegistry = 0;
	}
}