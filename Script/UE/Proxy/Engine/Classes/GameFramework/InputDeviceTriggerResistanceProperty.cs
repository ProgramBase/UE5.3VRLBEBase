using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InputDeviceTriggerResistanceProperty")]
	public partial class UInputDeviceTriggerResistanceProperty : UInputDeviceTriggerEffect, IStaticClass
	{
		public FDeviceTriggerTriggerResistanceData TriggerData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TriggerData, __ReturnBuffer);

					return *(FDeviceTriggerTriggerResistanceData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TriggerData, __InBuffer);
				}
			}
		}

		public TMap<FName, FDeviceTriggerTriggerResistanceData> DeviceOverrideData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DeviceOverrideData, __ReturnBuffer);

					return *(TMap<FName, FDeviceTriggerTriggerResistanceData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DeviceOverrideData, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.InputDeviceTriggerResistanceProperty");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __TriggerData = 0;

		private static uint __DeviceOverrideData = 0;
	}
}