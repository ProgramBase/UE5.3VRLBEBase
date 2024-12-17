using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;

namespace Script.PIEPreviewDeviceProfileSelector
{
	[PathName("/Script/PIEPreviewDeviceProfileSelector.PIEPreviewWindowStyle")]
	public partial class FPIEPreviewWindowStyle : FSlateWidgetStyle, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/PIEPreviewDeviceProfileSelector.PIEPreviewWindowStyle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPIEPreviewWindowStyle()
		{
		}

		public static bool operator ==(FPIEPreviewWindowStyle A, FPIEPreviewWindowStyle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPIEPreviewWindowStyle A, FPIEPreviewWindowStyle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPIEPreviewWindowStyle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FButtonStyle ScreenRotationButtonStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ScreenRotationButtonStyle, __ReturnBuffer);

					return *(FButtonStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ScreenRotationButtonStyle, __InBuffer);
				}
			}
		}

		public FButtonStyle QuarterMobileContentScaleFactorButtonStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __QuarterMobileContentScaleFactorButtonStyle, __ReturnBuffer);

					return *(FButtonStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __QuarterMobileContentScaleFactorButtonStyle, __InBuffer);
				}
			}
		}

		public FButtonStyle HalfMobileContentScaleFactorButtonStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HalfMobileContentScaleFactorButtonStyle, __ReturnBuffer);

					return *(FButtonStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HalfMobileContentScaleFactorButtonStyle, __InBuffer);
				}
			}
		}

		public FButtonStyle FullMobileContentScaleFactorButtonStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FullMobileContentScaleFactorButtonStyle, __ReturnBuffer);

					return *(FButtonStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FullMobileContentScaleFactorButtonStyle, __InBuffer);
				}
			}
		}

		private static uint __ScreenRotationButtonStyle = 0;

		private static uint __QuarterMobileContentScaleFactorButtonStyle = 0;

		private static uint __HalfMobileContentScaleFactorButtonStyle = 0;

		private static uint __FullMobileContentScaleFactorButtonStyle = 0;

	}
}