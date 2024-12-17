using Script.CoreUObject;
using Script.Library;
using Script.Engine;
using Script.SlateCore;

namespace Script.UMG
{
	[PathName("/Script/UMG.RichImageRow")]
	public partial class FRichImageRow : FTableRowBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UMG.RichImageRow");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRichImageRow()
		{
		}

		public static bool operator ==(FRichImageRow A, FRichImageRow B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRichImageRow A, FRichImageRow B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRichImageRow;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FSlateBrush Brush
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Brush, __ReturnBuffer);

					return *(FSlateBrush*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Brush, __InBuffer);
				}
			}
		}

		private static uint __Brush = 0;

	}
}