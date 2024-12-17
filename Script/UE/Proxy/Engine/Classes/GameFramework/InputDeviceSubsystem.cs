using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InputDeviceSubsystem")]
	public partial class UInputDeviceSubsystem : UEngineSubsystem, IStaticClass
	{
		public FHardwareInputDeviceChanged OnInputHardwareDeviceChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnInputHardwareDeviceChanged, __ReturnBuffer);

					return *(FHardwareInputDeviceChanged*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnInputHardwareDeviceChanged, __InBuffer);
				}
			}
		}

		public TSet<FActiveDeviceProperty> ActiveProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveProperties, __ReturnBuffer);

					return *(TSet<FActiveDeviceProperty>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveProperties, __InBuffer);
				}
			}
		}

		public TSet<FInputDevicePropertyHandle> PropertiesPendingRemoval
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PropertiesPendingRemoval, __ReturnBuffer);

					return *(TSet<FInputDevicePropertyHandle>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PropertiesPendingRemoval, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.InputDeviceSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="HandlesToRemove">
		/// The set of device property handles to remove
		/// </param>
		/// <returns>
		/// The number of removed device properties
		/// </returns>
		public virtual void RemoveDevicePropertyHandles(TSet<FInputDevicePropertyHandle> HandlesToRemove)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = HandlesToRemove?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveDevicePropertyHandles, __InBuffer);
			}
		}

		/// <param name="FInputDevicePropertyHandle">
		/// Device property handle to be removed	
		/// </param>
		/// <returns>
		/// The number of removed device properties.
		/// </returns>
		public virtual void RemoveDevicePropertyByHandle(FInputDevicePropertyHandle HandleToRemove)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = HandleToRemove?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveDevicePropertyByHandle, __InBuffer);
			}
		}

		public virtual void RemoveAllDeviceProperties()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RemoveAllDeviceProperties);
			}
		}

		public virtual bool IsPropertyActive(FInputDevicePropertyHandle Handle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Handle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsPropertyActive, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FHardwareDeviceIdentifier GetMostRecentlyUsedHardwareDevice(FPlatformUserId InUserId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InUserId?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetMostRecentlyUsedHardwareDevice, __InBuffer, __ReturnBuffer);

				return *(FHardwareDeviceIdentifier*)__ReturnBuffer;
			}
		}

		public virtual FHardwareDeviceIdentifier GetInputDeviceHardwareIdentifier(FInputDeviceId InputDevice)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InputDevice?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetInputDeviceHardwareIdentifier, __InBuffer, __ReturnBuffer);

				return *(FHardwareDeviceIdentifier*)__ReturnBuffer;
			}
		}

		public virtual UInputDeviceProperty GetActiveDeviceProperty(FInputDevicePropertyHandle Handle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Handle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetActiveDeviceProperty, __InBuffer, __ReturnBuffer);

				return *(UInputDeviceProperty*)__ReturnBuffer;
			}
		}

		public virtual FInputDevicePropertyHandle ActivateDevicePropertyOfClass(TSubclassOf<UInputDeviceProperty> PropertyClass, FActivateDevicePropertyParams Params)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PropertyClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Params?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __ActivateDevicePropertyOfClass, __InBuffer, __ReturnBuffer);

				return *(FInputDevicePropertyHandle*)__ReturnBuffer;
			}
		}

		private static uint __OnInputHardwareDeviceChanged = 0;

		private static uint __ActiveProperties = 0;

		private static uint __PropertiesPendingRemoval = 0;

		private static uint __RemoveDevicePropertyHandles = 0;

		private static uint __RemoveDevicePropertyByHandle = 0;

		private static uint __RemoveAllDeviceProperties = 0;

		private static uint __IsPropertyActive = 0;

		private static uint __GetMostRecentlyUsedHardwareDevice = 0;

		private static uint __GetInputDeviceHardwareIdentifier = 0;

		private static uint __GetActiveDeviceProperty = 0;

		private static uint __ActivateDevicePropertyOfClass = 0;
	}
}