using Script.CoreUObject;
using Script.SlateCore;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.ScrollBar")]
	public partial class UScrollBar : UWidget, IStaticClass
	{
		public FScrollBarStyle WidgetStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WidgetStyle, __ReturnBuffer);

					return *(FScrollBarStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WidgetStyle, __InBuffer);
				}
			}
		}

		public bool bAlwaysShowScrollbar
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAlwaysShowScrollbar, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAlwaysShowScrollbar, __InBuffer);
				}
			}
		}

		public bool bAlwaysShowScrollbarTrack
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAlwaysShowScrollbarTrack, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAlwaysShowScrollbarTrack, __InBuffer);
				}
			}
		}

		public EOrientation Orientation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Orientation, __ReturnBuffer);

					return *(EOrientation*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Orientation, __InBuffer);
				}
			}
		}

		public FVector2D Thickness
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Thickness, __ReturnBuffer);

					return *(FVector2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Thickness, __InBuffer);
				}
			}
		}

		public FMargin Padding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Padding, __ReturnBuffer);

					return *(FMargin*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Padding, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.ScrollBar");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="InOffsetFraction">
		/// Offset of the thumbnail from the top as a fraction of the total available scroll space.
		/// </param>
		/// <param name="InThumbSizeFraction">
		/// Size of thumbnail as a fraction of the total available scroll space.
		/// </param>
		public virtual void SetState(float InOffsetFraction, float InThumbSizeFraction)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = InOffsetFraction;

				*(float*)(__InBuffer + 4) = InThumbSizeFraction;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetState, __InBuffer);
			}
		}

		private static uint __WidgetStyle = 0;

		private static uint __bAlwaysShowScrollbar = 0;

		private static uint __bAlwaysShowScrollbarTrack = 0;

		private static uint __Orientation = 0;

		private static uint __Thickness = 0;

		private static uint __Padding = 0;

		private static uint __SetState = 0;
	}
}