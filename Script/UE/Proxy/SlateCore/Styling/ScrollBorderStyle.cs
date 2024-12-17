using Script.CoreUObject;
using Script.Library;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.ScrollBorderStyle")]
	public partial class FScrollBorderStyle : FSlateWidgetStyle, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SlateCore.ScrollBorderStyle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FScrollBorderStyle()
		{
		}

		public static bool operator ==(FScrollBorderStyle A, FScrollBorderStyle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FScrollBorderStyle A, FScrollBorderStyle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FScrollBorderStyle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FSlateBrush TopShadowBrush
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TopShadowBrush, __ReturnBuffer);

					return *(FSlateBrush*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TopShadowBrush, __InBuffer);
				}
			}
		}

		public FSlateBrush BottomShadowBrush
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BottomShadowBrush, __ReturnBuffer);

					return *(FSlateBrush*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BottomShadowBrush, __InBuffer);
				}
			}
		}

		private static uint __TopShadowBrush = 0;

		private static uint __BottomShadowBrush = 0;

	}
}