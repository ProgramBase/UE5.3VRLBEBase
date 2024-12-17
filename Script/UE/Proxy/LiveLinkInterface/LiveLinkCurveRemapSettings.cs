using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkCurveRemapSettings")]
	public partial class ULiveLinkCurveRemapSettings : ULiveLinkSourceSettings, IStaticClass
	{
		public FLiveLinkCurveConversionSettings CurveConversionSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurveConversionSettings, __ReturnBuffer);

					return *(FLiveLinkCurveConversionSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurveConversionSettings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LiveLinkInterface.LiveLinkCurveRemapSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CurveConversionSettings = 0;
	}
}