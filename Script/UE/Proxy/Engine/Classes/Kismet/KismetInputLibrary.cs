using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;
using Script.InputCore;
using Script.Slate;

namespace Script.Engine
{
	[PathName("/Script/Engine.KismetInputLibrary")]
	public partial class UKismetInputLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.KismetInputLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static bool PointerEvent_IsTouchEvent(FPointerEvent Input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __PointerEvent_IsTouchEvent, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool PointerEvent_IsMouseButtonDown(FPointerEvent Input, FKey MouseButton)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MouseButton?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __PointerEvent_IsMouseButtonDown, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static float PointerEvent_GetWheelDelta(FPointerEvent Input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __PointerEvent_GetWheelDelta, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static int PointerEvent_GetUserIndex(FPointerEvent Input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __PointerEvent_GetUserIndex, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int PointerEvent_GetTouchpadIndex(FPointerEvent Input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __PointerEvent_GetTouchpadIndex, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static FVector2D PointerEvent_GetScreenSpacePosition(FPointerEvent Input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __PointerEvent_GetScreenSpacePosition, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static int PointerEvent_GetPointerIndex(FPointerEvent Input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __PointerEvent_GetPointerIndex, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static FVector2D PointerEvent_GetLastScreenSpacePosition(FPointerEvent Input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __PointerEvent_GetLastScreenSpacePosition, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static ESlateGesture PointerEvent_GetGestureType(FPointerEvent Input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __PointerEvent_GetGestureType, __InBuffer, __ReturnBuffer);

				return *(ESlateGesture*)__ReturnBuffer;
			}
		}

		public static FVector2D PointerEvent_GetGestureDelta(FPointerEvent Input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __PointerEvent_GetGestureDelta, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static FKey PointerEvent_GetEffectingButton(FPointerEvent Input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __PointerEvent_GetEffectingButton, __InBuffer, __ReturnBuffer);

				return *(FKey*)__ReturnBuffer;
			}
		}

		public static FVector2D PointerEvent_GetCursorDelta(FPointerEvent Input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __PointerEvent_GetCursorDelta, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static bool ModifierKeysState_IsShiftDown(FSlateModifierKeysState KeysState)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = KeysState?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ModifierKeysState_IsShiftDown, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool ModifierKeysState_IsControlDown(FSlateModifierKeysState KeysState)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = KeysState?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ModifierKeysState_IsControlDown, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool ModifierKeysState_IsCommandDown(FSlateModifierKeysState KeysState)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = KeysState?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ModifierKeysState_IsCommandDown, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool ModifierKeysState_IsAltDown(FSlateModifierKeysState KeysState)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = KeysState?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ModifierKeysState_IsAltDown, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Deprecated. Use Is Axis 2D/3D instead.
		/// </note>
		public static bool Key_IsVectorAxis(FKey Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Key_IsVectorAxis, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool Key_IsValid(FKey Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Key_IsValid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool Key_IsMouseButton(FKey Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Key_IsMouseButton, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool Key_IsModifierKey(FKey Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Key_IsModifierKey, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool Key_IsKeyboardKey(FKey Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Key_IsKeyboardKey, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool Key_IsGamepadKey(FKey Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Key_IsGamepadKey, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool Key_IsDigital(FKey Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Key_IsDigital, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool Key_IsButtonAxis(FKey Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Key_IsButtonAxis, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool Key_IsAxis3D(FKey Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Key_IsAxis3D, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool Key_IsAxis2D(FKey Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Key_IsAxis2D, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool Key_IsAxis1D(FKey Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Key_IsAxis1D, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool Key_IsAnalog(FKey Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Key_IsAnalog, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static EUINavigation Key_GetNavigationDirectionFromKey(FKeyEvent InKeyEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InKeyEvent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Key_GetNavigationDirectionFromKey, __InBuffer, __ReturnBuffer);

				return *(EUINavigation*)__ReturnBuffer;
			}
		}

		public static EUINavigation Key_GetNavigationDirectionFromAnalog(FAnalogInputEvent InAnalogEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAnalogEvent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Key_GetNavigationDirectionFromAnalog, __InBuffer, __ReturnBuffer);

				return *(EUINavigation*)__ReturnBuffer;
			}
		}

		public static EUINavigationAction Key_GetNavigationActionFromKey(FKeyEvent InKeyEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InKeyEvent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Key_GetNavigationActionFromKey, __InBuffer, __ReturnBuffer);

				return *(EUINavigationAction*)__ReturnBuffer;
			}
		}

		public static EUINavigationAction Key_GetNavigationAction(FKey InKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Key_GetNavigationAction, __InBuffer, __ReturnBuffer);

				return *(EUINavigationAction*)__ReturnBuffer;
			}
		}

		public static FText Key_GetDisplayName(FKey Key, bool bLongDisplayName = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bLongDisplayName;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Key_GetDisplayName, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static bool InputEvent_IsShiftDown(FInputEvent Input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __InputEvent_IsShiftDown, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool InputEvent_IsRightShiftDown(FInputEvent Input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __InputEvent_IsRightShiftDown, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool InputEvent_IsRightControlDown(FInputEvent Input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __InputEvent_IsRightControlDown, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool InputEvent_IsRightCommandDown(FInputEvent Input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __InputEvent_IsRightCommandDown, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool InputEvent_IsRightAltDown(FInputEvent Input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __InputEvent_IsRightAltDown, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool InputEvent_IsRepeat(FInputEvent Input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __InputEvent_IsRepeat, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool InputEvent_IsLeftShiftDown(FInputEvent Input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __InputEvent_IsLeftShiftDown, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool InputEvent_IsLeftControlDown(FInputEvent Input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __InputEvent_IsLeftControlDown, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool InputEvent_IsLeftCommandDown(FInputEvent Input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __InputEvent_IsLeftCommandDown, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool InputEvent_IsLeftAltDown(FInputEvent Input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __InputEvent_IsLeftAltDown, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool InputEvent_IsControlDown(FInputEvent Input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __InputEvent_IsControlDown, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool InputEvent_IsCommandDown(FInputEvent Input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __InputEvent_IsCommandDown, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool InputEvent_IsAltDown(FInputEvent Input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __InputEvent_IsAltDown, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The display name of the input chord */
		/// </returns>
		public static FText InputChord_GetDisplayName(FInputChord Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __InputChord_GetDisplayName, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static int GetUserIndex(FKeyEvent Input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetUserIndex, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static FSlateModifierKeysState GetModifierKeysState()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetModifierKeysState, __ReturnBuffer);

				return *(FSlateModifierKeysState*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Key name
		/// </returns>
		public static FKey GetKey(FKeyEvent Input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetKey, __InBuffer, __ReturnBuffer);

				return *(FKey*)__ReturnBuffer;
			}
		}

		public static float GetAnalogValue(FAnalogInputEvent Input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetAnalogValue, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="A">
		/// - The key to compare against
		/// </param>
		/// <param name="B">
		/// - The key to compare
		/// Returns true if the key are equal, false otherwise
		/// </param>
		public static bool EqualEqual_KeyKey(FKey A, FKey B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_KeyKey, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="A">
		/// - The chord to compare against
		/// </param>
		/// <param name="B">
		/// - The chord to compare
		/// Returns true if the chords are equal, false otherwise
		/// </param>
		public static bool EqualEqual_InputChordInputChord(FInputChord A, FInputChord B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_InputChordInputChord, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void CalibrateTilt()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __CalibrateTilt);
			}
		}

		private static uint __PointerEvent_IsTouchEvent = 0;

		private static uint __PointerEvent_IsMouseButtonDown = 0;

		private static uint __PointerEvent_GetWheelDelta = 0;

		private static uint __PointerEvent_GetUserIndex = 0;

		private static uint __PointerEvent_GetTouchpadIndex = 0;

		private static uint __PointerEvent_GetScreenSpacePosition = 0;

		private static uint __PointerEvent_GetPointerIndex = 0;

		private static uint __PointerEvent_GetLastScreenSpacePosition = 0;

		private static uint __PointerEvent_GetGestureType = 0;

		private static uint __PointerEvent_GetGestureDelta = 0;

		private static uint __PointerEvent_GetEffectingButton = 0;

		private static uint __PointerEvent_GetCursorDelta = 0;

		private static uint __ModifierKeysState_IsShiftDown = 0;

		private static uint __ModifierKeysState_IsControlDown = 0;

		private static uint __ModifierKeysState_IsCommandDown = 0;

		private static uint __ModifierKeysState_IsAltDown = 0;

		private static uint __Key_IsVectorAxis = 0;

		private static uint __Key_IsValid = 0;

		private static uint __Key_IsMouseButton = 0;

		private static uint __Key_IsModifierKey = 0;

		private static uint __Key_IsKeyboardKey = 0;

		private static uint __Key_IsGamepadKey = 0;

		private static uint __Key_IsDigital = 0;

		private static uint __Key_IsButtonAxis = 0;

		private static uint __Key_IsAxis3D = 0;

		private static uint __Key_IsAxis2D = 0;

		private static uint __Key_IsAxis1D = 0;

		private static uint __Key_IsAnalog = 0;

		private static uint __Key_GetNavigationDirectionFromKey = 0;

		private static uint __Key_GetNavigationDirectionFromAnalog = 0;

		private static uint __Key_GetNavigationActionFromKey = 0;

		private static uint __Key_GetNavigationAction = 0;

		private static uint __Key_GetDisplayName = 0;

		private static uint __InputEvent_IsShiftDown = 0;

		private static uint __InputEvent_IsRightShiftDown = 0;

		private static uint __InputEvent_IsRightControlDown = 0;

		private static uint __InputEvent_IsRightCommandDown = 0;

		private static uint __InputEvent_IsRightAltDown = 0;

		private static uint __InputEvent_IsRepeat = 0;

		private static uint __InputEvent_IsLeftShiftDown = 0;

		private static uint __InputEvent_IsLeftControlDown = 0;

		private static uint __InputEvent_IsLeftCommandDown = 0;

		private static uint __InputEvent_IsLeftAltDown = 0;

		private static uint __InputEvent_IsControlDown = 0;

		private static uint __InputEvent_IsCommandDown = 0;

		private static uint __InputEvent_IsAltDown = 0;

		private static uint __InputChord_GetDisplayName = 0;

		private static uint __GetUserIndex = 0;

		private static uint __GetModifierKeysState = 0;

		private static uint __GetKey = 0;

		private static uint __GetAnalogValue = 0;

		private static uint __EqualEqual_KeyKey = 0;

		private static uint __EqualEqual_InputChordInputChord = 0;

		private static uint __CalibrateTilt = 0;
	}
}