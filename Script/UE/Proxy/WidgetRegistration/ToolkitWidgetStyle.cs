using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;

namespace Script.WidgetRegistration
{
	[PathName("/Script/WidgetRegistration.ToolkitWidgetStyle")]
	public partial class FToolkitWidgetStyle : FSlateWidgetStyle, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/WidgetRegistration.ToolkitWidgetStyle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FToolkitWidgetStyle()
		{
		}

		public static bool operator ==(FToolkitWidgetStyle A, FToolkitWidgetStyle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FToolkitWidgetStyle A, FToolkitWidgetStyle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FToolkitWidgetStyle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FSlateBrush TitleBackgroundBrush
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TitleBackgroundBrush, __ReturnBuffer);

					return *(FSlateBrush*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TitleBackgroundBrush, __InBuffer);
				}
			}
		}

		public FSlateBrush ToolDetailsBackgroundBrush
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ToolDetailsBackgroundBrush, __ReturnBuffer);

					return *(FSlateBrush*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ToolDetailsBackgroundBrush, __InBuffer);
				}
			}
		}

		public FSlateColor TitleForegroundColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TitleForegroundColor, __ReturnBuffer);

					return *(FSlateColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TitleForegroundColor, __InBuffer);
				}
			}
		}

		public FMargin TitlePadding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TitlePadding, __ReturnBuffer);

					return *(FMargin*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TitlePadding, __InBuffer);
				}
			}
		}

		public FMargin ActiveToolTitleBorderPadding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ActiveToolTitleBorderPadding, __ReturnBuffer);

					return *(FMargin*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ActiveToolTitleBorderPadding, __InBuffer);
				}
			}
		}

		public FMargin ToolContextTextBlockPadding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ToolContextTextBlockPadding, __ReturnBuffer);

					return *(FMargin*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ToolContextTextBlockPadding, __InBuffer);
				}
			}
		}

		public FSlateFontInfo TitleFont
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TitleFont, __ReturnBuffer);

					return *(FSlateFontInfo*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TitleFont, __InBuffer);
				}
			}
		}

		private static uint __TitleBackgroundBrush = 0;

		private static uint __ToolDetailsBackgroundBrush = 0;

		private static uint __TitleForegroundColor = 0;

		private static uint __TitlePadding = 0;

		private static uint __ActiveToolTitleBorderPadding = 0;

		private static uint __ToolContextTextBlockPadding = 0;

		private static uint __TitleFont = 0;

	}
}