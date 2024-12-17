using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.EnhancedInputLibrary")]
	public partial class UEnhancedInputLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnhancedInput.EnhancedInputLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Context">
		/// Mappings will be rebuilt for all subsystems utilizing this context.
		/// </param>
		/// <param name="bForceImmediately">
		/// The mapping changes will be applied synchronously, rather than at the end of the frame, making them available to the input system on the same frame.
		/// </param>
		public static void RequestRebuildControlMappingsUsingContext(UInputMappingContext Context, bool bForceImmediately = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bForceImmediately;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RequestRebuildControlMappingsUsingContext, __InBuffer);
			}
		}

		/// <note>
		/// Intended for use in Input Modifier Modify Raw overloads to modify an existing Input Action Value.
		/// </note>
		public static FInputActionValue MakeInputActionValueOfType(double X, double Y, double Z, EInputActionValueType ValueType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(double*)(__InBuffer) = X;

				*(double*)(__InBuffer + 8) = Y;

				*(double*)(__InBuffer + 16) = Z;

				*(byte*)(__InBuffer + 24) = (byte)ValueType;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeInputActionValueOfType, __InBuffer, __ReturnBuffer);

				return *(FInputActionValue*)__ReturnBuffer;
			}
		}

		public static FInputActionValue MakeInputActionValue(double X, double Y, double Z, FInputActionValue MatchValueType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(double*)(__InBuffer) = X;

				*(double*)(__InBuffer + 8) = Y;

				*(double*)(__InBuffer + 16) = Z;

				*(nint*)(__InBuffer + 24) = MatchValueType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeInputActionValue, __InBuffer, __ReturnBuffer);

				return *(FInputActionValue*)__ReturnBuffer;
			}
		}

		public static bool IsActionKeyMappingPlayerMappable(FEnhancedActionKeyMapping ActionKeyMapping)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ActionKeyMapping?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsActionKeyMappingPlayerMappable, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FPlayerMappableKeySlot GetThirdPlayerMappableKeySlot()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetThirdPlayerMappableKeySlot, __ReturnBuffer);

				return *(FPlayerMappableKeySlot*)__ReturnBuffer;
			}
		}

		public static FPlayerMappableKeySlot GetSecondPlayerMappableKeySlot()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetSecondPlayerMappableKeySlot, __ReturnBuffer);

				return *(FPlayerMappableKeySlot*)__ReturnBuffer;
			}
		}

		public static UPlayerMappableKeySettings GetPlayerMappableKeySettings(FEnhancedActionKeyMapping ActionKeyMapping)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ActionKeyMapping?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPlayerMappableKeySettings, __InBuffer, __ReturnBuffer);

				return *(UPlayerMappableKeySettings*)__ReturnBuffer;
			}
		}

		public static FName GetMappingName(FEnhancedActionKeyMapping ActionKeyMapping)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ActionKeyMapping?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMappingName, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public static FPlayerMappableKeySlot GetFourthPlayerMappableKeySlot()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetFourthPlayerMappableKeySlot, __ReturnBuffer);

				return *(FPlayerMappableKeySlot*)__ReturnBuffer;
			}
		}

		public static FPlayerMappableKeySlot GetFirstPlayerMappableKeySlot()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetFirstPlayerMappableKeySlot, __ReturnBuffer);

				return *(FPlayerMappableKeySlot*)__ReturnBuffer;
			}
		}

		public static FInputActionValue GetBoundActionValue(AActor Actor, UInputAction Action)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Action?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetBoundActionValue, __InBuffer, __ReturnBuffer);

				return *(FInputActionValue*)__ReturnBuffer;
			}
		}

		public static FString Conv_InputActionValueToString(FInputActionValue ActionValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ActionValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_InputActionValueToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static bool Conv_InputActionValueToBool(FInputActionValue InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_InputActionValueToBool, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FVector Conv_InputActionValueToAxis3D(FInputActionValue ActionValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ActionValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_InputActionValueToAxis3D, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector2D Conv_InputActionValueToAxis2D(FInputActionValue InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_InputActionValueToAxis2D, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static double Conv_InputActionValueToAxis1D(FInputActionValue InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_InputActionValueToAxis1D, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static void BreakInputActionValue(FInputActionValue InActionValue, ref double X, ref double Y, ref double Z, ref EInputActionValueType Type)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = InActionValue?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = X;

				*(double*)(__InBuffer + 16) = Y;

				*(double*)(__InBuffer + 24) = Z;

				*(byte*)(__InBuffer + 32) = (byte)Type;

				var __OutBuffer = stackalloc byte[25];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakInputActionValue, __InBuffer, __OutBuffer);

				X = *(double*)(__OutBuffer);

				Y = *(double*)(__OutBuffer + 8);

				Z = *(double*)(__OutBuffer + 16);

				Type = *(EInputActionValueType*)(__OutBuffer + 24);

			}
		}

		private static uint __RequestRebuildControlMappingsUsingContext = 0;

		private static uint __MakeInputActionValueOfType = 0;

		private static uint __MakeInputActionValue = 0;

		private static uint __IsActionKeyMappingPlayerMappable = 0;

		private static uint __GetThirdPlayerMappableKeySlot = 0;

		private static uint __GetSecondPlayerMappableKeySlot = 0;

		private static uint __GetPlayerMappableKeySettings = 0;

		private static uint __GetMappingName = 0;

		private static uint __GetFourthPlayerMappableKeySlot = 0;

		private static uint __GetFirstPlayerMappableKeySlot = 0;

		private static uint __GetBoundActionValue = 0;

		private static uint __Conv_InputActionValueToString = 0;

		private static uint __Conv_InputActionValueToBool = 0;

		private static uint __Conv_InputActionValueToAxis3D = 0;

		private static uint __Conv_InputActionValueToAxis2D = 0;

		private static uint __Conv_InputActionValueToAxis1D = 0;

		private static uint __BreakInputActionValue = 0;
	}
}