using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.KismetTextLibrary")]
	public partial class UKismetTextLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.KismetTextLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FText TextTrimTrailing(FText InText)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InText?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __TextTrimTrailing, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static FText TextTrimPrecedingAndTrailing(FText InText)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InText?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __TextTrimPrecedingAndTrailing, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static FText TextTrimPreceding(FText InText)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InText?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __TextTrimPreceding, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		/// <note>
		/// The returned instance is linked to the original and will be rebuilt if the active culture is changed.
		/// </note>
		public static FText TextToUpper(FText InText)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InText?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __TextToUpper, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		/// <note>
		/// The returned instance is linked to the original and will be rebuilt if the active culture is changed.
		/// </note>
		public static FText TextToLower(FText InText)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InText?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __TextToLower, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static bool TextIsTransient(FText InText)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InText?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __TextIsTransient, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool TextIsFromStringTable(FText Text)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Text?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __TextIsFromStringTable, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool TextIsEmpty(FText InText)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InText?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __TextIsEmpty, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool TextIsCultureInvariant(FText InText)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InText?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __TextIsCultureInvariant, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// This exists to allow programmatic look-up of a string table entry from dynamic content - you should favor setting your string table reference on a text property or pin wherever possible as it is significantly more robust (see "Make Literal Text").
		/// </note>
		/// <returns>
		/// The found text, or a dummy text if the entry could not be found.
		/// </returns>
		public static FText TextFromStringTable(FName TableId, FString Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TableId?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __TextFromStringTable, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// True if the String Table ID and key were found, false otherwise.
		/// </returns>
		public static bool StringTableIdAndKeyFromText(FText Text, ref FName OutTableId, ref FString OutKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Text?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutTableId?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutKey?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __StringTableIdAndKeyFromText, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutTableId = *(FName*)(__OutBuffer);

				OutKey = *(FString*)(__OutBuffer + 8);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The text instance, or an empty text if the data is invalid.
		/// </returns>
		public static FText PolyglotDataToText(FPolyglotTextData PolyglotData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PolyglotData?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __PolyglotDataToText, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static bool NotEqual_TextText(FText A, FText B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_TextText, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NotEqual_IgnoreCase_TextText(FText A, FText B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_IgnoreCase_TextText, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// True if the polyglot data is valid, false otherwise. ErrorMessage will be filled in if the the data is invalid.
		/// </returns>
		public static void IsPolyglotDataValid(FPolyglotTextData PolyglotData, ref bool IsValid, ref FText ErrorMessage)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = PolyglotData?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = IsValid;

				*(nint*)(__InBuffer + 9) = ErrorMessage?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __IsPolyglotDataValid, __InBuffer, __OutBuffer);

				IsValid = *(bool*)(__OutBuffer);

				ErrorMessage = *(FText*)(__OutBuffer + 1);

			}
		}

		public static FText GetEmptyText()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetEmptyText, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static FText Format(FText InPattern, TArray<FFormatArgumentData> InArgs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InPattern?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InArgs?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Format, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		/// <param name="Namespace">
		/// The namespace of the text to find (if any).
		/// </param>
		/// <param name="Key">
		/// The key of the text to find.
		/// </param>
		/// <param name="SourceString">
		/// If set (not empty) then the found text must also have been created from this source string.
		/// </param>
		public static bool FindTextInLocalizationTable(FString Namespace, FString Key, ref FText OutText, FString SourceString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Namespace?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutText?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = SourceString?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __FindTextInLocalizationTable, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutText = *(FText*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EqualEqual_TextText(FText A, FText B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_TextText, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EqualEqual_IgnoreCase_TextText(FText A, FText B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_IgnoreCase_TextText, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FText Conv_VectorToText(FVector InVec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InVec?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_VectorToText, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static FText Conv_Vector2dToText(FVector2D InVec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InVec?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_Vector2dToText, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static FText Conv_TransformToText(FTransform InTrans)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InTrans?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_TransformToText, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static FString Conv_TextToString(FText InText)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InText?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_TextToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FText Conv_StringToText(FString InString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InString?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_StringToText, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static FText Conv_RotatorToText(FRotator InRot)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InRot?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_RotatorToText, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static FText Conv_ObjectToText(UObject InObj)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InObj?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_ObjectToText, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static FText Conv_NameToText(FName InName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_NameToText, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static FText Conv_IntToText(int Value, bool bAlwaysSign = false, bool bUseGrouping = true, int MinimumIntegralDigits = 1, int MaximumIntegralDigits = 324)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[14];

				*(int*)(__InBuffer) = Value;

				*(bool*)(__InBuffer + 4) = bAlwaysSign;

				*(bool*)(__InBuffer + 5) = bUseGrouping;

				*(int*)(__InBuffer + 6) = MinimumIntegralDigits;

				*(int*)(__InBuffer + 10) = MaximumIntegralDigits;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_IntToText, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static FText Conv_Int64ToText(long Value, bool bAlwaysSign = false, bool bUseGrouping = true, int MinimumIntegralDigits = 1, int MaximumIntegralDigits = 324)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(long*)(__InBuffer) = Value;

				*(bool*)(__InBuffer + 8) = bAlwaysSign;

				*(bool*)(__InBuffer + 9) = bUseGrouping;

				*(int*)(__InBuffer + 10) = MinimumIntegralDigits;

				*(int*)(__InBuffer + 14) = MaximumIntegralDigits;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_Int64ToText, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static FText Conv_DoubleToText(double Value, ERoundingMode RoundingMode, bool bAlwaysSign = false, bool bUseGrouping = true, int MinimumIntegralDigits = 1, int MaximumIntegralDigits = 324, int MinimumFractionalDigits = 0, int MaximumFractionalDigits = 3)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[27];

				*(double*)(__InBuffer) = Value;

				*(byte*)(__InBuffer + 8) = (byte)RoundingMode;

				*(bool*)(__InBuffer + 9) = bAlwaysSign;

				*(bool*)(__InBuffer + 10) = bUseGrouping;

				*(int*)(__InBuffer + 11) = MinimumIntegralDigits;

				*(int*)(__InBuffer + 15) = MaximumIntegralDigits;

				*(int*)(__InBuffer + 19) = MinimumFractionalDigits;

				*(int*)(__InBuffer + 23) = MaximumFractionalDigits;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_DoubleToText, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static FText Conv_ColorToText(FLinearColor InColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InColor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_ColorToText, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static FText Conv_ByteToText(byte Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = Value;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_ByteToText, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static FText Conv_BoolToText(bool InBool)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = InBool;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_BoolToText, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static FText AsTimeZoneTime_DateTime(FDateTime InDateTime, FString InTimeZone = null)
		{
			unsafe
			{
				InTimeZone ??= new FString("");

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InDateTime?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTimeZone?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AsTimeZoneTime_DateTime, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static FText AsTimeZoneDateTime_DateTime(FDateTime InDateTime, FString InTimeZone = null)
		{
			unsafe
			{
				InTimeZone ??= new FString("");

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InDateTime?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTimeZone?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AsTimeZoneDateTime_DateTime, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static FText AsTimeZoneDate_DateTime(FDateTime InDateTime, FString InTimeZone = null)
		{
			unsafe
			{
				InTimeZone ??= new FString("");

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InDateTime?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTimeZone?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AsTimeZoneDate_DateTime, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static FText AsTimespan_Timespan(FTimespan InTimespan)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InTimespan?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AsTimespan_Timespan, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static FText AsTime_DateTime(FDateTime In)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = In?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AsTime_DateTime, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static FText AsPercent_Float(float Value, ERoundingMode RoundingMode, bool bAlwaysSign = false, bool bUseGrouping = true, int MinimumIntegralDigits = 1, int MaximumIntegralDigits = 324, int MinimumFractionalDigits = 0, int MaximumFractionalDigits = 3)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[23];

				*(float*)(__InBuffer) = Value;

				*(byte*)(__InBuffer + 4) = (byte)RoundingMode;

				*(bool*)(__InBuffer + 5) = bAlwaysSign;

				*(bool*)(__InBuffer + 6) = bUseGrouping;

				*(int*)(__InBuffer + 7) = MinimumIntegralDigits;

				*(int*)(__InBuffer + 11) = MaximumIntegralDigits;

				*(int*)(__InBuffer + 15) = MinimumFractionalDigits;

				*(int*)(__InBuffer + 19) = MaximumFractionalDigits;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AsPercent_Float, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static FText AsDateTime_DateTime(FDateTime In)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = In?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AsDateTime_DateTime, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static FText AsDate_DateTime(FDateTime InDateTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDateTime?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AsDate_DateTime, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static FText AsCurrencyBase(int BaseValue, FString CurrencyCode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = BaseValue;

				*(nint*)(__InBuffer + 4) = CurrencyCode?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AsCurrencyBase, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static FText AsCurrency_Integer(int Value, ERoundingMode RoundingMode, bool bAlwaysSign = false, bool bUseGrouping = true, int MinimumIntegralDigits = 1, int MaximumIntegralDigits = 324, int MinimumFractionalDigits = 0, int MaximumFractionalDigits = 3, FString CurrencyCode = null)
		{
			unsafe
			{
				CurrencyCode ??= new FString("");

				var __InBuffer = stackalloc byte[31];

				*(int*)(__InBuffer) = Value;

				*(byte*)(__InBuffer + 4) = (byte)RoundingMode;

				*(bool*)(__InBuffer + 5) = bAlwaysSign;

				*(bool*)(__InBuffer + 6) = bUseGrouping;

				*(int*)(__InBuffer + 7) = MinimumIntegralDigits;

				*(int*)(__InBuffer + 11) = MaximumIntegralDigits;

				*(int*)(__InBuffer + 15) = MinimumFractionalDigits;

				*(int*)(__InBuffer + 19) = MaximumFractionalDigits;

				*(nint*)(__InBuffer + 23) = CurrencyCode?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AsCurrency_Integer, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public static FText AsCurrency_Float(float Value, ERoundingMode RoundingMode, bool bAlwaysSign = false, bool bUseGrouping = true, int MinimumIntegralDigits = 1, int MaximumIntegralDigits = 324, int MinimumFractionalDigits = 0, int MaximumFractionalDigits = 3, FString CurrencyCode = null)
		{
			unsafe
			{
				CurrencyCode ??= new FString("");

				var __InBuffer = stackalloc byte[31];

				*(float*)(__InBuffer) = Value;

				*(byte*)(__InBuffer + 4) = (byte)RoundingMode;

				*(bool*)(__InBuffer + 5) = bAlwaysSign;

				*(bool*)(__InBuffer + 6) = bUseGrouping;

				*(int*)(__InBuffer + 7) = MinimumIntegralDigits;

				*(int*)(__InBuffer + 11) = MaximumIntegralDigits;

				*(int*)(__InBuffer + 15) = MinimumFractionalDigits;

				*(int*)(__InBuffer + 19) = MaximumFractionalDigits;

				*(nint*)(__InBuffer + 23) = CurrencyCode?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AsCurrency_Float, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		private static uint __TextTrimTrailing = 0;

		private static uint __TextTrimPrecedingAndTrailing = 0;

		private static uint __TextTrimPreceding = 0;

		private static uint __TextToUpper = 0;

		private static uint __TextToLower = 0;

		private static uint __TextIsTransient = 0;

		private static uint __TextIsFromStringTable = 0;

		private static uint __TextIsEmpty = 0;

		private static uint __TextIsCultureInvariant = 0;

		private static uint __TextFromStringTable = 0;

		private static uint __StringTableIdAndKeyFromText = 0;

		private static uint __PolyglotDataToText = 0;

		private static uint __NotEqual_TextText = 0;

		private static uint __NotEqual_IgnoreCase_TextText = 0;

		private static uint __IsPolyglotDataValid = 0;

		private static uint __GetEmptyText = 0;

		private static uint __Format = 0;

		private static uint __FindTextInLocalizationTable = 0;

		private static uint __EqualEqual_TextText = 0;

		private static uint __EqualEqual_IgnoreCase_TextText = 0;

		private static uint __Conv_VectorToText = 0;

		private static uint __Conv_Vector2dToText = 0;

		private static uint __Conv_TransformToText = 0;

		private static uint __Conv_TextToString = 0;

		private static uint __Conv_StringToText = 0;

		private static uint __Conv_RotatorToText = 0;

		private static uint __Conv_ObjectToText = 0;

		private static uint __Conv_NameToText = 0;

		private static uint __Conv_IntToText = 0;

		private static uint __Conv_Int64ToText = 0;

		private static uint __Conv_DoubleToText = 0;

		private static uint __Conv_ColorToText = 0;

		private static uint __Conv_ByteToText = 0;

		private static uint __Conv_BoolToText = 0;

		private static uint __AsTimeZoneTime_DateTime = 0;

		private static uint __AsTimeZoneDateTime_DateTime = 0;

		private static uint __AsTimeZoneDate_DateTime = 0;

		private static uint __AsTimespan_Timespan = 0;

		private static uint __AsTime_DateTime = 0;

		private static uint __AsPercent_Float = 0;

		private static uint __AsDateTime_DateTime = 0;

		private static uint __AsDate_DateTime = 0;

		private static uint __AsCurrencyBase = 0;

		private static uint __AsCurrency_Integer = 0;

		private static uint __AsCurrency_Float = 0;
	}
}