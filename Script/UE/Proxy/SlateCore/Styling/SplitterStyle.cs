using Script.CoreUObject;
using Script.Library;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.SplitterStyle")]
	public partial class FSplitterStyle : FSlateWidgetStyle, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SlateCore.SplitterStyle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSplitterStyle()
		{
		}

		public static bool operator ==(FSplitterStyle A, FSplitterStyle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSplitterStyle A, FSplitterStyle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSplitterStyle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FSlateBrush HandleNormalBrush
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HandleNormalBrush, __ReturnBuffer);

					return *(FSlateBrush*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HandleNormalBrush, __InBuffer);
				}
			}
		}

		public FSlateBrush HandleHighlightBrush
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HandleHighlightBrush, __ReturnBuffer);

					return *(FSlateBrush*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HandleHighlightBrush, __InBuffer);
				}
			}
		}

		private static uint __HandleNormalBrush = 0;

		private static uint __HandleHighlightBrush = 0;

	}
}