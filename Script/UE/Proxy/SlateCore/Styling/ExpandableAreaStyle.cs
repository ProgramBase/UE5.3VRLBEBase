using Script.CoreUObject;
using Script.Library;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.ExpandableAreaStyle")]
	public partial class FExpandableAreaStyle : FSlateWidgetStyle, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SlateCore.ExpandableAreaStyle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FExpandableAreaStyle()
		{
		}

		public static bool operator ==(FExpandableAreaStyle A, FExpandableAreaStyle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FExpandableAreaStyle A, FExpandableAreaStyle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FExpandableAreaStyle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FSlateBrush CollapsedImage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CollapsedImage, __ReturnBuffer);

					return *(FSlateBrush*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CollapsedImage, __InBuffer);
				}
			}
		}

		public FSlateBrush ExpandedImage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExpandedImage, __ReturnBuffer);

					return *(FSlateBrush*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExpandedImage, __InBuffer);
				}
			}
		}

		public float RolloutAnimationSeconds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RolloutAnimationSeconds, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RolloutAnimationSeconds, __InBuffer);
				}
			}
		}

		private static uint __CollapsedImage = 0;

		private static uint __ExpandedImage = 0;

		private static uint __RolloutAnimationSeconds = 0;

	}
}