using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InputDeviceLibrary")]
	public partial class UInputDeviceLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.InputDeviceLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FPlatformUserId PlatformUserId_None()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __PlatformUserId_None, __ReturnBuffer);

				return *(FPlatformUserId*)__ReturnBuffer;
			}
		}

		public static bool NotEqual_PlatformUserId(FPlatformUserId A, FPlatformUserId B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_PlatformUserId, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NotEqual_InputDeviceId(FInputDeviceId A, FInputDeviceId B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_InputDeviceId, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// True if the platform ID is valid (it has been assigned by the PlatformInputDeviceMapper)
		/// </returns>
		public static bool IsValidPlatformId(FPlatformUserId UserId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = UserId?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsValidPlatformId, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// True if the given input device is valid (it has been assigned an ID by the PlatformInputDeviceMapper)
		/// </returns>
		public static bool IsValidInputDevice(FInputDeviceId DeviceId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DeviceId?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsValidInputDevice, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsUnpairedUserId(FPlatformUserId PlatformId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlatformId?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsUnpairedUserId, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsInputDeviceMappedToUnpairedUser(FInputDeviceId InputDevice)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InputDevice?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsInputDeviceMappedToUnpairedUser, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsDevicePropertyHandleValid(FInputDevicePropertyHandle InHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsDevicePropertyHandleValid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FInputDeviceId InputDeviceId_None()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __InputDeviceId_None, __ReturnBuffer);

				return *(FInputDeviceId*)__ReturnBuffer;
			}
		}

		public static FPlatformUserId GetUserForUnpairedInputDevices()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetUserForUnpairedInputDevices, __ReturnBuffer);

				return *(FPlatformUserId*)__ReturnBuffer;
			}
		}

		public static FPlatformUserId GetUserForInputDevice(FInputDeviceId DeviceId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DeviceId?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetUserForInputDevice, __InBuffer, __ReturnBuffer);

				return *(FPlatformUserId*)__ReturnBuffer;
			}
		}

		public static FPlatformUserId GetPrimaryPlatformUser()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetPrimaryPlatformUser, __ReturnBuffer);

				return *(FPlatformUserId*)__ReturnBuffer;
			}
		}

		public static FInputDeviceId GetPrimaryInputDeviceForUser(FPlatformUserId UserId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = UserId?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPrimaryInputDeviceForUser, __InBuffer, __ReturnBuffer);

				return *(FInputDeviceId*)__ReturnBuffer;
			}
		}

		public static APlayerController GetPlayerControllerFromPlatformUser(FPlatformUserId UserId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = UserId?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPlayerControllerFromPlatformUser, __InBuffer, __ReturnBuffer);

				return *(APlayerController*)__ReturnBuffer;
			}
		}

		public static APlayerController GetPlayerControllerFromInputDevice(FInputDeviceId DeviceId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DeviceId?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPlayerControllerFromInputDevice, __InBuffer, __ReturnBuffer);

				return *(APlayerController*)__ReturnBuffer;
			}
		}

		/// <param name="DeviceId">
		/// The device to get the connection state of
		/// </param>
		/// <returns>
		/// The connection state of the given device. EInputDeviceConnectionState::Unknown if the device is not mapped
		/// </returns>
		public static EInputDeviceConnectionState GetInputDeviceConnectionState(FInputDeviceId DeviceId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DeviceId?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetInputDeviceConnectionState, __InBuffer, __ReturnBuffer);

				return *(EInputDeviceConnectionState*)__ReturnBuffer;
			}
		}

		public static FInputDeviceId GetDefaultInputDevice()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetDefaultInputDevice, __ReturnBuffer);

				return *(FInputDeviceId*)__ReturnBuffer;
			}
		}

		/// <param name="UserId">
		/// The Platform User to gather the input devices of.
		/// </param>
		/// <param name="OutInputDevices">
		/// Array of input device ID's that will be populated with the mapped devices.
		/// </param>
		/// <returns>
		/// The number of mapped devices, INDEX_NONE if the user was not found.
		/// </returns>
		public static int GetAllInputDevicesForUser(FPlatformUserId UserId, ref TArray<FInputDeviceId> OutInputDevices)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = UserId?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutInputDevices?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetAllInputDevicesForUser, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutInputDevices = *(TArray<FInputDeviceId>*)(__OutBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="OutInputDevices">
		/// Array of input devices to populate
		/// </param>
		/// <returns>
		/// The number of connected input devices
		/// </returns>
		public static int GetAllInputDevices(ref TArray<FInputDeviceId> OutInputDevices)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutInputDevices?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetAllInputDevices, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutInputDevices = *(TArray<FInputDeviceId>*)(__OutBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="OutInputDevices">
		/// Array of input devices to populate
		/// </param>
		/// <returns>
		/// The number of connected input devices
		/// </returns>
		public static int GetAllConnectedInputDevices(ref TArray<FInputDeviceId> OutInputDevices)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutInputDevices?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetAllConnectedInputDevices, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutInputDevices = *(TArray<FInputDeviceId>*)(__OutBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="OutUsers">
		/// Array that will be populated with the platform users.
		/// </param>
		/// <returns>
		/// The number of active platform users
		/// </returns>
		public static int GetAllActiveUsers(ref TArray<FPlatformUserId> OutUsers)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutUsers?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetAllActiveUsers, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutUsers = *(TArray<FPlatformUserId>*)(__OutBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static bool EqualEqual_PlatformUserId(FPlatformUserId A, FPlatformUserId B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_PlatformUserId, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EqualEqual_InputDeviceId(FInputDeviceId A, FInputDeviceId B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_InputDeviceId, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __PlatformUserId_None = 0;

		private static uint __NotEqual_PlatformUserId = 0;

		private static uint __NotEqual_InputDeviceId = 0;

		private static uint __IsValidPlatformId = 0;

		private static uint __IsValidInputDevice = 0;

		private static uint __IsUnpairedUserId = 0;

		private static uint __IsInputDeviceMappedToUnpairedUser = 0;

		private static uint __IsDevicePropertyHandleValid = 0;

		private static uint __InputDeviceId_None = 0;

		private static uint __GetUserForUnpairedInputDevices = 0;

		private static uint __GetUserForInputDevice = 0;

		private static uint __GetPrimaryPlatformUser = 0;

		private static uint __GetPrimaryInputDeviceForUser = 0;

		private static uint __GetPlayerControllerFromPlatformUser = 0;

		private static uint __GetPlayerControllerFromInputDevice = 0;

		private static uint __GetInputDeviceConnectionState = 0;

		private static uint __GetDefaultInputDevice = 0;

		private static uint __GetAllInputDevicesForUser = 0;

		private static uint __GetAllInputDevices = 0;

		private static uint __GetAllConnectedInputDevices = 0;

		private static uint __GetAllActiveUsers = 0;

		private static uint __EqualEqual_PlatformUserId = 0;

		private static uint __EqualEqual_InputDeviceId = 0;
	}
}