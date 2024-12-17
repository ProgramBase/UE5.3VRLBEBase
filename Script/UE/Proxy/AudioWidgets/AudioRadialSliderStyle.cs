using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;

namespace Script.AudioWidgets
{
	[PathName("/Script/AudioWidgets.AudioRadialSliderStyle")]
	public partial class FAudioRadialSliderStyle : FSlateWidgetStyle, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AudioWidgets.AudioRadialSliderStyle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAudioRadialSliderStyle()
		{
		}

		public static bool operator ==(FAudioRadialSliderStyle A, FAudioRadialSliderStyle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAudioRadialSliderStyle A, FAudioRadialSliderStyle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAudioRadialSliderStyle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FAudioTextBoxStyle TextBoxStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TextBoxStyle, __ReturnBuffer);

					return *(FAudioTextBoxStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TextBoxStyle, __InBuffer);
				}
			}
		}

		public FSlateColor CenterBackgroundColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CenterBackgroundColor, __ReturnBuffer);

					return *(FSlateColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CenterBackgroundColor, __InBuffer);
				}
			}
		}

		public FSlateColor SliderBarColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SliderBarColor, __ReturnBuffer);

					return *(FSlateColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SliderBarColor, __InBuffer);
				}
			}
		}

		public FSlateColor SliderProgressColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SliderProgressColor, __ReturnBuffer);

					return *(FSlateColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SliderProgressColor, __InBuffer);
				}
			}
		}

		public float LabelPadding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LabelPadding, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LabelPadding, __InBuffer);
				}
			}
		}

		public float DefaultSliderRadius
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultSliderRadius, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultSliderRadius, __InBuffer);
				}
			}
		}

		private static uint __TextBoxStyle = 0;

		private static uint __CenterBackgroundColor = 0;

		private static uint __SliderBarColor = 0;

		private static uint __SliderProgressColor = 0;

		private static uint __LabelPadding = 0;

		private static uint __DefaultSliderRadius = 0;

	}
}