using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;

namespace Script.AudioWidgets
{
	[PathName("/Script/AudioWidgets.AudioTextBoxStyle")]
	public partial class FAudioTextBoxStyle : FSlateWidgetStyle, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AudioWidgets.AudioTextBoxStyle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAudioTextBoxStyle()
		{
		}

		public static bool operator ==(FAudioTextBoxStyle A, FAudioTextBoxStyle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAudioTextBoxStyle A, FAudioTextBoxStyle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAudioTextBoxStyle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FSlateBrush BackgroundImage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BackgroundImage, __ReturnBuffer);

					return *(FSlateBrush*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BackgroundImage, __InBuffer);
				}
			}
		}

		public FSlateColor BackgroundColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BackgroundColor, __ReturnBuffer);

					return *(FSlateColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BackgroundColor, __InBuffer);
				}
			}
		}

		private static uint __BackgroundImage = 0;

		private static uint __BackgroundColor = 0;

	}
}