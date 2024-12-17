using Script.CoreUObject;
using Script.Library;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.InputTriggerHold")]
	public partial class UInputTriggerHold : UInputTriggerTimedBase, IStaticClass
	{
		public float HoldTimeThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HoldTimeThreshold, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HoldTimeThreshold, __InBuffer);
				}
			}
		}

		public bool bIsOneShot
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsOneShot, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsOneShot, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnhancedInput.InputTriggerHold");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __HoldTimeThreshold = 0;

		private static uint __bIsOneShot = 0;
	}
}