using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;
using Script.InputCore;

namespace Script.Engine
{
	[PathName("/Script/Engine.InputSettings")]
	public partial class UInputSettings : UObject, IStaticClass
	{
		public TArray<FInputAxisConfigEntry> AxisConfig
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AxisConfig, __ReturnBuffer);

					return *(TArray<FInputAxisConfigEntry>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AxisConfig, __InBuffer);
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

		public bool bAltEnterTogglesFullscreen
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAltEnterTogglesFullscreen, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAltEnterTogglesFullscreen, __InBuffer);
				}
			}
		}

		public bool bF11TogglesFullscreen
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bF11TogglesFullscreen, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bF11TogglesFullscreen, __InBuffer);
				}
			}
		}

		public bool bUseMouseForTouch
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseMouseForTouch, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseMouseForTouch, __InBuffer);
				}
			}
		}

		public bool bEnableMouseSmoothing
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableMouseSmoothing, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableMouseSmoothing, __InBuffer);
				}
			}
		}

		public bool bEnableFOVScaling
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableFOVScaling, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableFOVScaling, __InBuffer);
				}
			}
		}

		public bool bCaptureMouseOnLaunch
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCaptureMouseOnLaunch, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCaptureMouseOnLaunch, __InBuffer);
				}
			}
		}

		public bool bEnableLegacyInputScales
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableLegacyInputScales, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableLegacyInputScales, __InBuffer);
				}
			}
		}

		public bool bEnableMotionControls
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableMotionControls, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableMotionControls, __InBuffer);
				}
			}
		}

		public bool bFilterInputByPlatformUser
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bFilterInputByPlatformUser, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bFilterInputByPlatformUser, __InBuffer);
				}
			}
		}

		public bool bEnableInputDeviceSubsystem
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableInputDeviceSubsystem, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableInputDeviceSubsystem, __InBuffer);
				}
			}
		}

		public bool bShouldFlushPressedKeysOnViewportFocusLost
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldFlushPressedKeysOnViewportFocusLost, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldFlushPressedKeysOnViewportFocusLost, __InBuffer);
				}
			}
		}

		public bool bEnableDynamicComponentInputBinding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableDynamicComponentInputBinding, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableDynamicComponentInputBinding, __InBuffer);
				}
			}
		}

		public bool bAlwaysShowTouchInterface
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAlwaysShowTouchInterface, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAlwaysShowTouchInterface, __InBuffer);
				}
			}
		}

		public bool bShowConsoleOnFourFingerTap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowConsoleOnFourFingerTap, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowConsoleOnFourFingerTap, __InBuffer);
				}
			}
		}

		public bool bEnableGestureRecognizer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableGestureRecognizer, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableGestureRecognizer, __InBuffer);
				}
			}
		}

		public bool bUseAutocorrect
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseAutocorrect, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseAutocorrect, __InBuffer);
				}
			}
		}

		public TArray<FString> ExcludedAutocorrectOS
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ExcludedAutocorrectOS, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ExcludedAutocorrectOS, __InBuffer);
				}
			}
		}

		public TArray<FString> ExcludedAutocorrectCultures
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ExcludedAutocorrectCultures, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ExcludedAutocorrectCultures, __InBuffer);
				}
			}
		}

		public TArray<FString> ExcludedAutocorrectDeviceModels
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ExcludedAutocorrectDeviceModels, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ExcludedAutocorrectDeviceModels, __InBuffer);
				}
			}
		}

		public EMouseCaptureMode DefaultViewportMouseCaptureMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultViewportMouseCaptureMode, __ReturnBuffer);

					return *(EMouseCaptureMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultViewportMouseCaptureMode, __InBuffer);
				}
			}
		}

		public EMouseLockMode DefaultViewportMouseLockMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultViewportMouseLockMode, __ReturnBuffer);

					return *(EMouseLockMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultViewportMouseLockMode, __InBuffer);
				}
			}
		}

		public float FOVScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FOVScale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FOVScale, __InBuffer);
				}
			}
		}

		public float DoubleClickTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DoubleClickTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DoubleClickTime, __InBuffer);
				}
			}
		}

		public TArray<FInputActionKeyMapping> ActionMappings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActionMappings, __ReturnBuffer);

					return *(TArray<FInputActionKeyMapping>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActionMappings, __InBuffer);
				}
			}
		}

		public TArray<FInputAxisKeyMapping> AxisMappings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AxisMappings, __ReturnBuffer);

					return *(TArray<FInputAxisKeyMapping>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AxisMappings, __InBuffer);
				}
			}
		}

		public TArray<FInputActionSpeechMapping> SpeechMappings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SpeechMappings, __ReturnBuffer);

					return *(TArray<FInputActionSpeechMapping>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SpeechMappings, __InBuffer);
				}
			}
		}

		public TSoftClassPtr<UPlayerInput> DefaultPlayerInputClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultPlayerInputClass, __ReturnBuffer);

					return *(TSoftClassPtr<UPlayerInput>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultPlayerInputClass, __InBuffer);
				}
			}
		}

		public TSoftClassPtr<UInputComponent> DefaultInputComponentClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultInputComponentClass, __ReturnBuffer);

					return *(TSoftClassPtr<UInputComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultInputComponentClass, __InBuffer);
				}
			}
		}

		public FSoftObjectPath DefaultTouchInterface
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultTouchInterface, __ReturnBuffer);

					return *(FSoftObjectPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultTouchInterface, __InBuffer);
				}
			}
		}

		public TArray<FKey> ConsoleKeys
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ConsoleKeys, __ReturnBuffer);

					return *(TArray<FKey>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ConsoleKeys, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.InputSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SaveKeyMappings()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SaveKeyMappings);
			}
		}

		public virtual void RemoveAxisMapping(FInputAxisKeyMapping KeyMapping, bool bForceRebuildKeymaps = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = KeyMapping?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bForceRebuildKeymaps;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveAxisMapping, __InBuffer);
			}
		}

		public virtual void RemoveActionMapping(FInputActionKeyMapping KeyMapping, bool bForceRebuildKeymaps = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = KeyMapping?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bForceRebuildKeymaps;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveActionMapping, __InBuffer);
			}
		}

		public static UInputSettings GetInputSettings()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetInputSettings, __ReturnBuffer);

				return *(UInputSettings*)__ReturnBuffer;
			}
		}

		public virtual void GetAxisNames(ref TArray<FName> AxisNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AxisNames?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetAxisNames, __InBuffer, __OutBuffer);

				AxisNames = *(TArray<FName>*)(__OutBuffer);

			}
		}

		public virtual void GetAxisMappingByName(FName InAxisName, ref TArray<FInputAxisKeyMapping> OutMappings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InAxisName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutMappings?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetAxisMappingByName, __InBuffer, __OutBuffer);

				OutMappings = *(TArray<FInputAxisKeyMapping>*)(__OutBuffer);

			}
		}

		public static TArray<FName> GetAllActionAndAxisNames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetAllActionAndAxisNames, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		public virtual void GetActionNames(ref TArray<FName> ActionNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ActionNames?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetActionNames, __InBuffer, __OutBuffer);

				ActionNames = *(TArray<FName>*)(__OutBuffer);

			}
		}

		public virtual void GetActionMappingByName(FName InActionName, ref TArray<FInputActionKeyMapping> OutMappings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InActionName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutMappings?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetActionMappingByName, __InBuffer, __OutBuffer);

				OutMappings = *(TArray<FInputActionKeyMapping>*)(__OutBuffer);

			}
		}

		public virtual void ForceRebuildKeymaps()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ForceRebuildKeymaps);
			}
		}

		public virtual void AddAxisMapping(FInputAxisKeyMapping KeyMapping, bool bForceRebuildKeymaps = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = KeyMapping?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bForceRebuildKeymaps;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddAxisMapping, __InBuffer);
			}
		}

		public virtual void AddActionMapping(FInputActionKeyMapping KeyMapping, bool bForceRebuildKeymaps = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = KeyMapping?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bForceRebuildKeymaps;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddActionMapping, __InBuffer);
			}
		}

		private static uint __AxisConfig = 0;

		private static uint __PlatformSettings = 0;

		private static uint __bAltEnterTogglesFullscreen = 0;

		private static uint __bF11TogglesFullscreen = 0;

		private static uint __bUseMouseForTouch = 0;

		private static uint __bEnableMouseSmoothing = 0;

		private static uint __bEnableFOVScaling = 0;

		private static uint __bCaptureMouseOnLaunch = 0;

		private static uint __bEnableLegacyInputScales = 0;

		private static uint __bEnableMotionControls = 0;

		private static uint __bFilterInputByPlatformUser = 0;

		private static uint __bEnableInputDeviceSubsystem = 0;

		private static uint __bShouldFlushPressedKeysOnViewportFocusLost = 0;

		private static uint __bEnableDynamicComponentInputBinding = 0;

		private static uint __bAlwaysShowTouchInterface = 0;

		private static uint __bShowConsoleOnFourFingerTap = 0;

		private static uint __bEnableGestureRecognizer = 0;

		private static uint __bUseAutocorrect = 0;

		private static uint __ExcludedAutocorrectOS = 0;

		private static uint __ExcludedAutocorrectCultures = 0;

		private static uint __ExcludedAutocorrectDeviceModels = 0;

		private static uint __DefaultViewportMouseCaptureMode = 0;

		private static uint __DefaultViewportMouseLockMode = 0;

		private static uint __FOVScale = 0;

		private static uint __DoubleClickTime = 0;

		private static uint __ActionMappings = 0;

		private static uint __AxisMappings = 0;

		private static uint __SpeechMappings = 0;

		private static uint __DefaultPlayerInputClass = 0;

		private static uint __DefaultInputComponentClass = 0;

		private static uint __DefaultTouchInterface = 0;

		private static uint __ConsoleKeys = 0;

		private static uint __SaveKeyMappings = 0;

		private static uint __RemoveAxisMapping = 0;

		private static uint __RemoveActionMapping = 0;

		private static uint __GetInputSettings = 0;

		private static uint __GetAxisNames = 0;

		private static uint __GetAxisMappingByName = 0;

		private static uint __GetAllActionAndAxisNames = 0;

		private static uint __GetActionNames = 0;

		private static uint __GetActionMappingByName = 0;

		private static uint __ForceRebuildKeymaps = 0;

		private static uint __AddAxisMapping = 0;

		private static uint __AddActionMapping = 0;
	}
}