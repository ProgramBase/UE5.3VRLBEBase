using Script.CoreUObject;
using Script.Library;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.InlineEditableTextBlockStyle")]
	public partial class FInlineEditableTextBlockStyle : FSlateWidgetStyle, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SlateCore.InlineEditableTextBlockStyle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInlineEditableTextBlockStyle()
		{
		}

		public static bool operator ==(FInlineEditableTextBlockStyle A, FInlineEditableTextBlockStyle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInlineEditableTextBlockStyle A, FInlineEditableTextBlockStyle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInlineEditableTextBlockStyle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FEditableTextBoxStyle EditableTextBoxStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EditableTextBoxStyle, __ReturnBuffer);

					return *(FEditableTextBoxStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EditableTextBoxStyle, __InBuffer);
				}
			}
		}

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

		private static uint __EditableTextBoxStyle = 0;

		private static uint __TextStyle = 0;

	}
}