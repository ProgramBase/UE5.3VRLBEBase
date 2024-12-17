using Script.CoreUObject;
using Script.Library;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.InlineTextImageStyle")]
	public partial class FInlineTextImageStyle : FSlateWidgetStyle, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SlateCore.InlineTextImageStyle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInlineTextImageStyle()
		{
		}

		public static bool operator ==(FInlineTextImageStyle A, FInlineTextImageStyle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInlineTextImageStyle A, FInlineTextImageStyle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInlineTextImageStyle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FSlateBrush Image
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Image, __ReturnBuffer);

					return *(FSlateBrush*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Image, __InBuffer);
				}
			}
		}

		public short Baseline
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Baseline, __ReturnBuffer);

					return *(short*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(short*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Baseline, __InBuffer);
				}
			}
		}

		private static uint __Image = 0;

		private static uint __Baseline = 0;

	}
}