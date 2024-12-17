using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.VariableFrameStrippingSettings")]
	public partial class UVariableFrameStrippingSettings : UObject, IStaticClass
	{
		public FPerPlatformBool UseVariableFrameStripping
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UseVariableFrameStripping, __ReturnBuffer);

					return *(FPerPlatformBool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UseVariableFrameStripping, __InBuffer);
				}
			}
		}

		public FPerPlatformInt FrameStrippingRate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FrameStrippingRate, __ReturnBuffer);

					return *(FPerPlatformInt*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FrameStrippingRate, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.VariableFrameStrippingSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __UseVariableFrameStripping = 0;

		private static uint __FrameStrippingRate = 0;
	}
}