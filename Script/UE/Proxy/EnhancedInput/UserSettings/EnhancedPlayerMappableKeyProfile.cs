using Script.CoreUObject;
using Script.GameplayTags;
using Script.Library;
using Script.InputCore;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.EnhancedPlayerMappableKeyProfile")]
	public partial class UEnhancedPlayerMappableKeyProfile : UObject, IStaticClass
	{
		public FGameplayTag ProfileIdentifier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ProfileIdentifier, __ReturnBuffer);

					return *(FGameplayTag*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ProfileIdentifier, __InBuffer);
				}
			}
		}

		public FPlatformUserId OwningUserId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OwningUserId, __ReturnBuffer);

					return *(FPlatformUserId*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OwningUserId, __InBuffer);
				}
			}
		}

		public FText DisplayName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DisplayName, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DisplayName, __InBuffer);
				}
			}
		}

		public TMap<FName, FKeyMappingRow> PlayerMappedKeys
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerMappedKeys, __ReturnBuffer);

					return *(TMap<FName, FKeyMappingRow>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerMappedKeys, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnhancedInput.EnhancedPlayerMappableKeyProfile");
		}

		private static UClass StaticClassSingleton { get; set; }

		public new FString ToString()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __ToString, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual void SetDisplayName(FText NewDisplayName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewDisplayName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDisplayName, __InBuffer);
			}
		}

		public virtual void ResetToDefault()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetToDefault);
			}
		}

		public virtual void ResetMappingToDefault(FName InMappingName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InMappingName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ResetMappingToDefault, __InBuffer);
			}
		}

		public virtual int QueryPlayerMappedKeys(FPlayerMappableKeyQueryOptions Options, ref TArray<FKey> OutKeys)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Options?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutKeys?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __QueryPlayerMappedKeys, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutKeys = *(TArray<FKey>*)(__OutBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual void K2_FindKeyMapping(ref FPlayerKeyMapping OutKeyMapping, FMapPlayerKeyArgs InArgs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OutKeyMapping?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InArgs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_FindKeyMapping, __InBuffer, __OutBuffer);

				OutKeyMapping = *(FPlayerKeyMapping*)(__OutBuffer);

			}
		}

		public virtual FGameplayTag GetProfileIdentifer()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetProfileIdentifer, __ReturnBuffer);

				return *(FGameplayTag*)__ReturnBuffer;
			}
		}

		public virtual FText GetProfileDisplayName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetProfileDisplayName, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public virtual TMap<FName, FKeyMappingRow> GetPlayerMappingRows()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPlayerMappingRows, __ReturnBuffer);

				return *(TMap<FName, FKeyMappingRow>*)__ReturnBuffer;
			}
		}

		public virtual int GetMappingNamesForKey(FKey InKey, ref TArray<FName> OutMappingNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutMappingNames?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetMappingNamesForKey, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutMappingNames = *(TArray<FName>*)(__OutBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetMappedKeysInRow(FName MappingName, ref TArray<FKey> OutKeys)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MappingName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutKeys?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetMappedKeysInRow, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutKeys = *(TArray<FKey>*)(__OutBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual void DumpProfileToLog()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __DumpProfileToLog);
			}
		}

		public virtual bool DoesMappingPassQueryOptions(FPlayerKeyMapping PlayerMapping, FPlayerMappableKeyQueryOptions Options)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PlayerMapping?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Options?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DoesMappingPassQueryOptions, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __ProfileIdentifier = 0;

		private static uint __OwningUserId = 0;

		private static uint __DisplayName = 0;

		private static uint __PlayerMappedKeys = 0;

		private static uint __ToString = 0;

		private static uint __SetDisplayName = 0;

		private static uint __ResetToDefault = 0;

		private static uint __ResetMappingToDefault = 0;

		private static uint __QueryPlayerMappedKeys = 0;

		private static uint __K2_FindKeyMapping = 0;

		private static uint __GetProfileIdentifer = 0;

		private static uint __GetProfileDisplayName = 0;

		private static uint __GetPlayerMappingRows = 0;

		private static uint __GetMappingNamesForKey = 0;

		private static uint __GetMappedKeysInRow = 0;

		private static uint __DumpProfileToLog = 0;

		private static uint __DoesMappingPassQueryOptions = 0;
	}
}