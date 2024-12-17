using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InputDeviceProperty")]
	public partial class UInputDeviceProperty : UObject, IStaticClass
	{
		public float PropertyDuration
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PropertyDuration, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PropertyDuration, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.InputDeviceProperty");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="PlatformUser">
		/// The platform user that should receive this device property change
		/// </param>
		public virtual void ResetDeviceProperty(FPlatformUserId PlatformUser, FInputDeviceId DeviceId, bool bForceReset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = PlatformUser?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DeviceId?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bForceReset;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ResetDeviceProperty, __InBuffer);
			}
		}

		/// <param name="PlatformUser">
		/// The platform user that should receive this device property change
		/// </param>
		/// <param name="DeltaTime">
		/// Delta time
		/// </param>
		/// <param name="Duration">
		/// The number of seconds that this property has been active. Use this to get things like curve data over time.
		/// </param>
		/// <returns>
		/// A pointer to the evaluated input device property.
		/// </returns>
		public virtual void EvaluateDeviceProperty(FPlatformUserId PlatformUser, FInputDeviceId DeviceId, float DeltaTime, float Duration)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = PlatformUser?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DeviceId?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = DeltaTime;

				*(float*)(__InBuffer + 20) = Duration;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __EvaluateDeviceProperty, __InBuffer);
			}
		}

		/// <param name="UserId">
		/// The owning Platform User whose input device this property should be applied to.
		/// </param>
		public virtual void ApplyDeviceProperty(FPlatformUserId UserId, FInputDeviceId DeviceId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = UserId?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DeviceId?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ApplyDeviceProperty, __InBuffer);
			}
		}

		private static uint __PropertyDuration = 0;

		private static uint __ResetDeviceProperty = 0;

		private static uint __EvaluateDeviceProperty = 0;

		private static uint __ApplyDeviceProperty = 0;
	}
}