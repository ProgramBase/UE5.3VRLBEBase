using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.HierarchicalLODSettings")]
	public partial class UHierarchicalLODSettings : UDeveloperSettings, IStaticClass
	{
		public bool bForceSettingsInAllMaps
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bForceSettingsInAllMaps, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bForceSettingsInAllMaps, __InBuffer);
				}
			}
		}

		public bool bSaveLODActorsToHLODPackages
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSaveLODActorsToHLODPackages, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSaveLODActorsToHLODPackages, __InBuffer);
				}
			}
		}

		public TSoftClassPtr<UHierarchicalLODSetup> DefaultSetup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultSetup, __ReturnBuffer);

					return *(TSoftClassPtr<UHierarchicalLODSetup>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultSetup, __InBuffer);
				}
			}
		}

		public TArray<FDirectoryPath> DirectoriesForHLODCommandlet
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DirectoriesForHLODCommandlet, __ReturnBuffer);

					return *(TArray<FDirectoryPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DirectoriesForHLODCommandlet, __InBuffer);
				}
			}
		}

		public TArray<FFilePath> MapsToBuild
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MapsToBuild, __ReturnBuffer);

					return *(TArray<FFilePath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MapsToBuild, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<UMaterialInterface> BaseMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BaseMaterial, __ReturnBuffer);

					return *(TSoftObjectPtr<UMaterialInterface>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BaseMaterial, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.HierarchicalLODSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bForceSettingsInAllMaps = 0;

		private static uint __bSaveLODActorsToHLODPackages = 0;

		private static uint __DefaultSetup = 0;

		private static uint __DirectoriesForHLODCommandlet = 0;

		private static uint __MapsToBuild = 0;

		private static uint __BaseMaterial = 0;
	}
}