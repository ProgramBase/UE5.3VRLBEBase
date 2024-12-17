using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;

namespace Script.AudioWidgets
{
	[PathName("/Script/AudioWidgets.SampledSequenceValueGridOverlayStyle")]
	public partial class FSampledSequenceValueGridOverlayStyle : FSlateWidgetStyle, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AudioWidgets.SampledSequenceValueGridOverlayStyle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSampledSequenceValueGridOverlayStyle()
		{
		}

		public static bool operator ==(FSampledSequenceValueGridOverlayStyle A, FSampledSequenceValueGridOverlayStyle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSampledSequenceValueGridOverlayStyle A, FSampledSequenceValueGridOverlayStyle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSampledSequenceValueGridOverlayStyle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FSlateColor GridColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GridColor, __ReturnBuffer);

					return *(FSlateColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GridColor, __InBuffer);
				}
			}
		}

		public float GridThickness
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GridThickness, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GridThickness, __InBuffer);
				}
			}
		}

		public FSlateColor LabelTextColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LabelTextColor, __ReturnBuffer);

					return *(FSlateColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LabelTextColor, __InBuffer);
				}
			}
		}

		public FSlateFontInfo LabelTextFont
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LabelTextFont, __ReturnBuffer);

					return *(FSlateFontInfo*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LabelTextFont, __InBuffer);
				}
			}
		}

		public float DesiredWidth
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DesiredWidth, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DesiredWidth, __InBuffer);
				}
			}
		}

		public float DesiredHeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DesiredHeight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DesiredHeight, __InBuffer);
				}
			}
		}

		private static uint __GridColor = 0;

		private static uint __GridThickness = 0;

		private static uint __LabelTextColor = 0;

		private static uint __LabelTextFont = 0;

		private static uint __DesiredWidth = 0;

		private static uint __DesiredHeight = 0;

	}
}