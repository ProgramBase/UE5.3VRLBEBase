using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;

namespace Script.WidgetCarousel
{
	[PathName("/Script/WidgetCarousel.WidgetCarouselNavigationBarStyle")]
	public partial class FWidgetCarouselNavigationBarStyle : FSlateWidgetStyle, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/WidgetCarousel.WidgetCarouselNavigationBarStyle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FWidgetCarouselNavigationBarStyle()
		{
		}

		public static bool operator ==(FWidgetCarouselNavigationBarStyle A, FWidgetCarouselNavigationBarStyle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FWidgetCarouselNavigationBarStyle A, FWidgetCarouselNavigationBarStyle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FWidgetCarouselNavigationBarStyle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FSlateBrush HighlightBrush
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HighlightBrush, __ReturnBuffer);

					return *(FSlateBrush*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HighlightBrush, __InBuffer);
				}
			}
		}

		public FButtonStyle LeftButtonStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LeftButtonStyle, __ReturnBuffer);

					return *(FButtonStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LeftButtonStyle, __InBuffer);
				}
			}
		}

		public FButtonStyle CenterButtonStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CenterButtonStyle, __ReturnBuffer);

					return *(FButtonStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CenterButtonStyle, __InBuffer);
				}
			}
		}

		public FButtonStyle RightButtonStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RightButtonStyle, __ReturnBuffer);

					return *(FButtonStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RightButtonStyle, __InBuffer);
				}
			}
		}

		private static uint __HighlightBrush = 0;

		private static uint __LeftButtonStyle = 0;

		private static uint __CenterButtonStyle = 0;

		private static uint __RightButtonStyle = 0;

	}
}