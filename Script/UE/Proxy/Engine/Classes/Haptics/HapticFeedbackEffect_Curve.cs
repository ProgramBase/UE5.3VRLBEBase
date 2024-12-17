using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.HapticFeedbackEffect_Curve")]
	public partial class UHapticFeedbackEffect_Curve : UHapticFeedbackEffect_Base, IStaticClass
	{
		public FHapticFeedbackDetails_Curve HapticDetails
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HapticDetails, __ReturnBuffer);

					return *(FHapticFeedbackDetails_Curve*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HapticDetails, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.HapticFeedbackEffect_Curve");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __HapticDetails = 0;
	}
}