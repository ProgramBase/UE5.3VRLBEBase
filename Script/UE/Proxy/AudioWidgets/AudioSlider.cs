using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AudioWidgets
{
	[PathName("/Script/AudioWidgets.AudioSlider")]
	public partial class UAudioSlider : UAudioSliderBase, IStaticClass
	{
		public TWeakObjectPtr<UCurveFloat> LinToOutputCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LinToOutputCurve, __ReturnBuffer);

					return *(TWeakObjectPtr<UCurveFloat>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LinToOutputCurve, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<UCurveFloat> OutputToLinCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OutputToLinCurve, __ReturnBuffer);

					return *(TWeakObjectPtr<UCurveFloat>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OutputToLinCurve, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioWidgets.AudioSlider");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __LinToOutputCurve = 0;

		private static uint __OutputToLinCurve = 0;
	}
}