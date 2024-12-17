using Script.CoreUObject;
using Script.Engine;
using Script.EnhancedInput.EnhancedInputUserSettings;
using Script.GameplayTags;
using Script.Library;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.EnhancedInputUserSettings")]
	public partial class UEnhancedInputUserSettings : USaveGame, IStaticClass
	{
		public FEnhancedInputUserSettingsChanged OnSettingsChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnSettingsChanged, __ReturnBuffer);

					return *(FEnhancedInputUserSettingsChanged*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnSettingsChanged, __InBuffer);
				}
			}
		}

		public FEnhancedInputUserSettingsApplied OnSettingsApplied
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnSettingsApplied, __ReturnBuffer);

					return *(FEnhancedInputUserSettingsApplied*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnSettingsApplied, __InBuffer);
				}
			}
		}

		public FGameplayTag CurrentProfileIdentifier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentProfileIdentifier, __ReturnBuffer);

					return *(FGameplayTag*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentProfileIdentifier, __InBuffer);
				}
			}
		}

		public TMap<FGameplayTag, UEnhancedPlayerMappableKeyProfile> SavedKeyProfiles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SavedKeyProfiles, __ReturnBuffer);

					return *(TMap<FGameplayTag, UEnhancedPlayerMappableKeyProfile>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SavedKeyProfiles, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<ULocalPlayer> OwningLocalPlayer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OwningLocalPlayer, __ReturnBuffer);

					return *(TWeakObjectPtr<ULocalPlayer>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OwningLocalPlayer, __InBuffer);
				}
			}
		}

		public TSet<UInputMappingContext> RegisteredMappingContexts
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RegisteredMappingContexts, __ReturnBuffer);

					return *(TSet<UInputMappingContext>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RegisteredMappingContexts, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnhancedInput.EnhancedInputUserSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool UnregisterInputMappingContexts(TSet<UInputMappingContext> MappingContexts)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MappingContexts?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __UnregisterInputMappingContexts, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool UnregisterInputMappingContext(UInputMappingContext IMC)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = IMC?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __UnregisterInputMappingContext, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void UnMapPlayerKey(FMapPlayerKeyArgs InArgs, ref FGameplayTagContainer FailureReason)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InArgs?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FailureReason?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __UnMapPlayerKey, __InBuffer, __OutBuffer);

				FailureReason = *(FGameplayTagContainer*)(__OutBuffer);

			}
		}

		public virtual bool SetKeyProfile(FGameplayTag InProfileId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InProfileId?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetKeyProfile, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SaveSettings()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SaveSettings);
			}
		}

		/// <param name="ProfileId">
		/// The ID of the key profile to reset
		/// </param>
		/// <param name="FailureReason">
		/// Populated with failure reasons if the operation fails.
		/// </param>
		public virtual void ResetKeyProfileToDefault(FGameplayTag ProfileId, ref FGameplayTagContainer FailureReason)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ProfileId?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FailureReason?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __ResetKeyProfileToDefault, __InBuffer, __OutBuffer);

				FailureReason = *(FGameplayTagContainer*)(__OutBuffer);

			}
		}

		/// <param name="InArgs">
		/// Arguments that contain the mapping name and profile ID to find the mapping to reset.
		/// </param>
		/// <param name="FailureReason">
		/// Populated with failure reasons if the operation fails.
		/// </param>
		public virtual void ResetAllPlayerKeysInRow(FMapPlayerKeyArgs InArgs, ref FGameplayTagContainer FailureReason)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InArgs?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FailureReason?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __ResetAllPlayerKeysInRow, __InBuffer, __OutBuffer);

				FailureReason = *(FGameplayTagContainer*)(__OutBuffer);

			}
		}

		public virtual bool RegisterInputMappingContexts(TSet<UInputMappingContext> MappingContexts)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MappingContexts?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RegisterInputMappingContexts, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RegisterInputMappingContext(UInputMappingContext IMC)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = IMC?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RegisterInputMappingContext, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void MapPlayerKey(FMapPlayerKeyArgs InArgs, ref FGameplayTagContainer FailureReason)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InArgs?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FailureReason?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __MapPlayerKey, __InBuffer, __OutBuffer);

				FailureReason = *(FGameplayTagContainer*)(__OutBuffer);

			}
		}

		public virtual bool IsMappingContextRegistered(UInputMappingContext IMC)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = IMC?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsMappingContextRegistered, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual UEnhancedPlayerMappableKeyProfile GetKeyProfileWithIdentifier(FGameplayTag ProfileId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ProfileId?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetKeyProfileWithIdentifier, __InBuffer, __ReturnBuffer);

				return *(UEnhancedPlayerMappableKeyProfile*)__ReturnBuffer;
			}
		}

		public virtual FGameplayTag GetCurrentKeyProfileIdentifier()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetCurrentKeyProfileIdentifier, __ReturnBuffer);

				return *(FGameplayTag*)__ReturnBuffer;
			}
		}

		public virtual UEnhancedPlayerMappableKeyProfile GetCurrentKeyProfile()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetCurrentKeyProfile, __ReturnBuffer);

				return *(UEnhancedPlayerMappableKeyProfile*)__ReturnBuffer;
			}
		}

		public virtual TSet<FPlayerKeyMapping> FindMappingsInRow(FName MappingName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MappingName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindMappingsInRow, __InBuffer, __ReturnBuffer);

				return *(TSet<FPlayerKeyMapping>*)__ReturnBuffer;
			}
		}

		public virtual UEnhancedPlayerMappableKeyProfile CreateNewKeyProfile(FPlayerMappableKeyProfileCreationArgs InArgs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InArgs?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CreateNewKeyProfile, __InBuffer, __ReturnBuffer);

				return *(UEnhancedPlayerMappableKeyProfile*)__ReturnBuffer;
			}
		}

		public virtual void AsyncSaveSettings()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __AsyncSaveSettings);
			}
		}

		public virtual void ApplySettings()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ApplySettings);
			}
		}

		private static uint __OnSettingsChanged = 0;

		private static uint __OnSettingsApplied = 0;

		private static uint __CurrentProfileIdentifier = 0;

		private static uint __SavedKeyProfiles = 0;

		private static uint __OwningLocalPlayer = 0;

		private static uint __RegisteredMappingContexts = 0;

		private static uint __UnregisterInputMappingContexts = 0;

		private static uint __UnregisterInputMappingContext = 0;

		private static uint __UnMapPlayerKey = 0;

		private static uint __SetKeyProfile = 0;

		private static uint __SaveSettings = 0;

		private static uint __ResetKeyProfileToDefault = 0;

		private static uint __ResetAllPlayerKeysInRow = 0;

		private static uint __RegisterInputMappingContexts = 0;

		private static uint __RegisterInputMappingContext = 0;

		private static uint __MapPlayerKey = 0;

		private static uint __IsMappingContextRegistered = 0;

		private static uint __GetKeyProfileWithIdentifier = 0;

		private static uint __GetCurrentKeyProfileIdentifier = 0;

		private static uint __GetCurrentKeyProfile = 0;

		private static uint __FindMappingsInRow = 0;

		private static uint __CreateNewKeyProfile = 0;

		private static uint __AsyncSaveSettings = 0;

		private static uint __ApplySettings = 0;
	}
}