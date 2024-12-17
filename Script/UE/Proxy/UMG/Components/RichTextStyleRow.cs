using Script.CoreUObject;
using Script.Library;
using Script.Engine;
using Script.SlateCore;

namespace Script.UMG
{
	[PathName("/Script/UMG.RichTextStyleRow")]
	public partial class FRichTextStyleRow : FTableRowBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UMG.RichTextStyleRow");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRichTextStyleRow()
		{
		}

		public static bool operator ==(FRichTextStyleRow A, FRichTextStyleRow B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRichTextStyleRow A, FRichTextStyleRow B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRichTextStyleRow;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FTextBlockStyle TextStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TextStyle, __ReturnBuffer);

					return *(FTextBlockStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TextStyle, __InBuffer);
				}
			}
		}

		private static uint __TextStyle = 0;

	}
}