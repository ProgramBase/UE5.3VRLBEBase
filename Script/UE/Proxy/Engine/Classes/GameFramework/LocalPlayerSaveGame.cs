using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LocalPlayerSaveGame")]
	public partial class ULocalPlayerSaveGame : USaveGame, IStaticClass
	{
		public ULocalPlayer OwningPlayer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OwningPlayer, __ReturnBuffer);

					return *(ULocalPlayer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OwningPlayer, __InBuffer);
				}
			}
		}

		public FString SaveSlotName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SaveSlotName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SaveSlotName, __InBuffer);
				}
			}
		}

		public int SavedDataVersion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SavedDataVersion, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SavedDataVersion, __InBuffer);
				}
			}
		}

		public int LoadedDataVersion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LoadedDataVersion, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LoadedDataVersion, __InBuffer);
				}
			}
		}

		public int CurrentSaveRequest
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentSaveRequest, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentSaveRequest, __InBuffer);
				}
			}
		}

		public int LastSuccessfulSaveRequest
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastSuccessfulSaveRequest, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastSuccessfulSaveRequest, __InBuffer);
				}
			}
		}

		public int LastErrorSaveRequest
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastErrorSaveRequest, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastErrorSaveRequest, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.LocalPlayerSaveGame");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool WasSaveRequested()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __WasSaveRequested, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool WasLoaded()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __WasLoaded, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool WasLastSaveSuccessful()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __WasLastSaveSuccessful, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SaveGameToSlotForLocalPlayer()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __SaveGameToSlotForLocalPlayer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void ResetToDefault()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetToDefault);
			}
		}

		public virtual void OnResetToDefault()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __OnResetToDefault);
			}
		}

		public virtual void OnPreSave()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __OnPreSave);
			}
		}

		public virtual void OnPostSave(bool bSuccess)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bSuccess;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __OnPostSave, __InBuffer);
			}
		}

		public virtual void OnPostLoad()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __OnPostLoad);
			}
		}

		public static ULocalPlayerSaveGame LoadOrCreateSaveGameForLocalPlayer(TSubclassOf<ULocalPlayerSaveGame> SaveGameClass, APlayerController LocalPlayerController, FString SlotName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = SaveGameClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LocalPlayerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SlotName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __LoadOrCreateSaveGameForLocalPlayer, __InBuffer, __ReturnBuffer);

				return *(ULocalPlayerSaveGame*)__ReturnBuffer;
			}
		}

		public virtual bool IsSaveInProgress()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsSaveInProgress, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FString GetSaveSlotName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSaveSlotName, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual int GetSavedDataVersion()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetSavedDataVersion, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetPlatformUserIndex()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPlatformUserIndex, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual FPlatformUserId GetPlatformUserId()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPlatformUserId, __ReturnBuffer);

				return *(FPlatformUserId*)__ReturnBuffer;
			}
		}

		public virtual APlayerController GetLocalPlayerController()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLocalPlayerController, __ReturnBuffer);

				return *(APlayerController*)__ReturnBuffer;
			}
		}

		public virtual int GetLatestDataVersion()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetLatestDataVersion, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetInvalidDataVersion()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetInvalidDataVersion, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual bool AsyncSaveGameToSlotForLocalPlayer()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __AsyncSaveGameToSlotForLocalPlayer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool AsyncLoadOrCreateSaveGameForLocalPlayer(TSubclassOf<ULocalPlayerSaveGame> SaveGameClass, APlayerController LocalPlayerController, FString SlotName, FOnLocalPlayerSaveGameLoaded Delegate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = SaveGameClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LocalPlayerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SlotName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __AsyncLoadOrCreateSaveGameForLocalPlayer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __OwningPlayer = 0;

		private static uint __SaveSlotName = 0;

		private static uint __SavedDataVersion = 0;

		private static uint __LoadedDataVersion = 0;

		private static uint __CurrentSaveRequest = 0;

		private static uint __LastSuccessfulSaveRequest = 0;

		private static uint __LastErrorSaveRequest = 0;

		private static uint __WasSaveRequested = 0;

		private static uint __WasLoaded = 0;

		private static uint __WasLastSaveSuccessful = 0;

		private static uint __SaveGameToSlotForLocalPlayer = 0;

		private static uint __ResetToDefault = 0;

		private static uint __OnResetToDefault = 0;

		private static uint __OnPreSave = 0;

		private static uint __OnPostSave = 0;

		private static uint __OnPostLoad = 0;

		private static uint __LoadOrCreateSaveGameForLocalPlayer = 0;

		private static uint __IsSaveInProgress = 0;

		private static uint __GetSaveSlotName = 0;

		private static uint __GetSavedDataVersion = 0;

		private static uint __GetPlatformUserIndex = 0;

		private static uint __GetPlatformUserId = 0;

		private static uint __GetLocalPlayerController = 0;

		private static uint __GetLatestDataVersion = 0;

		private static uint __GetInvalidDataVersion = 0;

		private static uint __AsyncSaveGameToSlotForLocalPlayer = 0;

		private static uint __AsyncLoadOrCreateSaveGameForLocalPlayer = 0;
	}
}