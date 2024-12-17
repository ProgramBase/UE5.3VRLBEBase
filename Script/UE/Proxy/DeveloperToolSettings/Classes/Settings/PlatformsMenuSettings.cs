using Script.CoreUObject;
using Script.Library;

namespace Script.DeveloperToolSettings
{
	[PathName("/Script/DeveloperToolSettings.PlatformsMenuSettings")]
	public partial class UPlatformsMenuSettings : UObject, IStaticClass
	{
		public FDirectoryPath StagingDirectory
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StagingDirectory, __ReturnBuffer);

					return *(FDirectoryPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StagingDirectory, __InBuffer);
				}
			}
		}

		public FString LaunchOnTarget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LaunchOnTarget, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LaunchOnTarget, __InBuffer);
				}
			}
		}

		public TMap<FName, EProjectPackagingBuildConfigurations> PerPlatformBuildConfig
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PerPlatformBuildConfig, __ReturnBuffer);

					return *(TMap<FName, EProjectPackagingBuildConfigurations>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PerPlatformBuildConfig, __InBuffer);
				}
			}
		}

		public TMap<FName, FName> PerPlatformTargetFlavorName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PerPlatformTargetFlavorName, __ReturnBuffer);

					return *(TMap<FName, FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PerPlatformTargetFlavorName, __InBuffer);
				}
			}
		}

		public TMap<FName, FString> PerPlatformBuildTarget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PerPlatformBuildTarget, __ReturnBuffer);

					return *(TMap<FName, FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PerPlatformBuildTarget, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DeveloperToolSettings.PlatformsMenuSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __StagingDirectory = 0;

		private static uint __LaunchOnTarget = 0;

		private static uint __PerPlatformBuildConfig = 0;

		private static uint __PerPlatformTargetFlavorName = 0;

		private static uint __PerPlatformBuildTarget = 0;
	}
}