using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.DDCProjectSettings")]
	public partial class UDDCProjectSettings : UDeveloperSettings, IStaticClass
	{
		public bool EnableWarnings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EnableWarnings, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EnableWarnings, __InBuffer);
				}
			}
		}

		public bool RecommendEveryoneSetupAGlobalLocalDDCPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RecommendEveryoneSetupAGlobalLocalDDCPath, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RecommendEveryoneSetupAGlobalLocalDDCPath, __InBuffer);
				}
			}
		}

		public bool RecommendEveryoneSetupAGlobalSharedDDCPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RecommendEveryoneSetupAGlobalSharedDDCPath, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RecommendEveryoneSetupAGlobalSharedDDCPath, __InBuffer);
				}
			}
		}

		public bool RecommendEveryoneSetupAGlobalS3DDCPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RecommendEveryoneSetupAGlobalS3DDCPath, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RecommendEveryoneSetupAGlobalS3DDCPath, __InBuffer);
				}
			}
		}

		public bool RecommendEveryoneEnableS3DDC
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RecommendEveryoneEnableS3DDC, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RecommendEveryoneEnableS3DDC, __InBuffer);
				}
			}
		}

		public bool RecommendEveryoneUseUnrealCloudDDC
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RecommendEveryoneUseUnrealCloudDDC, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RecommendEveryoneUseUnrealCloudDDC, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.DDCProjectSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __EnableWarnings = 0;

		private static uint __RecommendEveryoneSetupAGlobalLocalDDCPath = 0;

		private static uint __RecommendEveryoneSetupAGlobalSharedDDCPath = 0;

		private static uint __RecommendEveryoneSetupAGlobalS3DDCPath = 0;

		private static uint __RecommendEveryoneEnableS3DDC = 0;

		private static uint __RecommendEveryoneUseUnrealCloudDDC = 0;
	}
}