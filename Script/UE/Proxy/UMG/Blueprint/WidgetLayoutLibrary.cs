using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.SlateCore;

namespace Script.UMG
{
	[PathName("/Script/UMG.WidgetLayoutLibrary")]
	public partial class UWidgetLayoutLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.WidgetLayoutLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Widget">
		/// The child widget of a Wrap Box.
		/// </param>
		public static UWrapBoxSlot SlotAsWrapBoxSlot(UWidget Widget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SlotAsWrapBoxSlot, __InBuffer, __ReturnBuffer);

				return *(UWrapBoxSlot*)__ReturnBuffer;
			}
		}

		/// <param name="Widget">
		/// The child widget of a Widget Switcher Slot.
		/// </param>
		public static UWidgetSwitcherSlot SlotAsWidgetSwitcherSlot(UWidget Widget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SlotAsWidgetSwitcherSlot, __InBuffer, __ReturnBuffer);

				return *(UWidgetSwitcherSlot*)__ReturnBuffer;
			}
		}

		/// <param name="Widget">
		/// The child widget of a Vertical Box.
		/// </param>
		public static UVerticalBoxSlot SlotAsVerticalBoxSlot(UWidget Widget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SlotAsVerticalBoxSlot, __InBuffer, __ReturnBuffer);

				return *(UVerticalBoxSlot*)__ReturnBuffer;
			}
		}

		/// <param name="Widget">
		/// The child widget of a uniform grid panel.
		/// </param>
		public static UUniformGridSlot SlotAsUniformGridSlot(UWidget Widget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SlotAsUniformGridSlot, __InBuffer, __ReturnBuffer);

				return *(UUniformGridSlot*)__ReturnBuffer;
			}
		}

		/// <param name="Widget">
		/// The child widget of a Size Box.
		/// </param>
		public static USizeBoxSlot SlotAsSizeBoxSlot(UWidget Widget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SlotAsSizeBoxSlot, __InBuffer, __ReturnBuffer);

				return *(USizeBoxSlot*)__ReturnBuffer;
			}
		}

		/// <param name="Widget">
		/// The child widget of a Scroll Box.
		/// </param>
		public static UScrollBoxSlot SlotAsScrollBoxSlot(UWidget Widget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SlotAsScrollBoxSlot, __InBuffer, __ReturnBuffer);

				return *(UScrollBoxSlot*)__ReturnBuffer;
			}
		}

		/// <param name="Widget">
		/// The child widget of a Scale Box.
		/// </param>
		public static UScaleBoxSlot SlotAsScaleBoxSlot(UWidget Widget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SlotAsScaleBoxSlot, __InBuffer, __ReturnBuffer);

				return *(UScaleBoxSlot*)__ReturnBuffer;
			}
		}

		/// <param name="Widget">
		/// The child widget of a Safe Box.
		/// </param>
		public static USafeZoneSlot SlotAsSafeBoxSlot(UWidget Widget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SlotAsSafeBoxSlot, __InBuffer, __ReturnBuffer);

				return *(USafeZoneSlot*)__ReturnBuffer;
			}
		}

		/// <param name="Widget">
		/// The child widget of a overlay panel.
		/// </param>
		public static UOverlaySlot SlotAsOverlaySlot(UWidget Widget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SlotAsOverlaySlot, __InBuffer, __ReturnBuffer);

				return *(UOverlaySlot*)__ReturnBuffer;
			}
		}

		/// <param name="Widget">
		/// The child widget of a Horizontal Box.
		/// </param>
		public static UHorizontalBoxSlot SlotAsHorizontalBoxSlot(UWidget Widget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SlotAsHorizontalBoxSlot, __InBuffer, __ReturnBuffer);

				return *(UHorizontalBoxSlot*)__ReturnBuffer;
			}
		}

		/// <param name="Widget">
		/// The child widget of a grid panel.
		/// </param>
		public static UGridSlot SlotAsGridSlot(UWidget Widget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SlotAsGridSlot, __InBuffer, __ReturnBuffer);

				return *(UGridSlot*)__ReturnBuffer;
			}
		}

		/// <param name="Widget">
		/// The child widget of a canvas panel.
		/// </param>
		public static UCanvasPanelSlot SlotAsCanvasSlot(UWidget Widget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SlotAsCanvasSlot, __InBuffer, __ReturnBuffer);

				return *(UCanvasPanelSlot*)__ReturnBuffer;
			}
		}

		/// <param name="Widget">
		/// The child widget of a border panel.
		/// </param>
		public static UBorderSlot SlotAsBorderSlot(UWidget Widget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SlotAsBorderSlot, __InBuffer, __ReturnBuffer);

				return *(UBorderSlot*)__ReturnBuffer;
			}
		}

		public static void RemoveAllWidgets(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveAllWidgets, __InBuffer);
			}
		}

		/// <param name="PlayerController">
		/// The player controller to project the position in the world to their screen.
		/// </param>
		/// <param name="WorldLocation">
		/// The world location to project from.
		/// </param>
		/// <param name="ScreenPosition">
		/// The position in the viewport with quality scale removed and DPI scale remove.
		/// </param>
		/// <param name="bPlayerViewportRelative">
		/// Should this be relative to the player viewport subregion (useful when using player attached widgets in split screen or when aspect-ratio constrained)
		/// </param>
		/// <returns>
		/// true if the position projects onto the screen.
		/// </returns>
		public static bool ProjectWorldLocationToWidgetPosition(APlayerController PlayerController, FVector WorldLocation, ref FVector2D ScreenPosition, bool bPlayerViewportRelative)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = WorldLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ScreenPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bPlayerViewportRelative;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __ProjectWorldLocationToWidgetPosition, __InBuffer, __OutBuffer, __ReturnBuffer);

				ScreenPosition = *(FVector2D*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FGeometry GetViewportWidgetGeometry(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetViewportWidgetGeometry, __InBuffer, __ReturnBuffer);

				return *(FGeometry*)__ReturnBuffer;
			}
		}

		public static FVector2D GetViewportSize(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetViewportSize, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static float GetViewportScale(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetViewportScale, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static FGeometry GetPlayerScreenWidgetGeometry(APlayerController PlayerController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPlayerScreenWidgetGeometry, __InBuffer, __ReturnBuffer);

				return *(FGeometry*)__ReturnBuffer;
			}
		}

		public static bool GetMousePositionScaledByDPI(APlayerController Player, ref float LocationX, ref float LocationY)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Player?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = LocationX;

				*(float*)(__InBuffer + 12) = LocationY;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetMousePositionScaledByDPI, __InBuffer, __OutBuffer, __ReturnBuffer);

				LocationX = *(float*)(__OutBuffer);

				LocationY = *(float*)(__OutBuffer + 4);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FVector2D GetMousePositionOnViewport(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMousePositionOnViewport, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static FVector2D GetMousePositionOnPlatform()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetMousePositionOnPlatform, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		private static uint __SlotAsWrapBoxSlot = 0;

		private static uint __SlotAsWidgetSwitcherSlot = 0;

		private static uint __SlotAsVerticalBoxSlot = 0;

		private static uint __SlotAsUniformGridSlot = 0;

		private static uint __SlotAsSizeBoxSlot = 0;

		private static uint __SlotAsScrollBoxSlot = 0;

		private static uint __SlotAsScaleBoxSlot = 0;

		private static uint __SlotAsSafeBoxSlot = 0;

		private static uint __SlotAsOverlaySlot = 0;

		private static uint __SlotAsHorizontalBoxSlot = 0;

		private static uint __SlotAsGridSlot = 0;

		private static uint __SlotAsCanvasSlot = 0;

		private static uint __SlotAsBorderSlot = 0;

		private static uint __RemoveAllWidgets = 0;

		private static uint __ProjectWorldLocationToWidgetPosition = 0;

		private static uint __GetViewportWidgetGeometry = 0;

		private static uint __GetViewportSize = 0;

		private static uint __GetViewportScale = 0;

		private static uint __GetPlayerScreenWidgetGeometry = 0;

		private static uint __GetMousePositionScaledByDPI = 0;

		private static uint __GetMousePositionOnViewport = 0;

		private static uint __GetMousePositionOnPlatform = 0;
	}
}