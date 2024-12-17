using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.KismetStringLibrary")]
	public partial class UKismetStringLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.KismetStringLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FString TrimTrailing(FString SourceString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SourceString?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __TrimTrailing, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString Trim(FString SourceString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SourceString?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Trim, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="SourceString">
		/// The string to convert
		/// </param>
		/// <returns>
		/// The string in upper case
		/// </returns>
		public static FString ToUpper(FString SourceString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SourceString?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ToUpper, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="SourceString">
		/// The string to convert
		/// </param>
		/// <returns>
		/// The string in lower case
		/// </returns>
		public static FString ToLower(FString SourceString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SourceString?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ToLower, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// A new string built from the seconds parameter
		/// </returns>
		public static FString TimeSecondsToString(float InSeconds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InSeconds;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __TimeSecondsToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="SearchCase">
		/// Indicates whether the search is case sensitive or not ( defaults to ESearchCase::IgnoreCase )
		/// </param>
		/// <returns>
		/// true if this string begins with specified text, false otherwise
		/// </returns>
		public static bool StartsWith(FString SourceString, FString InPrefix, ESearchCase SearchCase = ESearchCase.IgnoreCase)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = SourceString?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InPrefix?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)SearchCase;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __StartsWith, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InStr">
		/// The string to search and split at
		/// </param>
		/// <param name="LeftS">
		/// out the string to the left of InStr, not updated if return is false
		/// </param>
		/// <param name="RightS">
		/// out the string to the right of InStr, not updated if return is false
		/// </param>
		/// <param name="SearchCase">
		/// Indicates whether the search is case sensitive or not ( defaults to ESearchCase::IgnoreCase )
		/// </param>
		/// <param name="SearchDir">
		/// Indicates whether the search starts at the begining or at the end ( defaults to ESearchDir::FromStart )
		/// </param>
		/// <returns>
		/// true if string is split, otherwise false
		/// </returns>
		public static bool Split(FString SourceString, FString InStr, ref FString LeftS, ref FString RightS, ESearchCase SearchCase, ESearchDir SearchDir)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[34];

				*(nint*)(__InBuffer) = SourceString?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InStr?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = LeftS?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = RightS?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)SearchCase;

				*(byte*)(__InBuffer + 33) = (byte)SearchDir;

				var __OutBuffer = stackalloc byte[16];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __Split, __InBuffer, __OutBuffer, __ReturnBuffer);

				LeftS = *(FString*)(__OutBuffer);

				RightS = *(FString*)(__OutBuffer + 8);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="SourceString">
		/// The string to pad
		/// </param>
		/// <param name="ChCount">
		/// Amount of padding required
		/// </param>
		/// <returns>
		/// The padded string
		/// </returns>
		public static FString RightPad(FString SourceString, int ChCount)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = SourceString?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = ChCount;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RightPad, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString RightChop(FString SourceString, int Count)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = SourceString?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Count;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RightChop, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString Right(FString SourceString, int Count)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = SourceString?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Count;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Right, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString Reverse(FString SourceString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SourceString?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Reverse, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="SearchText">
		/// the text that should be removed from this string
		/// </param>
		/// <param name="ReplacementText">
		/// the text to insert in its place
		/// </param>
		/// <param name="SearchCase">
		/// Indicates whether the search is case sensitive or not ( defaults to ESearchCase::IgnoreCase )
		/// </param>
		/// <returns>
		/// the number of occurrences of SearchText that were replaced.
		/// </returns>
		public static int ReplaceInline(ref FString SourceString, FString SearchText, FString ReplacementText, ESearchCase SearchCase = ESearchCase.IgnoreCase)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = SourceString?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SearchText?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ReplacementText?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)SearchCase;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __ReplaceInline, __InBuffer, __OutBuffer, __ReturnBuffer);

				SourceString = *(FString*)(__OutBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="From">
		/// substring to replace
		/// </param>
		/// <param name="To">
		/// substring to replace From with
		/// </param>
		/// <param name="SearchCase">
		/// Indicates whether the search is case sensitive or not ( defaults to ESearchCase::IgnoreCase )
		/// </param>
		/// <returns>
		/// a copy of this string with the replacement made
		/// </returns>
		public static FString Replace(FString SourceString, FString From, FString To, ESearchCase SearchCase = ESearchCase.IgnoreCase)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = SourceString?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = From?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = To?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)SearchCase;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Replace, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="SourceString">
		/// - The string to chop up
		/// </param>
		/// <param name="Delimiter">
		/// - The string to delimit on
		/// </param>
		/// <param name="CullEmptyStrings">
		/// = true - Cull (true) empty strings or add them to the array (false)
		/// </param>
		/// <returns>
		/// The array of string that have been separated
		/// </returns>
		public static TArray<FString> ParseIntoArray(FString SourceString, FString Delimiter = null, bool CullEmptyStrings = true)
		{
			unsafe
			{
				Delimiter ??= new FString(" ");

				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = SourceString?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Delimiter?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = CullEmptyStrings;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ParseIntoArray, __InBuffer, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		/// <param name="A">
		/// - The string to compare against
		/// </param>
		/// <param name="B">
		/// - The string to compare
		/// </param>
		/// <returns>
		/// Returns true if the input strings are not equal, false if they are equal
		/// </returns>
		public static bool NotEqual_StrStr(FString A, FString B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_StrStr, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="A">
		/// - The string to compare against
		/// </param>
		/// <param name="B">
		/// - The string to compare
		/// </param>
		/// <returns>
		/// Returns true if the input strings are not equal, false if they are equal
		/// </returns>
		public static bool NotEqual_StriStri(FString A, FString B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_StriStri, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FString Mid(FString SourceString, int Start, int Count)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SourceString?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Start;

				*(int*)(__InBuffer + 12) = Count;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Mid, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="Wildcard">
		/// ?-type wildcard
		/// </param>
		/// <param name="SearchCase">
		/// Indicates whether the search is case sensitive or not ( defaults to ESearchCase::IgnoreCase )
		/// </param>
		/// <warning>
		/// This is a simple, SLOW routine. Use with caution
		/// </warning>
		/// <returns>
		/// true if this string matches the *?-type wildcard given.
		/// </returns>
		public static bool MatchesWildcard(FString SourceString, FString Wildcard, ESearchCase SearchCase = ESearchCase.IgnoreCase)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = SourceString?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Wildcard?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)SearchCase;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __MatchesWildcard, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="SourceString">
		/// - The string to measure
		/// </param>
		/// <returns>
		/// The number of chars in the string
		/// </returns>
		public static int Len(FString S)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = S?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Len, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="SourceString">
		/// The string to pad
		/// </param>
		/// <param name="ChCount">
		/// Amount of padding required
		/// </param>
		/// <returns>
		/// The padded string
		/// </returns>
		public static FString LeftPad(FString SourceString, int ChCount)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = SourceString?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = ChCount;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __LeftPad, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString LeftChop(FString SourceString, int Count)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = SourceString?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Count;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __LeftChop, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString Left(FString SourceString, int Count)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = SourceString?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Count;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Left, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="SourceArray">
		/// - The array of strings to concatenate.
		/// </param>
		/// <param name="Separator">
		/// - The string used to separate each element.
		/// </param>
		/// <returns>
		/// The final, joined, separated string.
		/// </returns>
		public static FString JoinStringArray(TArray<FString> SourceArray, FString Separator = null)
		{
			unsafe
			{
				Separator ??= new FString(" ");

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SourceArray?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Separator?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __JoinStringArray, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="SourceString">
		/// The string to check
		/// </param>
		/// <returns>
		/// true if the string only contains numeric characters 
		/// </returns>
		public static bool IsNumeric(FString SourceString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SourceString?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsNumeric, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InString">
		/// - The string to check
		/// </param>
		/// <returns>
		/// Whether or not the string is empty
		/// </returns>
		public static bool IsEmpty(FString InString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InString?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsEmpty, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="SourceString">
		/// - The string to get the substring from
		/// </param>
		/// <param name="StartIndex">
		/// - The location in SourceString to use as the start of the substring
		/// </param>
		/// <param name="Length">
		/// The length of the requested substring
		/// </param>
		/// <returns>
		/// The requested substring
		/// </returns>
		public static FString GetSubstring(FString SourceString, int StartIndex = 0, int Length = 1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SourceString?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = StartIndex;

				*(int*)(__InBuffer + 12) = Length;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetSubstring, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="SourceString">
		/// - The string to convert
		/// </param>
		/// <param name="Index">
		/// - Location of the character whose value is required
		/// </param>
		/// <returns>
		/// The integer value of the character or 0 if index is out of range
		/// </returns>
		public static int GetCharacterAsNumber(FString SourceString, int Index = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = SourceString?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Index;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetCharacterAsNumber, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="SourceString">
		/// The string to break apart into characters
		/// </param>
		/// <returns>
		/// An array containing one entry for each character in SourceString
		/// </returns>
		public static TArray<FString> GetCharacterArrayFromString(FString SourceString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SourceString?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetCharacterArrayFromString, __InBuffer, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		/// <param name="SearchIn">
		/// The string to search within
		/// </param>
		/// <param name="Substring">
		/// The string to look for in the SearchIn string
		/// </param>
		/// <param name="bUseCase">
		/// Whether or not to be case-sensitive
		/// </param>
		/// <param name="bSearchFromEnd">
		/// Whether or not to start the search from the end of the string instead of the beginning
		/// </param>
		/// <param name="StartPosition">
		/// The position to start the search from
		/// </param>
		/// <returns>
		/// The index (starting from 0 if bSearchFromEnd is false) of the first occurence of the substring
		/// </returns>
		public static int FindSubstring(FString SearchIn, FString Substring, bool bUseCase = false, bool bSearchFromEnd = false, int StartPosition = -1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[22];

				*(nint*)(__InBuffer) = SearchIn?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Substring?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bUseCase;

				*(bool*)(__InBuffer + 17) = bSearchFromEnd;

				*(int*)(__InBuffer + 18) = StartPosition;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __FindSubstring, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="A">
		/// - The string to compare against
		/// </param>
		/// <param name="B">
		/// - The string to compare
		/// </param>
		/// <returns>
		/// True if the strings are equal, false otherwise
		/// </returns>
		public static bool EqualEqual_StrStr(FString A, FString B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_StrStr, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="A">
		/// - The string to compare against
		/// </param>
		/// <param name="B">
		/// - The string to compare
		/// </param>
		/// <returns>
		/// True if the strings are equal, false otherwise
		/// </returns>
		public static bool EqualEqual_StriStri(FString A, FString B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_StriStri, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="SearchCase">
		/// Indicates whether the search is case sensitive or not ( defaults to ESearchCase::IgnoreCase )
		/// </param>
		/// <returns>
		/// true if this string ends with specified text, false otherwise
		/// </returns>
		public static bool EndsWith(FString SourceString, FString InSuffix, ESearchCase SearchCase = ESearchCase.IgnoreCase)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = SourceString?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSuffix?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)SearchCase;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EndsWith, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InArray">
		/// The array to cull
		/// </param>
		/// <returns>
		/// The number of elements left in InArray
		/// </returns>
		public static int CullArray(FString SourceString, ref TArray<FString> InArray)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SourceString?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InArray?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __CullArray, __InBuffer, __OutBuffer, __ReturnBuffer);

				InArray = *(TArray<FString>*)(__OutBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static FString Conv_VectorToString(FVector InVec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InVec?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_VectorToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString Conv_Vector3fToString(FVector3f InVec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InVec?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_Vector3fToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString Conv_Vector2dToString(FVector2D InVec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InVec?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_Vector2dToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString Conv_TransformToString(FTransform InTrans)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InTrans?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_TransformToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static void Conv_StringToVector3f(FString InString, ref FVector3f OutConvertedVector, ref bool OutIsValid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InString?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutConvertedVector?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = OutIsValid;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Conv_StringToVector3f, __InBuffer, __OutBuffer);

				OutConvertedVector = *(FVector3f*)(__OutBuffer);

				OutIsValid = *(bool*)(__OutBuffer + 8);

			}
		}

		public static void Conv_StringToVector2D(FString InString, ref FVector2D OutConvertedVector2D, ref bool OutIsValid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InString?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutConvertedVector2D?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = OutIsValid;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Conv_StringToVector2D, __InBuffer, __OutBuffer);

				OutConvertedVector2D = *(FVector2D*)(__OutBuffer);

				OutIsValid = *(bool*)(__OutBuffer + 8);

			}
		}

		public static void Conv_StringToVector(FString InString, ref FVector OutConvertedVector, ref bool OutIsValid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InString?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutConvertedVector?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = OutIsValid;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Conv_StringToVector, __InBuffer, __OutBuffer);

				OutConvertedVector = *(FVector*)(__OutBuffer);

				OutIsValid = *(bool*)(__OutBuffer + 8);

			}
		}

		public static void Conv_StringToRotator(FString InString, ref FRotator OutConvertedRotator, ref bool OutIsValid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InString?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutConvertedRotator?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = OutIsValid;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Conv_StringToRotator, __InBuffer, __OutBuffer);

				OutConvertedRotator = *(FRotator*)(__OutBuffer);

				OutIsValid = *(bool*)(__OutBuffer + 8);

			}
		}

		public static FName Conv_StringToName(FString InString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InString?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_StringToName, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public static long Conv_StringToInt64(FString InString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InString?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_StringToInt64, __InBuffer, __ReturnBuffer);

				return *(long*)__ReturnBuffer;
			}
		}

		public static int Conv_StringToInt(FString InString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InString?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_StringToInt, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static double Conv_StringToDouble(FString InString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InString?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_StringToDouble, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static void Conv_StringToColor(FString InString, ref FLinearColor OutConvertedColor, ref bool OutIsValid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InString?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutConvertedColor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = OutIsValid;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Conv_StringToColor, __InBuffer, __OutBuffer);

				OutConvertedColor = *(FLinearColor*)(__OutBuffer);

				OutIsValid = *(bool*)(__OutBuffer + 8);

			}
		}

		public static FString Conv_RotatorToString(FRotator InRot)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InRot?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_RotatorToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString Conv_PlatformUserIdToString(FPlatformUserId InPlatformUserId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPlatformUserId?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_PlatformUserIdToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString Conv_ObjectToString(UObject InObj)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InObj?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_ObjectToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString Conv_NameToString(FName InName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_NameToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString Conv_MatrixToString(FMatrix InMatrix)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InMatrix?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_MatrixToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString Conv_IntVectorToString(FIntVector InIntVec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InIntVec?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_IntVectorToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString Conv_IntToString(int InInt)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InInt;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_IntToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString Conv_IntPointToString(FIntPoint InIntPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InIntPoint?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_IntPointToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString Conv_Int64ToString(long InInt)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(long*)(__InBuffer) = InInt;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_Int64ToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString Conv_InputDeviceIdToString(FInputDeviceId InDeviceId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDeviceId?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_InputDeviceIdToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString Conv_DoubleToString(double InDouble)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = InDouble;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_DoubleToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString Conv_ColorToString(FLinearColor InColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InColor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_ColorToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString Conv_ByteToString(byte InByte)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = InByte;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_ByteToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString Conv_BoolToString(bool InBool)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = InBool;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_BoolToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="SubStr">
		/// Find to search for
		/// </param>
		/// <param name="SearchCase">
		/// Indicates whether the search is case sensitive or not ( defaults to ESearchCase::IgnoreCase )
		/// </param>
		/// <param name="SearchDir">
		/// Indicates whether the search starts at the begining or at the end ( defaults to ESearchDir::FromStart )
		/// </param>
		/// <returns>
		/// Returns whether the string contains the substring
		/// </returns>
		public static bool Contains(FString SearchIn, FString Substring, bool bUseCase = false, bool bSearchFromEnd = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = SearchIn?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Substring?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bUseCase;

				*(bool*)(__InBuffer + 17) = bSearchFromEnd;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Contains, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="A">
		/// - The original string
		/// </param>
		/// <param name="B">
		/// - The string to append to A
		/// </param>
		/// <returns>
		/// A new string which is the concatenation of A+B
		/// </returns>
		public static FString Concat_StrStr(FString A, FString B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Concat_StrStr, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="AppendTo">
		/// - An existing string to use as the start of the conversion string
		/// </param>
		/// <param name="Prefix">
		/// - A string to use as a prefix, after the AppendTo string
		/// </param>
		/// <param name="InVector2d">
		/// - The vector2d value to convert. Uses the standard FVector2D::ToString conversion
		/// </param>
		/// <param name="Suffix">
		/// - A suffix to append to the end of the conversion string
		/// </param>
		/// <returns>
		/// A new string built from the passed parameters
		/// </returns>
		public static FString BuildString_Vector2d(FString AppendTo, FString Prefix, FVector2D InVector2d, FString Suffix)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = AppendTo?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Prefix?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InVector2d?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Suffix?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __BuildString_Vector2d, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="AppendTo">
		/// - An existing string to use as the start of the conversion string
		/// </param>
		/// <param name="Prefix">
		/// - A string to use as a prefix, after the AppendTo string
		/// </param>
		/// <param name="InVector">
		/// - The vector value to convert. Uses the standard FVector::ToString conversion
		/// </param>
		/// <param name="Suffix">
		/// - A suffix to append to the end of the conversion string
		/// </param>
		/// <returns>
		/// A new string built from the passed parameters
		/// </returns>
		public static FString BuildString_Vector(FString AppendTo, FString Prefix, FVector InVector, FString Suffix)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = AppendTo?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Prefix?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InVector?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Suffix?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __BuildString_Vector, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="AppendTo">
		/// - An existing string to use as the start of the conversion string
		/// </param>
		/// <param name="Prefix">
		/// - A string to use as a prefix, after the AppendTo string
		/// </param>
		/// <param name="InRot">
		/// - The rotator value to convert. Uses the standard ToString conversion
		/// </param>
		/// <param name="Suffix">
		/// - A suffix to append to the end of the conversion string
		/// </param>
		/// <returns>
		/// A new string built from the passed parameters
		/// </returns>
		public static FString BuildString_Rotator(FString AppendTo, FString Prefix, FRotator InRot, FString Suffix)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = AppendTo?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Prefix?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InRot?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Suffix?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __BuildString_Rotator, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="AppendTo">
		/// - An existing string to use as the start of the conversion string
		/// </param>
		/// <param name="Prefix">
		/// - A string to use as a prefix, after the AppendTo string
		/// </param>
		/// <param name="InObj">
		/// - The object to convert. Will insert the name of the object into the conversion string
		/// </param>
		/// <param name="Suffix">
		/// - A suffix to append to the end of the conversion string
		/// </param>
		/// <returns>
		/// A new string built from the passed parameters
		/// </returns>
		public static FString BuildString_Object(FString AppendTo, FString Prefix, UObject InObj, FString Suffix)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = AppendTo?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Prefix?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InObj?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Suffix?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __BuildString_Object, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="AppendTo">
		/// - An existing string to use as the start of the conversion string
		/// </param>
		/// <param name="Prefix">
		/// - A string to use as a prefix, after the AppendTo string
		/// </param>
		/// <param name="InName">
		/// - The name value to convert
		/// </param>
		/// <param name="Suffix">
		/// - A suffix to append to the end of the conversion string
		/// </param>
		/// <returns>
		/// A new string built from the passed parameters
		/// </returns>
		public static FString BuildString_Name(FString AppendTo, FString Prefix, FName InName, FString Suffix)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = AppendTo?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Prefix?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Suffix?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __BuildString_Name, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="AppendTo">
		/// - An existing string to use as the start of the conversion string
		/// </param>
		/// <param name="Prefix">
		/// - A string to use as a prefix, after the AppendTo string
		/// </param>
		/// <param name="InIntVector">
		/// - The intVector value to convert. Uses the standard FVector::ToString conversion
		/// </param>
		/// <param name="Suffix">
		/// - A suffix to append to the end of the conversion string
		/// </param>
		/// <returns>
		/// A new string built from the passed parameters
		/// </returns>
		public static FString BuildString_IntVector(FString AppendTo, FString Prefix, FIntVector InIntVector, FString Suffix)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = AppendTo?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Prefix?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InIntVector?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Suffix?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __BuildString_IntVector, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="AppendTo">
		/// - An existing string to use as the start of the conversion string
		/// </param>
		/// <param name="Prefix">
		/// - A string to use as a prefix, after the AppendTo string
		/// </param>
		/// <param name="InInt">
		/// - The int value to convert
		/// </param>
		/// <param name="Suffix">
		/// - A suffix to append to the end of the conversion string
		/// </param>
		/// <returns>
		/// A new string built from the passed parameters
		/// </returns>
		public static FString BuildString_Int(FString AppendTo, FString Prefix, int InInt, FString Suffix)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = AppendTo?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Prefix?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = InInt;

				*(nint*)(__InBuffer + 20) = Suffix?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __BuildString_Int, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="AppendTo">
		/// - An existing string to use as the start of the conversion string
		/// </param>
		/// <param name="Prefix">
		/// - A string to use as a prefix, after the AppendTo string
		/// </param>
		/// <param name="InDouble">
		/// - The double value to convert
		/// </param>
		/// <param name="Suffix">
		/// - A suffix to append to the end of the conversion string
		/// </param>
		/// <returns>
		/// A new string built from the passed parameters
		/// </returns>
		public static FString BuildString_Double(FString AppendTo, FString Prefix, double InDouble, FString Suffix)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = AppendTo?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Prefix?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 16) = InDouble;

				*(nint*)(__InBuffer + 24) = Suffix?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __BuildString_Double, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="AppendTo">
		/// - An existing string to use as the start of the conversion string
		/// </param>
		/// <param name="Prefix">
		/// - A string to use as a prefix, after the AppendTo string
		/// </param>
		/// <param name="InColor">
		/// - The linear color value to convert. Uses the standard ToString conversion
		/// </param>
		/// <param name="Suffix">
		/// - A suffix to append to the end of the conversion string
		/// </param>
		/// <returns>
		/// A new string built from the passed parameters
		/// </returns>
		public static FString BuildString_Color(FString AppendTo, FString Prefix, FLinearColor InColor, FString Suffix)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = AppendTo?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Prefix?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Suffix?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __BuildString_Color, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="AppendTo">
		/// - An existing string to use as the start of the conversion string
		/// </param>
		/// <param name="Prefix">
		/// - A string to use as a prefix, after the AppendTo string
		/// </param>
		/// <param name="InBool">
		/// - The bool value to convert. Will add "true" or "false" to the conversion string
		/// </param>
		/// <param name="Suffix">
		/// - A suffix to append to the end of the conversion string
		/// </param>
		/// <returns>
		/// A new string built from the passed parameters
		/// </returns>
		public static FString BuildString_Bool(FString AppendTo, FString Prefix, bool InBool, FString Suffix)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = AppendTo?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Prefix?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = InBool;

				*(nint*)(__InBuffer + 17) = Suffix?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __BuildString_Bool, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		private static uint __TrimTrailing = 0;

		private static uint __Trim = 0;

		private static uint __ToUpper = 0;

		private static uint __ToLower = 0;

		private static uint __TimeSecondsToString = 0;

		private static uint __StartsWith = 0;

		private static uint __Split = 0;

		private static uint __RightPad = 0;

		private static uint __RightChop = 0;

		private static uint __Right = 0;

		private static uint __Reverse = 0;

		private static uint __ReplaceInline = 0;

		private static uint __Replace = 0;

		private static uint __ParseIntoArray = 0;

		private static uint __NotEqual_StrStr = 0;

		private static uint __NotEqual_StriStri = 0;

		private static uint __Mid = 0;

		private static uint __MatchesWildcard = 0;

		private static uint __Len = 0;

		private static uint __LeftPad = 0;

		private static uint __LeftChop = 0;

		private static uint __Left = 0;

		private static uint __JoinStringArray = 0;

		private static uint __IsNumeric = 0;

		private static uint __IsEmpty = 0;

		private static uint __GetSubstring = 0;

		private static uint __GetCharacterAsNumber = 0;

		private static uint __GetCharacterArrayFromString = 0;

		private static uint __FindSubstring = 0;

		private static uint __EqualEqual_StrStr = 0;

		private static uint __EqualEqual_StriStri = 0;

		private static uint __EndsWith = 0;

		private static uint __CullArray = 0;

		private static uint __Conv_VectorToString = 0;

		private static uint __Conv_Vector3fToString = 0;

		private static uint __Conv_Vector2dToString = 0;

		private static uint __Conv_TransformToString = 0;

		private static uint __Conv_StringToVector3f = 0;

		private static uint __Conv_StringToVector2D = 0;

		private static uint __Conv_StringToVector = 0;

		private static uint __Conv_StringToRotator = 0;

		private static uint __Conv_StringToName = 0;

		private static uint __Conv_StringToInt64 = 0;

		private static uint __Conv_StringToInt = 0;

		private static uint __Conv_StringToDouble = 0;

		private static uint __Conv_StringToColor = 0;

		private static uint __Conv_RotatorToString = 0;

		private static uint __Conv_PlatformUserIdToString = 0;

		private static uint __Conv_ObjectToString = 0;

		private static uint __Conv_NameToString = 0;

		private static uint __Conv_MatrixToString = 0;

		private static uint __Conv_IntVectorToString = 0;

		private static uint __Conv_IntToString = 0;

		private static uint __Conv_IntPointToString = 0;

		private static uint __Conv_Int64ToString = 0;

		private static uint __Conv_InputDeviceIdToString = 0;

		private static uint __Conv_DoubleToString = 0;

		private static uint __Conv_ColorToString = 0;

		private static uint __Conv_ByteToString = 0;

		private static uint __Conv_BoolToString = 0;

		private static uint __Contains = 0;

		private static uint __Concat_StrStr = 0;

		private static uint __BuildString_Vector2d = 0;

		private static uint __BuildString_Vector = 0;

		private static uint __BuildString_Rotator = 0;

		private static uint __BuildString_Object = 0;

		private static uint __BuildString_Name = 0;

		private static uint __BuildString_IntVector = 0;

		private static uint __BuildString_Int = 0;

		private static uint __BuildString_Double = 0;

		private static uint __BuildString_Color = 0;

		private static uint __BuildString_Bool = 0;
	}
}