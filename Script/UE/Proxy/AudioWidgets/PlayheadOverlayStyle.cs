using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;

namespace Script.AudioWidgets
{
	[PathName("/Script/AudioWidgets.PlayheadOverlayStyle")]
	public partial class FPlayheadOverlayStyle : FSlateWidgetStyle, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AudioWidgets.PlayheadOverlayStyle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPlayheadOverlayStyle()
		{
		}

		public static bool operator ==(FPlayheadOverlayStyle A, FPlayheadOverlayStyle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPlayheadOverlayStyle A, FPlayheadOverlayStyle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPlayheadOverlayStyle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FSlateColor PlayheadColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PlayheadColor, __ReturnBuffer);

					return *(FSlateColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PlayheadColor, __InBuffer);
				}
			}
		}

		public float PlayheadWidth
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PlayheadWidth, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PlayheadWidth, __InBuffer);
				}
			}
		}

		public float DesiredWidth
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DesiredWidth, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DesiredWidth, __InBuffer);
				}
			}
		}

		public float DesiredHeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DesiredHeight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DesiredHeight, __InBuffer);
				}
			}
		}

		private static uint __PlayheadColor = 0;

		private static uint __PlayheadWidth = 0;

		private static uint __DesiredWidth = 0;

		private static uint __DesiredHeight = 0;

	}
}