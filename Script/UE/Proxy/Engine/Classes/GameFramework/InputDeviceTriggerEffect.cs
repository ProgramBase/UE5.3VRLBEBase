using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InputDeviceTriggerEffect")]
	public partial class UInputDeviceTriggerEffect : UInputDeviceProperty, IStaticClass
	{
		public FDeviceTriggerBaseData BaseTriggerData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BaseTriggerData, __ReturnBuffer);

					return *(FDeviceTriggerBaseData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BaseTriggerData, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.InputDeviceTriggerEffect");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __BaseTriggerData = 0;
	}
}