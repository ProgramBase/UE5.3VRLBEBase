using Script.CoreUObject;
using Script.Library;

namespace Script.KismetWidgets
{
	[PathName("/Script/KismetWidgets.PinTypeSelectorFilter")]
	public partial class UPinTypeSelectorFilter : UObject, IStaticClass
	{
		public TSoftClassPtr<UPinTypeSelectorFilter> FilterClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FilterClass, __ReturnBuffer);

					return *(TSoftClassPtr<UPinTypeSelectorFilter>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FilterClass, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/KismetWidgets.PinTypeSelectorFilter");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __FilterClass = 0;
	}
}