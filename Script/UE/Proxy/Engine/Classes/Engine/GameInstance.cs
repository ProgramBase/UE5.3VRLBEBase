using Script.CoreUObject;
using Script.Library;
using Script.NetCore;

namespace Script.Engine
{
	[PathName("/Script/Engine.GameInstance")]
	public partial class UGameInstance : UObject, IStaticClass
	{
		public TArray<ULocalPlayer> LocalPlayers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LocalPlayers, __ReturnBuffer);

					return *(TArray<ULocalPlayer>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LocalPlayers, __InBuffer);
				}
			}
		}

		public UOnlineSession OnlineSession
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnlineSession, __ReturnBuffer);

					return *(UOnlineSession*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnlineSession, __InBuffer);
				}
			}
		}

		public TArray<UObject> ReferencedObjects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReferencedObjects, __ReturnBuffer);

					return *(TArray<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReferencedObjects, __InBuffer);
				}
			}
		}

		public FOnPawnControllerChanged OnPawnControllerChangedDelegates
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnPawnControllerChangedDelegates, __ReturnBuffer);

					return *(FOnPawnControllerChanged*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnPawnControllerChangedDelegates, __InBuffer);
				}
			}
		}

		public FOnUserInputDeviceConnectionChange OnInputDeviceConnectionChange
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnInputDeviceConnectionChange, __ReturnBuffer);

					return *(FOnUserInputDeviceConnectionChange*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnInputDeviceConnectionChange, __InBuffer);
				}
			}
		}

		public FOnUserInputDevicePairingChange OnUserInputDevicePairingChange
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnUserInputDevicePairingChange, __ReturnBuffer);

					return *(FOnUserInputDevicePairingChange*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnUserInputDevicePairingChange, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.GameInstance");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void ReceiveShutdown()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __ReceiveShutdown);
			}
		}

		public virtual void ReceiveInit()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __ReceiveInit);
			}
		}

		public virtual void HandleTravelError(ETravelFailure FailureType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)FailureType;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __HandleTravelError, __InBuffer);
			}
		}

		public virtual void HandleNetworkError(ENetworkFailure FailureType, bool bIsServer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(byte*)(__InBuffer) = (byte)FailureType;

				*(bool*)(__InBuffer + 1) = bIsServer;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __HandleNetworkError, __InBuffer);
			}
		}

		/// <param name="ControllerId">
		/// - The controller ID to search for.
		/// </param>
		public virtual void DebugRemovePlayer(int ControllerId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = ControllerId;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DebugRemovePlayer, __InBuffer);
			}
		}

		/// <param name="ControllerId">
		/// - The controller ID the player should accept input from.
		/// </param>
		public virtual void DebugCreatePlayer(int ControllerId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = ControllerId;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DebugCreatePlayer, __InBuffer);
			}
		}

		private static uint __LocalPlayers = 0;

		private static uint __OnlineSession = 0;

		private static uint __ReferencedObjects = 0;

		private static uint __OnPawnControllerChangedDelegates = 0;

		private static uint __OnInputDeviceConnectionChange = 0;

		private static uint __OnUserInputDevicePairingChange = 0;

		private static uint __ReceiveShutdown = 0;

		private static uint __ReceiveInit = 0;

		private static uint __HandleTravelError = 0;

		private static uint __HandleNetworkError = 0;

		private static uint __DebugRemovePlayer = 0;

		private static uint __DebugCreatePlayer = 0;
	}
}