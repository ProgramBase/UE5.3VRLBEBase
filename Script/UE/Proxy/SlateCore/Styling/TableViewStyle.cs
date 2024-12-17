using Script.CoreUObject;
using Script.Library;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.TableViewStyle")]
	public partial class FTableViewStyle : FSlateWidgetStyle, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SlateCore.TableViewStyle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTableViewStyle()
		{
		}

		public static bool operator ==(FTableViewStyle A, FTableViewStyle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTableViewStyle A, FTableViewStyle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTableViewStyle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FSlateBrush BackgroundBrush
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BackgroundBrush, __ReturnBuffer);

					return *(FSlateBrush*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BackgroundBrush, __InBuffer);
				}
			}
		}

		private static uint __BackgroundBrush = 0;

	}
}