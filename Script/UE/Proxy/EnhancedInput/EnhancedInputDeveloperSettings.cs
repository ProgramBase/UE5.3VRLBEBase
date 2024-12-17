using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.EnhancedInputDeveloperSettings")]
	public partial class UEnhancedInputDeveloperSettings : UDeveloperSettingsBackedByCVars, IStaticClass
	{
		public TArray<FDefaultContextSetting> DefaultMappingContexts
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultMappingContexts, __ReturnBuffer);

					return *(TArray<FDefaultContextSetting>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultMappingContexts, __InBuffer);
				}
			}
		}

		public TArray<FDefaultContextSetting> DefaultWorldSubsystemMappingContexts
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultWorldSubsystemMappingContexts, __ReturnBuffer);

					return *(TArray<FDefaultContextSetting>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultWorldSubsystemMappingContexts, __InBuffer);
				}
			}
		}

		public FPerPlatformSettings PlatformSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlatformSettings, __ReturnBuffer);

					return *(FPerPlatformSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlatformSettings, __InBuffer);
				}
			}
		}

		public TSoftClassPtr<UEnhancedInputUserSettings> UserSettingsClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UserSettingsClass, __ReturnBuffer);

					return *(TSoftClassPtr<UEnhancedInputUserSettings>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UserSettingsClass, __InBuffer);
				}
			}
		}

		public TSoftClassPtr<UEnhancedPlayerMappableKeyProfile> DefaultPlayerMappableKeyProfileClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultPlayerMappableKeyProfileClass, __ReturnBuffer);

					return *(TSoftClassPtr<UEnhancedPlayerMappableKeyProfile>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultPlayerMappableKeyProfileClass, __InBuffer);
				}
			}
		}

		public TSoftClassPtr<UEnhancedPlayerInput> DefaultWorldInputClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultWorldInputClass, __ReturnBuffer);

					return *(TSoftClassPtr<UEnhancedPlayerInput>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultWorldInputClass, __InBuffer);
				}
			}
		}

		public bool bSendTriggeredEventsWhenInputIsFlushed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSendTriggeredEventsWhenInputIsFlushed, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSendTriggeredEventsWhenInputIsFlushed, __InBuffer);
				}
			}
		}

		public bool bEnableUserSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableUserSettings, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableUserSettings, __InBuffer);
				}
			}
		}

		public bool bEnableDefaultMappingContexts
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableDefaultMappingContexts, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableDefaultMappingContexts, __InBuffer);
				}
			}
		}

		public bool bShouldOnlyTriggerLastActionInChord
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldOnlyTriggerLastActionInChord, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldOnlyTriggerLastActionInChord, __InBuffer);
				}
			}
		}

		public bool bLogOnDeprecatedConfigUsed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bLogOnDeprecatedConfigUsed, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bLogOnDeprecatedConfigUsed, __InBuffer);
				}
			}
		}

		public bool bEnableWorldSubsystem
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableWorldSubsystem, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableWorldSubsystem, __InBuffer);
				}
			}
		}

		public bool bShouldLogAllWorldSubsystemInputs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldLogAllWorldSubsystemInputs, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldLogAllWorldSubsystemInputs, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnhancedInput.EnhancedInputDeveloperSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DefaultMappingContexts = 0;

		private static uint __DefaultWorldSubsystemMappingContexts = 0;

		private static uint __PlatformSettings = 0;

		private static uint __UserSettingsClass = 0;

		private static uint __DefaultPlayerMappableKeyProfileClass = 0;

		private static uint __DefaultWorldInputClass = 0;

		private static uint __bSendTriggeredEventsWhenInputIsFlushed = 0;

		private static uint __bEnableUserSettings = 0;

		private static uint __bEnableDefaultMappingContexts = 0;

		private static uint __bShouldOnlyTriggerLastActionInChord = 0;

		private static uint __bLogOnDeprecatedConfigUsed = 0;

		private static uint __bEnableWorldSubsystem = 0;

		private static uint __bShouldLogAllWorldSubsystemInputs = 0;
	}
}