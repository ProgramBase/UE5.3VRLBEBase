using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.MetasoundFrontend;
using Script.Library;

namespace Script.MetasoundEngine
{
	[PathName("/Script/MetasoundEngine.MetaSoundSettings")]
	public partial class UMetaSoundSettings : UDeveloperSettings, IStaticClass
	{
		public bool bAutoUpdateEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoUpdateEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoUpdateEnabled, __InBuffer);
				}
			}
		}

		public TArray<FMetasoundFrontendClassName> AutoUpdateDenylist
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AutoUpdateDenylist, __ReturnBuffer);

					return *(TArray<FMetasoundFrontendClassName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AutoUpdateDenylist, __InBuffer);
				}
			}
		}

		public TArray<FDefaultMetaSoundAssetAutoUpdateSettings> AutoUpdateAssetDenylist
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AutoUpdateAssetDenylist, __ReturnBuffer);

					return *(TArray<FDefaultMetaSoundAssetAutoUpdateSettings>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AutoUpdateAssetDenylist, __InBuffer);
				}
			}
		}

		public bool bAutoUpdateLogWarningOnDroppedConnection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoUpdateLogWarningOnDroppedConnection, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoUpdateLogWarningOnDroppedConnection, __InBuffer);
				}
			}
		}

		public TArray<FDirectoryPath> DirectoriesToRegister
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DirectoriesToRegister, __ReturnBuffer);

					return *(TArray<FDirectoryPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DirectoriesToRegister, __InBuffer);
				}
			}
		}

		public int DenyListCacheChangeID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DenyListCacheChangeID, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DenyListCacheChangeID, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MetasoundEngine.MetaSoundSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bAutoUpdateEnabled = 0;

		private static uint __AutoUpdateDenylist = 0;

		private static uint __AutoUpdateAssetDenylist = 0;

		private static uint __bAutoUpdateLogWarningOnDroppedConnection = 0;

		private static uint __DirectoriesToRegister = 0;

		private static uint __DenyListCacheChangeID = 0;
	}
}