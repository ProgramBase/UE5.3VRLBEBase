using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.DeveloperToolSettings
{
	[PathName("/Script/DeveloperToolSettings.CookerSettings")]
	public partial class UCookerSettings : UDeveloperSettings, IStaticClass
	{
		public bool bEnableCookOnTheSide
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableCookOnTheSide, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableCookOnTheSide, __InBuffer);
				}
			}
		}

		public bool bEnableBuildDDCInBackground
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableBuildDDCInBackground, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableBuildDDCInBackground, __InBuffer);
				}
			}
		}

		public bool bIterativeCookingForLaunchOn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIterativeCookingForLaunchOn, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIterativeCookingForLaunchOn, __InBuffer);
				}
			}
		}

		public bool bIterativeCookingForFileCookContent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIterativeCookingForFileCookContent, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIterativeCookingForFileCookContent, __InBuffer);
				}
			}
		}

		public bool bCookOnTheFlyForLaunchOn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCookOnTheFlyForLaunchOn, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCookOnTheFlyForLaunchOn, __InBuffer);
				}
			}
		}

		public ECookProgressDisplayMode CookProgressDisplayMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CookProgressDisplayMode, __ReturnBuffer);

					return *(ECookProgressDisplayMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CookProgressDisplayMode, __InBuffer);
				}
			}
		}

		public bool bIgnoreIniSettingsOutOfDateForIteration
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIgnoreIniSettingsOutOfDateForIteration, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIgnoreIniSettingsOutOfDateForIteration, __InBuffer);
				}
			}
		}

		public bool bIgnoreScriptPackagesOutOfDateForIteration
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIgnoreScriptPackagesOutOfDateForIteration, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIgnoreScriptPackagesOutOfDateForIteration, __InBuffer);
				}
			}
		}

		public bool bCompileBlueprintsInDevelopmentMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCompileBlueprintsInDevelopmentMode, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCompileBlueprintsInDevelopmentMode, __InBuffer);
				}
			}
		}

		public EBlueprintComponentDataCookingMethod BlueprintComponentDataCookingMethod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BlueprintComponentDataCookingMethod, __ReturnBuffer);

					return *(EBlueprintComponentDataCookingMethod*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BlueprintComponentDataCookingMethod, __InBuffer);
				}
			}
		}

		public EBlueprintPropertyGuidsCookingMethod BlueprintPropertyGuidsCookingMethod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BlueprintPropertyGuidsCookingMethod, __ReturnBuffer);

					return *(EBlueprintPropertyGuidsCookingMethod*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BlueprintPropertyGuidsCookingMethod, __InBuffer);
				}
			}
		}

		public TArray<FString> ClassesExcludedOnDedicatedServer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ClassesExcludedOnDedicatedServer, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ClassesExcludedOnDedicatedServer, __InBuffer);
				}
			}
		}

		public TArray<FString> ModulesExcludedOnDedicatedServer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ModulesExcludedOnDedicatedServer, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ModulesExcludedOnDedicatedServer, __InBuffer);
				}
			}
		}

		public TArray<FString> ClassesExcludedOnDedicatedClient
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ClassesExcludedOnDedicatedClient, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ClassesExcludedOnDedicatedClient, __InBuffer);
				}
			}
		}

		public TArray<FString> ModulesExcludedOnDedicatedClient
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ModulesExcludedOnDedicatedClient, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ModulesExcludedOnDedicatedClient, __InBuffer);
				}
			}
		}

		public TArray<FString> VersionedIntRValues
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VersionedIntRValues, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VersionedIntRValues, __InBuffer);
				}
			}
		}

		public int DefaultASTCQualityBySpeed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultASTCQualityBySpeed, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultASTCQualityBySpeed, __InBuffer);
				}
			}
		}

		public int DefaultASTCQualityBySize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultASTCQualityBySize, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultASTCQualityBySize, __InBuffer);
				}
			}
		}

		public ETextureFormatASTCCompressor DefaultASTCCompressor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultASTCCompressor, __ReturnBuffer);

					return *(ETextureFormatASTCCompressor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultASTCCompressor, __InBuffer);
				}
			}
		}

		public bool bAllowASTCHDRProfile
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowASTCHDRProfile, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowASTCHDRProfile, __InBuffer);
				}
			}
		}

		public bool bAllowCookedDataInEditorBuilds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowCookedDataInEditorBuilds, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowCookedDataInEditorBuilds, __InBuffer);
				}
			}
		}

		public bool bCookBlueprintComponentTemplateData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCookBlueprintComponentTemplateData, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCookBlueprintComponentTemplateData, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DeveloperToolSettings.CookerSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bEnableCookOnTheSide = 0;

		private static uint __bEnableBuildDDCInBackground = 0;

		private static uint __bIterativeCookingForLaunchOn = 0;

		private static uint __bIterativeCookingForFileCookContent = 0;

		private static uint __bCookOnTheFlyForLaunchOn = 0;

		private static uint __CookProgressDisplayMode = 0;

		private static uint __bIgnoreIniSettingsOutOfDateForIteration = 0;

		private static uint __bIgnoreScriptPackagesOutOfDateForIteration = 0;

		private static uint __bCompileBlueprintsInDevelopmentMode = 0;

		private static uint __BlueprintComponentDataCookingMethod = 0;

		private static uint __BlueprintPropertyGuidsCookingMethod = 0;

		private static uint __ClassesExcludedOnDedicatedServer = 0;

		private static uint __ModulesExcludedOnDedicatedServer = 0;

		private static uint __ClassesExcludedOnDedicatedClient = 0;

		private static uint __ModulesExcludedOnDedicatedClient = 0;

		private static uint __VersionedIntRValues = 0;

		private static uint __DefaultASTCQualityBySpeed = 0;

		private static uint __DefaultASTCQualityBySize = 0;

		private static uint __DefaultASTCCompressor = 0;

		private static uint __bAllowASTCHDRProfile = 0;

		private static uint __bAllowCookedDataInEditorBuilds = 0;

		private static uint __bCookBlueprintComponentTemplateData = 0;
	}
}