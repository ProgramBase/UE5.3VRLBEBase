using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.UMG.WidgetBlueprintLibrary;
using Script.SlateCore;
using Script.InputCore;

namespace Script.UMG
{
	[PathName("/Script/UMG.WidgetBlueprintLibrary")]
	public partial class UWidgetBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.WidgetBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FEventReply UnlockMouse(ref FEventReply Reply)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Reply?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __UnlockMouse, __InBuffer, __OutBuffer, __ReturnBuffer);

				Reply = *(FEventReply*)(__OutBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		public static FEventReply Unhandled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __Unhandled, __ReturnBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		public static void SetWindowTitleBarState(UWidget TitleBarContent, EWindowTitleBarMode Mode, bool bTitleBarDragEnabled, bool bWindowButtonsVisible, bool bTitleBarVisible)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = TitleBarContent?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Mode;

				*(bool*)(__InBuffer + 9) = bTitleBarDragEnabled;

				*(bool*)(__InBuffer + 10) = bWindowButtonsVisible;

				*(bool*)(__InBuffer + 11) = bTitleBarVisible;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetWindowTitleBarState, __InBuffer);
			}
		}

		public static void SetWindowTitleBarOnCloseClickedDelegate(FOnGameWindowCloseButtonClickedDelegate Delegate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetWindowTitleBarOnCloseClickedDelegate, __InBuffer);
			}
		}

		public static void SetWindowTitleBarCloseButtonActive(bool bActive)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bActive;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetWindowTitleBarCloseButtonActive, __InBuffer);
			}
		}

		public static FEventReply SetUserFocus(ref FEventReply Reply, UWidget FocusWidget, bool bInAllUsers = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Reply?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FocusWidget?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bInAllUsers;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __SetUserFocus, __InBuffer, __OutBuffer, __ReturnBuffer);

				Reply = *(FEventReply*)(__OutBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		public static FEventReply SetMousePosition(ref FEventReply Reply, FVector2D NewMousePosition)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Reply?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewMousePosition?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __SetMousePosition, __InBuffer, __OutBuffer, __ReturnBuffer);

				Reply = *(FEventReply*)(__OutBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		public static void SetInputMode_UIOnlyEx(APlayerController PlayerController, UWidget InWidgetToFocus = null, EMouseLockMode InMouseLockMode = EMouseLockMode.DoNotLock, bool bFlushInput = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InWidgetToFocus?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)InMouseLockMode;

				*(bool*)(__InBuffer + 17) = bFlushInput;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetInputMode_UIOnlyEx, __InBuffer);
			}
		}

		public static void SetInputMode_GameOnly(APlayerController PlayerController, bool bFlushInput = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bFlushInput;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetInputMode_GameOnly, __InBuffer);
			}
		}

		public static void SetInputMode_GameAndUIEx(APlayerController PlayerController, UWidget InWidgetToFocus = null, EMouseLockMode InMouseLockMode = EMouseLockMode.DoNotLock, bool bHideCursorDuringCapture = true, bool bFlushInput = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InWidgetToFocus?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)InMouseLockMode;

				*(bool*)(__InBuffer + 17) = bHideCursorDuringCapture;

				*(bool*)(__InBuffer + 18) = bFlushInput;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetInputMode_GameAndUIEx, __InBuffer);
			}
		}

		public static bool SetHardwareCursor(UObject WorldContextObject, EMouseCursor CursorShape, FName CursorName, FVector2D HotSpot)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)CursorShape;

				*(nint*)(__InBuffer + 9) = CursorName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 17) = HotSpot?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetHardwareCursor, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void SetFocusToGameViewport()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __SetFocusToGameViewport);
			}
		}

		/// <param name="Type">
		/// The type of color deficiency correction to apply.
		/// </param>
		/// <param name="Severity">
		/// Intensity of the color deficiency correction effect, from 0 to 1.
		/// </param>
		/// <param name="CorrectDeficiency">
		/// Shifts the color spectrum to the visible range based on the current deficiency type.
		/// </param>
		/// <param name="ShowCorrectionWithDeficiency">
		/// If you're correcting the color deficiency, you can use this to visualize what the correction looks like with the deficiency.
		/// </param>
		public static void SetColorVisionDeficiencyType(EColorVisionDeficiency Type, float Severity, bool CorrectDeficiency, bool ShowCorrectionWithDeficiency)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[7];

				*(byte*)(__InBuffer) = (byte)Type;

				*(float*)(__InBuffer + 1) = Severity;

				*(bool*)(__InBuffer + 5) = CorrectDeficiency;

				*(bool*)(__InBuffer + 6) = ShowCorrectionWithDeficiency;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetColorVisionDeficiencyType, __InBuffer);
			}
		}

		public static void SetBrushResourceToTexture(ref FSlateBrush Brush, UTexture2D Texture)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Brush?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Texture?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetBrushResourceToTexture, __InBuffer, __OutBuffer);

				Brush = *(FSlateBrush*)(__OutBuffer);

			}
		}

		public static void SetBrushResourceToMaterial(ref FSlateBrush Brush, UMaterialInterface Material)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Brush?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Material?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetBrushResourceToMaterial, __InBuffer, __OutBuffer);

				Brush = *(FSlateBrush*)(__OutBuffer);

			}
		}

		public static void RestorePreviousWindowTitleBarState()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __RestorePreviousWindowTitleBarState);
			}
		}

		public static FEventReply ReleaseMouseCapture(ref FEventReply Reply)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Reply?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __ReleaseMouseCapture, __InBuffer, __OutBuffer, __ReturnBuffer);

				Reply = *(FEventReply*)(__OutBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		public static FEventReply ReleaseJoystickCapture(ref FEventReply Reply, bool bInAllJoysticks = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Reply?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bInAllJoysticks;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __ReleaseJoystickCapture, __InBuffer, __OutBuffer, __ReturnBuffer);

				Reply = *(FEventReply*)(__OutBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// A new slate brush that wont draw anything.
		/// </returns>
		public static FSlateBrush NoResourceBrush()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __NoResourceBrush, __ReturnBuffer);

				return *(FSlateBrush*)__ReturnBuffer;
			}
		}

		/// <param name="Width">
		/// When less than or equal to zero, the Width of the brush will default to the Width of the Texture
		/// </param>
		/// <param name="Height">
		/// When less than or equal to zero, the Height of the brush will default to the Height of the Texture
		/// </param>
		/// <returns>
		/// A new slate brush using the texture.
		/// </returns>
		public static FSlateBrush MakeBrushFromTexture(UTexture2D Texture, int Width = 0, int Height = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Texture?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Width;

				*(int*)(__InBuffer + 12) = Height;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeBrushFromTexture, __InBuffer, __ReturnBuffer);

				return *(FSlateBrush*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// A new slate brush using the material.
		/// </returns>
		public static FSlateBrush MakeBrushFromMaterial(UMaterialInterface Material, int Width = 32, int Height = 32)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Width;

				*(int*)(__InBuffer + 12) = Height;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeBrushFromMaterial, __InBuffer, __ReturnBuffer);

				return *(FSlateBrush*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// A new slate brush using the asset's brush.
		/// </returns>
		public static FSlateBrush MakeBrushFromAsset(USlateBrushAsset BrushAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BrushAsset?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeBrushFromAsset, __InBuffer, __ReturnBuffer);

				return *(FSlateBrush*)__ReturnBuffer;
			}
		}

		public static FEventReply LockMouse(ref FEventReply Reply, UWidget CapturingWidget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Reply?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CapturingWidget?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __LockMouse, __InBuffer, __OutBuffer, __ReturnBuffer);

				Reply = *(FEventReply*)(__OutBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		public static bool IsDragDropping()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __IsDragDropping, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FEventReply Handled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __Handled, __ReturnBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		public static void GetSafeZonePadding(UObject WorldContextObject, ref FVector4 SafePadding, ref FVector2D SafePaddingScale, ref FVector4 SpillOverPadding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SafePadding?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SafePaddingScale?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = SpillOverPadding?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[24];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetSafeZonePadding, __InBuffer, __OutBuffer);

				SafePadding = *(FVector4*)(__OutBuffer);

				SafePaddingScale = *(FVector2D*)(__OutBuffer + 8);

				SpillOverPadding = *(FVector4*)(__OutBuffer + 16);

			}
		}

		public static FKeyEvent GetKeyEventFromAnalogInputEvent(FAnalogInputEvent Event)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Event?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetKeyEventFromAnalogInputEvent, __InBuffer, __ReturnBuffer);

				return *(FKeyEvent*)__ReturnBuffer;
			}
		}

		public static FInputEvent GetInputEventFromPointerEvent(FPointerEvent Event)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Event?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetInputEventFromPointerEvent, __InBuffer, __ReturnBuffer);

				return *(FInputEvent*)__ReturnBuffer;
			}
		}

		public static FInputEvent GetInputEventFromNavigationEvent(FNavigationEvent Event)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Event?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetInputEventFromNavigationEvent, __InBuffer, __ReturnBuffer);

				return *(FInputEvent*)__ReturnBuffer;
			}
		}

		public static FInputEvent GetInputEventFromKeyEvent(FKeyEvent Event)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Event?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetInputEventFromKeyEvent, __InBuffer, __ReturnBuffer);

				return *(FInputEvent*)__ReturnBuffer;
			}
		}

		public static FInputEvent GetInputEventFromCharacterEvent(FCharacterEvent Event)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Event?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetInputEventFromCharacterEvent, __InBuffer, __ReturnBuffer);

				return *(FInputEvent*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// A material that supports dynamic input from the game.
		/// </returns>
		public static UMaterialInstanceDynamic GetDynamicMaterial(ref FSlateBrush Brush)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Brush?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __GetDynamicMaterial, __InBuffer, __OutBuffer, __ReturnBuffer);

				Brush = *(FSlateBrush*)(__OutBuffer);

				return *(UMaterialInstanceDynamic*)__ReturnBuffer;
			}
		}

		public static UDragDropOperation GetDragDroppingContent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetDragDroppingContent, __ReturnBuffer);

				return *(UDragDropOperation*)__ReturnBuffer;
			}
		}

		public static UTexture2D GetBrushResourceAsTexture2D(FSlateBrush Brush)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Brush?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetBrushResourceAsTexture2D, __InBuffer, __ReturnBuffer);

				return *(UTexture2D*)__ReturnBuffer;
			}
		}

		public static UMaterialInterface GetBrushResourceAsMaterial(FSlateBrush Brush)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Brush?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetBrushResourceAsMaterial, __InBuffer, __ReturnBuffer);

				return *(UMaterialInterface*)__ReturnBuffer;
			}
		}

		public static UObject GetBrushResource(FSlateBrush Brush)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Brush?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetBrushResource, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		/// <param name="Interface">
		/// The interface to find. Must be specified or result array will be empty.
		/// </param>
		/// <param name="FoundWidgets">
		/// Output array of widgets that implement the specified interface.
		/// </param>
		/// <param name="TopLevelOnly">
		/// Only the widgets that are direct children of the viewport will be returned.
		/// </param>
		public static void GetAllWidgetsWithInterface(UObject WorldContextObject, ref TArray<UUserWidget> FoundWidgets, TSubclassOf<UInterface> Interface, bool TopLevelOnly)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FoundWidgets?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Interface?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = TopLevelOnly;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAllWidgetsWithInterface, __InBuffer, __OutBuffer);

				FoundWidgets = *(TArray<UUserWidget>*)(__OutBuffer);

			}
		}

		/// <param name="FoundWidgets">
		/// The widgets that were found matching the filter.
		/// </param>
		/// <param name="WidgetClass">
		/// The widget class to filter by.
		/// </param>
		/// <param name="TopLevelOnly">
		/// Only the widgets that are direct children of the viewport will be returned.
		/// </param>
		public static void GetAllWidgetsOfClass(UObject WorldContextObject, ref TArray<UUserWidget> FoundWidgets, TSubclassOf<UUserWidget> WidgetClass, bool TopLevelOnly)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FoundWidgets?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = WidgetClass?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = TopLevelOnly;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAllWidgetsOfClass, __InBuffer, __OutBuffer);

				FoundWidgets = *(TArray<UUserWidget>*)(__OutBuffer);

			}
		}

		public static FEventReply EndDragDrop(ref FEventReply Reply)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Reply?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __EndDragDrop, __InBuffer, __OutBuffer, __ReturnBuffer);

				Reply = *(FEventReply*)(__OutBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		/// <param name="Text">
		/// The string to draw.
		/// </param>
		/// <param name="Position">
		/// The starting position where the text is drawn in local space.
		/// </param>
		/// <param name="Tint">
		/// Color to render the line.
		/// </param>
		public static void DrawTextFormatted(ref FPaintContext Context, FText Text, FVector2D Position, UFont Font, float FontSize = 16.000000f, FName FontTypeFace = null, FLinearColor Tint = null)
		{
			unsafe
			{
				FontTypeFace ??= new FName("Regular");

				Tint ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[52];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Text?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Position?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Font?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 32) = FontSize;

				*(nint*)(__InBuffer + 36) = FontTypeFace?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 44) = Tint?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __DrawTextFormatted, __InBuffer, __OutBuffer);

				Context = *(FPaintContext*)(__OutBuffer);

			}
		}

		/// <param name="InString">
		/// The string to draw.
		/// </param>
		/// <param name="Position">
		/// The starting position where the text is drawn in local space.
		/// </param>
		/// <param name="Tint">
		/// Color to render the line.
		/// </param>
		public static void DrawText(ref FPaintContext Context, FString InString, FVector2D Position, FLinearColor Tint = null)
		{
			unsafe
			{
				Tint ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InString?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Position?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Tint?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __DrawText, __InBuffer, __OutBuffer);

				Context = *(FPaintContext*)(__OutBuffer);

			}
		}

		/// <param name="Start">
		/// Starting position of the spline in local space.
		/// </param>
		/// <param name="StartDir">
		/// The direction of the spline from the start point.
		/// </param>
		/// <param name="End">
		/// Ending position of the spline in local space.
		/// </param>
		/// <param name="EndDir">
		/// The direction of the spline to the end point.
		/// </param>
		/// <param name="Tint">
		/// Color to render the spline.
		/// </param>
		/// <param name="Thickness">
		/// How many pixels thick this spline should be.
		/// </param>
		public static void DrawSpline(ref FPaintContext Context, FVector2D Start, FVector2D StartDir, FVector2D End, FVector2D EndDir, FLinearColor Tint = null, float Thickness = 1.000000f)
		{
			unsafe
			{
				Tint ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[52];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = StartDir?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = EndDir?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = Tint?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 48) = Thickness;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __DrawSpline, __InBuffer, __OutBuffer);

				Context = *(FPaintContext*)(__OutBuffer);

			}
		}

		/// <param name="Points">
		/// Line pairs, each line needs to be 2 separate points in the array.
		/// </param>
		/// <param name="Tint">
		/// Color to render the line.
		/// </param>
		/// <param name="bAntialias">
		/// Whether the line should be antialiased.
		/// </param>
		/// <param name="Thickness">
		/// How many pixels thick this line should be.
		/// </param>
		public static void DrawLines(ref FPaintContext Context, TArray<FVector2D> Points, FLinearColor Tint = null, bool bAntiAlias = true, float Thickness = 1.000000f)
		{
			unsafe
			{
				Tint ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[29];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Points?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Tint?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bAntiAlias;

				*(float*)(__InBuffer + 25) = Thickness;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __DrawLines, __InBuffer, __OutBuffer);

				Context = *(FPaintContext*)(__OutBuffer);

			}
		}

		/// <param name="PositionA">
		/// Starting position of the line in local space.
		/// </param>
		/// <param name="PositionB">
		/// Ending position of the line in local space.
		/// </param>
		/// <param name="Tint">
		/// Color to render the line.
		/// </param>
		/// <param name="bAntialias">
		/// Whether the line should be antialiased.
		/// </param>
		/// <param name="Thickness">
		/// How many pixels thick this line should be.
		/// </param>
		public static void DrawLine(ref FPaintContext Context, FVector2D PositionA, FVector2D PositionB, FLinearColor Tint = null, bool bAntiAlias = true, float Thickness = 1.000000f)
		{
			unsafe
			{
				Tint ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[37];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PositionA?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = PositionB?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Tint?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bAntiAlias;

				*(float*)(__InBuffer + 33) = Thickness;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __DrawLine, __InBuffer, __OutBuffer);

				Context = *(FPaintContext*)(__OutBuffer);

			}
		}

		public static void DrawBox(ref FPaintContext Context, FVector2D Position, FVector2D Size, USlateBrushAsset Brush, FLinearColor Tint = null)
		{
			unsafe
			{
				Tint ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Position?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Size?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Brush?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Tint?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __DrawBox, __InBuffer, __OutBuffer);

				Context = *(FPaintContext*)(__OutBuffer);

			}
		}

		public static void DismissAllMenus()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __DismissAllMenus);
			}
		}

		/// <param name="PointerEvent">
		/// The pointer device event coming in.
		/// </param>
		/// <param name="WidgetDetectingDrag">
		/// Detect dragging in this widget.
		/// </param>
		/// <param name="DragKey">
		/// This button should be pressed to detect the drag, won't emit the DetectDrag FEventReply unless this is pressed.
		/// </param>
		public static FEventReply DetectDragIfPressed(FPointerEvent PointerEvent, UWidget WidgetDetectingDrag, FKey DragKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = PointerEvent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = WidgetDetectingDrag?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = DragKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __DetectDragIfPressed, __InBuffer, __ReturnBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		/// <param name="WidgetDetectingDrag">
		/// Detect dragging in this widget
		/// </param>
		/// <param name="DragKey">
		/// This button should be pressed to detect the drag
		/// </param>
		public static FEventReply DetectDrag(ref FEventReply Reply, UWidget WidgetDetectingDrag, FKey DragKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Reply?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = WidgetDetectingDrag?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = DragKey?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __DetectDrag, __InBuffer, __OutBuffer, __ReturnBuffer);

				Reply = *(FEventReply*)(__OutBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		public static UDragDropOperation CreateDragDropOperation(TSubclassOf<UDragDropOperation> OperationClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OperationClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateDragDropOperation, __InBuffer, __ReturnBuffer);

				return *(UDragDropOperation*)__ReturnBuffer;
			}
		}

		public static UUserWidget Create(UObject WorldContextObject, TSubclassOf<UUserWidget> WidgetType, APlayerController OwningPlayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = WidgetType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OwningPlayer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Create, __InBuffer, __ReturnBuffer);

				return *(UUserWidget*)__ReturnBuffer;
			}
		}

		public static FEventReply ClearUserFocus(ref FEventReply Reply, bool bInAllUsers = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Reply?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bInAllUsers;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __ClearUserFocus, __InBuffer, __OutBuffer, __ReturnBuffer);

				Reply = *(FEventReply*)(__OutBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		public static FEventReply CaptureMouse(ref FEventReply Reply, UWidget CapturingWidget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Reply?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CapturingWidget?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __CaptureMouse, __InBuffer, __OutBuffer, __ReturnBuffer);

				Reply = *(FEventReply*)(__OutBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		public static FEventReply CaptureJoystick(ref FEventReply Reply, UWidget CapturingWidget, bool bInAllJoysticks = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Reply?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CapturingWidget?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bInAllJoysticks;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __CaptureJoystick, __InBuffer, __OutBuffer, __ReturnBuffer);

				Reply = *(FEventReply*)(__OutBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		public static void CancelDragDrop()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __CancelDragDrop);
			}
		}

		private static uint __UnlockMouse = 0;

		private static uint __Unhandled = 0;

		private static uint __SetWindowTitleBarState = 0;

		private static uint __SetWindowTitleBarOnCloseClickedDelegate = 0;

		private static uint __SetWindowTitleBarCloseButtonActive = 0;

		private static uint __SetUserFocus = 0;

		private static uint __SetMousePosition = 0;

		private static uint __SetInputMode_UIOnlyEx = 0;

		private static uint __SetInputMode_GameOnly = 0;

		private static uint __SetInputMode_GameAndUIEx = 0;

		private static uint __SetHardwareCursor = 0;

		private static uint __SetFocusToGameViewport = 0;

		private static uint __SetColorVisionDeficiencyType = 0;

		private static uint __SetBrushResourceToTexture = 0;

		private static uint __SetBrushResourceToMaterial = 0;

		private static uint __RestorePreviousWindowTitleBarState = 0;

		private static uint __ReleaseMouseCapture = 0;

		private static uint __ReleaseJoystickCapture = 0;

		private static uint __NoResourceBrush = 0;

		private static uint __MakeBrushFromTexture = 0;

		private static uint __MakeBrushFromMaterial = 0;

		private static uint __MakeBrushFromAsset = 0;

		private static uint __LockMouse = 0;

		private static uint __IsDragDropping = 0;

		private static uint __Handled = 0;

		private static uint __GetSafeZonePadding = 0;

		private static uint __GetKeyEventFromAnalogInputEvent = 0;

		private static uint __GetInputEventFromPointerEvent = 0;

		private static uint __GetInputEventFromNavigationEvent = 0;

		private static uint __GetInputEventFromKeyEvent = 0;

		private static uint __GetInputEventFromCharacterEvent = 0;

		private static uint __GetDynamicMaterial = 0;

		private static uint __GetDragDroppingContent = 0;

		private static uint __GetBrushResourceAsTexture2D = 0;

		private static uint __GetBrushResourceAsMaterial = 0;

		private static uint __GetBrushResource = 0;

		private static uint __GetAllWidgetsWithInterface = 0;

		private static uint __GetAllWidgetsOfClass = 0;

		private static uint __EndDragDrop = 0;

		private static uint __DrawTextFormatted = 0;

		private static uint __DrawText = 0;

		private static uint __DrawSpline = 0;

		private static uint __DrawLines = 0;

		private static uint __DrawLine = 0;

		private static uint __DrawBox = 0;

		private static uint __DismissAllMenus = 0;

		private static uint __DetectDragIfPressed = 0;

		private static uint __DetectDrag = 0;

		private static uint __CreateDragDropOperation = 0;

		private static uint __Create = 0;

		private static uint __ClearUserFocus = 0;

		private static uint __CaptureMouse = 0;

		private static uint __CaptureJoystick = 0;

		private static uint __CancelDragDrop = 0;
	}
}