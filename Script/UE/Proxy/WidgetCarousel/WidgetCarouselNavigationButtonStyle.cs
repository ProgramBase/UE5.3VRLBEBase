using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;

namespace Script.WidgetCarousel
{
	[PathName("/Script/WidgetCarousel.WidgetCarouselNavigationButtonStyle")]
	public partial class FWidgetCarouselNavigationButtonStyle : FSlateWidgetStyle, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/WidgetCarousel.WidgetCarouselNavigationButtonStyle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FWidgetCarouselNavigationButtonStyle()
		{
		}

		public static bool operator ==(FWidgetCarouselNavigationButtonStyle A, FWidgetCarouselNavigationButtonStyle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FWidgetCarouselNavigationButtonStyle A, FWidgetCarouselNavigationButtonStyle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FWidgetCarouselNavigationButtonStyle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FButtonStyle InnerButtonStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InnerButtonStyle, __ReturnBuffer);

					return *(FButtonStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InnerButtonStyle, __InBuffer);
				}
			}
		}

		public FSlateBrush NavigationButtonLeftImage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NavigationButtonLeftImage, __ReturnBuffer);

					return *(FSlateBrush*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NavigationButtonLeftImage, __InBuffer);
				}
			}
		}

		public FSlateBrush NavigationButtonRightImage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NavigationButtonRightImage, __ReturnBuffer);

					return *(FSlateBrush*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NavigationButtonRightImage, __InBuffer);
				}
			}
		}

		private static uint __InnerButtonStyle = 0;

		private static uint __NavigationButtonLeftImage = 0;

		private static uint __NavigationButtonRightImage = 0;

	}
}