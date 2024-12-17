using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.SynthSlateStyle")]
	public partial class FSynthSlateStyle : FSlateWidgetStyle, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Synthesis.SynthSlateStyle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSynthSlateStyle()
		{
		}

		public static bool operator ==(FSynthSlateStyle A, FSynthSlateStyle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSynthSlateStyle A, FSynthSlateStyle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSynthSlateStyle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ESynthSlateSizeType SizeType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SizeType, __ReturnBuffer);

					return *(ESynthSlateSizeType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SizeType, __InBuffer);
				}
			}
		}

		public ESynthSlateColorStyle ColorStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ColorStyle, __ReturnBuffer);

					return *(ESynthSlateColorStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ColorStyle, __InBuffer);
				}
			}
		}

		private static uint __SizeType = 0;

		private static uint __ColorStyle = 0;

	}
}