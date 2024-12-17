using Script.CoreUObject;
using Script.SlateCore;
using Script.Slate;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.ScrollBox")]
	public partial class UScrollBox : UPanelWidget, IStaticClass
	{
		public FScrollBoxStyle WidgetStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WidgetStyle, __ReturnBuffer);

					return *(FScrollBoxStyle*)__ReturnBuffer;
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

		public FScrollBarStyle WidgetBarStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WidgetBarStyle, __ReturnBuffer);

					return *(FScrollBarStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WidgetBarStyle, __InBuffer);
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

		public ESlateVisibility ScrollBarVisibility
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ScrollBarVisibility, __ReturnBuffer);

					return *(ESlateVisibility*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ScrollBarVisibility, __InBuffer);
				}
			}
		}

		public EConsumeMouseWheel ConsumeMouseWheel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ConsumeMouseWheel, __ReturnBuffer);

					return *(EConsumeMouseWheel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ConsumeMouseWheel, __InBuffer);
				}
			}
		}

		public FVector2D ScrollbarThickness
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ScrollbarThickness, __ReturnBuffer);

					return *(FVector2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ScrollbarThickness, __InBuffer);
				}
			}
		}

		public FMargin ScrollbarPadding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ScrollbarPadding, __ReturnBuffer);

					return *(FMargin*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ScrollbarPadding, __InBuffer);
				}
			}
		}

		public bool AlwaysShowScrollbar
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AlwaysShowScrollbar, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AlwaysShowScrollbar, __InBuffer);
				}
			}
		}

		public bool AlwaysShowScrollbarTrack
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AlwaysShowScrollbarTrack, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AlwaysShowScrollbarTrack, __InBuffer);
				}
			}
		}

		public bool AllowOverscroll
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AllowOverscroll, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AllowOverscroll, __InBuffer);
				}
			}
		}

		public bool BackPadScrolling
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BackPadScrolling, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BackPadScrolling, __InBuffer);
				}
			}
		}

		public bool FrontPadScrolling
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FrontPadScrolling, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FrontPadScrolling, __InBuffer);
				}
			}
		}

		public bool bAnimateWheelScrolling
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAnimateWheelScrolling, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAnimateWheelScrolling, __InBuffer);
				}
			}
		}

		public EDescendantScrollDestination NavigationDestination
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NavigationDestination, __ReturnBuffer);

					return *(EDescendantScrollDestination*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NavigationDestination, __InBuffer);
				}
			}
		}

		public float NavigationScrollPadding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NavigationScrollPadding, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NavigationScrollPadding, __InBuffer);
				}
			}
		}

		public EScrollWhenFocusChanges ScrollWhenFocusChanges
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ScrollWhenFocusChanges, __ReturnBuffer);

					return *(EScrollWhenFocusChanges*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ScrollWhenFocusChanges, __InBuffer);
				}
			}
		}

		public bool bAllowRightClickDragScrolling
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowRightClickDragScrolling, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowRightClickDragScrolling, __InBuffer);
				}
			}
		}

		public float WheelScrollMultiplier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WheelScrollMultiplier, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WheelScrollMultiplier, __InBuffer);
				}
			}
		}

		public FOnUserScrolledEvent OnUserScrolled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnUserScrolled, __ReturnBuffer);

					return *(FOnUserScrolledEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnUserScrolled, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.ScrollBox");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetWheelScrollMultiplier(float NewWheelScrollMultiplier)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewWheelScrollMultiplier;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetWheelScrollMultiplier, __InBuffer);
			}
		}

		public virtual void SetScrollWhenFocusChanges(EScrollWhenFocusChanges NewScrollWhenFocusChanges)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)NewScrollWhenFocusChanges;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetScrollWhenFocusChanges, __InBuffer);
			}
		}

		/// <param name="NewScrollOffset">
		/// is in Slate Units.
		/// </param>
		public virtual void SetScrollOffset(float NewScrollOffset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewScrollOffset;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetScrollOffset, __InBuffer);
			}
		}

		public virtual void SetScrollBarVisibility(ESlateVisibility NewScrollBarVisibility)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)NewScrollBarVisibility;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetScrollBarVisibility, __InBuffer);
			}
		}

		public virtual void SetScrollbarThickness(FVector2D NewScrollbarThickness)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewScrollbarThickness?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetScrollbarThickness, __InBuffer);
			}
		}

		public virtual void SetScrollbarPadding(FMargin NewScrollbarPadding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewScrollbarPadding?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetScrollbarPadding, __InBuffer);
			}
		}

		public virtual void SetOrientation(EOrientation NewOrientation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)NewOrientation;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOrientation, __InBuffer);
			}
		}

		public virtual void SetNavigationDestination(EDescendantScrollDestination NewNavigationDestination)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)NewNavigationDestination;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNavigationDestination, __InBuffer);
			}
		}

		public virtual void SetConsumeMouseWheel(EConsumeMouseWheel NewConsumeMouseWheel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)NewConsumeMouseWheel;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetConsumeMouseWheel, __InBuffer);
			}
		}

		public virtual void SetAnimateWheelScrolling(bool bShouldAnimateWheelScrolling)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bShouldAnimateWheelScrolling;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAnimateWheelScrolling, __InBuffer);
			}
		}

		public virtual void SetAlwaysShowScrollbar(bool NewAlwaysShowScrollbar)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = NewAlwaysShowScrollbar;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAlwaysShowScrollbar, __InBuffer);
			}
		}

		public virtual void SetAllowOverscroll(bool NewAllowOverscroll)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = NewAllowOverscroll;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAllowOverscroll, __InBuffer);
			}
		}

		public virtual void ScrollWidgetIntoView(UWidget WidgetToFind, bool AnimateScroll = true, EDescendantScrollDestination ScrollDestination = EDescendantScrollDestination.IntoView, float Padding = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[14];

				*(nint*)(__InBuffer) = WidgetToFind?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = AnimateScroll;

				*(byte*)(__InBuffer + 9) = (byte)ScrollDestination;

				*(float*)(__InBuffer + 10) = Padding;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ScrollWidgetIntoView, __InBuffer);
			}
		}

		public virtual void ScrollToStart()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ScrollToStart);
			}
		}

		public virtual void ScrollToEnd()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ScrollToEnd);
			}
		}

		public virtual float GetViewOffsetFraction()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetViewOffsetFraction, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetViewFraction()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetViewFraction, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetScrollOffsetOfEnd()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetScrollOffsetOfEnd, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetScrollOffset()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetScrollOffset, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual void EndInertialScrolling()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __EndInertialScrolling);
			}
		}

		private static uint __WidgetStyle = 0;

		private static uint __WidgetBarStyle = 0;

		private static uint __Orientation = 0;

		private static uint __ScrollBarVisibility = 0;

		private static uint __ConsumeMouseWheel = 0;

		private static uint __ScrollbarThickness = 0;

		private static uint __ScrollbarPadding = 0;

		private static uint __AlwaysShowScrollbar = 0;

		private static uint __AlwaysShowScrollbarTrack = 0;

		private static uint __AllowOverscroll = 0;

		private static uint __BackPadScrolling = 0;

		private static uint __FrontPadScrolling = 0;

		private static uint __bAnimateWheelScrolling = 0;

		private static uint __NavigationDestination = 0;

		private static uint __NavigationScrollPadding = 0;

		private static uint __ScrollWhenFocusChanges = 0;

		private static uint __bAllowRightClickDragScrolling = 0;

		private static uint __WheelScrollMultiplier = 0;

		private static uint __OnUserScrolled = 0;

		private static uint __SetWheelScrollMultiplier = 0;

		private static uint __SetScrollWhenFocusChanges = 0;

		private static uint __SetScrollOffset = 0;

		private static uint __SetScrollBarVisibility = 0;

		private static uint __SetScrollbarThickness = 0;

		private static uint __SetScrollbarPadding = 0;

		private static uint __SetOrientation = 0;

		private static uint __SetNavigationDestination = 0;

		private static uint __SetConsumeMouseWheel = 0;

		private static uint __SetAnimateWheelScrolling = 0;

		private static uint __SetAlwaysShowScrollbar = 0;

		private static uint __SetAllowOverscroll = 0;

		private static uint __ScrollWidgetIntoView = 0;

		private static uint __ScrollToStart = 0;

		private static uint __ScrollToEnd = 0;

		private static uint __GetViewOffsetFraction = 0;

		private static uint __GetViewFraction = 0;

		private static uint __GetScrollOffsetOfEnd = 0;

		private static uint __GetScrollOffset = 0;

		private static uint __EndInertialScrolling = 0;
	}
}