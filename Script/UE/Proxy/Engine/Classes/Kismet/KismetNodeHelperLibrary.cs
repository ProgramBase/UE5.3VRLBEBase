using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.KismetNodeHelperLibrary")]
	public partial class UKismetNodeHelperLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.KismetNodeHelperLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Data">
		/// - The integer containing the bits that are being set
		/// </param>
		/// <param name="Index">
		/// - The bit index into the Data that we are setting
		/// </param>
		public static void MarkBit(ref int Data, int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = Data;

				*(int*)(__InBuffer + 4) = Index;

				var __OutBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __MarkBit, __InBuffer, __OutBuffer);

				Data = *(int*)(__OutBuffer);

			}
		}

		/// <param name="Data">
		/// - The data being tested against
		/// </param>
		/// <param name="NumBits">
		/// - The logical number of bits we want to track
		/// </param>
		/// <returns>
		/// - Whether there is a bit not marked in the data
		/// </returns>
		public static bool HasUnmarkedBit(int Data, int NumBits)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = Data;

				*(int*)(__InBuffer + 4) = NumBits;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __HasUnmarkedBit, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Data">
		/// - The data being tested against
		/// </param>
		/// <param name="NumBits">
		/// - The logical number of bits we want to track
		/// </param>
		/// <returns>
		/// - Whether there is a bit marked in the data
		/// </returns>
		public static bool HasMarkedBit(int Data, int NumBits)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = Data;

				*(int*)(__InBuffer + 4) = NumBits;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __HasMarkedBit, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Enum">
		/// - Enumeration
		/// </param>
		/// <param name="EnumeratorIndex">
		/// - Input value
		/// </param>
		/// <returns>
		/// - if EnumeratorIndex is valid return EnumeratorIndex, otherwise return MAX value of Enum
		/// </returns>
		public static byte GetValidValue(UEnum Enum, byte EnumeratorValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Enum?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = EnumeratorValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetValidValue, __InBuffer, __ReturnBuffer);

				return *(byte*)__ReturnBuffer;
			}
		}

		/// <param name="Data">
		/// - The integer containing the bits that are being set
		/// </param>
		/// <param name="StartIdx">
		/// - The index to start with when determining the selection'
		/// </param>
		/// <param name="NumBits">
		/// - The logical number of bits we want to track
		/// </param>
		/// <param name="bRandom">
		/// - Whether to select a random index or not
		/// </param>
		/// <returns>
		/// - The index that was selected (returns INDEX_NONE if there was no unmarked bits to choose from)
		/// </returns>
		public static int GetUnmarkedBit(int Data, int StartIdx, int NumBits, bool bRandom)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(int*)(__InBuffer) = Data;

				*(int*)(__InBuffer + 4) = StartIdx;

				*(int*)(__InBuffer + 8) = NumBits;

				*(bool*)(__InBuffer + 12) = bRandom;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetUnmarkedBit, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="Data">
		/// - The integer containing the bits that are being set
		/// </param>
		/// <param name="NumBits">
		/// - The logical number of bits we want to track
		/// </param>
		/// <returns>
		/// - The index that was selected (returns INDEX_NONE if there was no unmarked bits to choose from)
		/// </returns>
		public static int GetRandomUnmarkedBit(int Data, int StartIdx, int NumBits)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = Data;

				*(int*)(__InBuffer + 4) = StartIdx;

				*(int*)(__InBuffer + 8) = NumBits;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetRandomUnmarkedBit, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="Data">
		/// - The integer containing the bits that are being set
		/// </param>
		/// <param name="StartIdx">
		/// - The index to start looking for an available index from
		/// </param>
		/// <param name="NumBits">
		/// - The logical number of bits we want to track
		/// </param>
		/// <returns>
		/// - The index that was selected (returns INDEX_NONE if there was no unmarked bits to choose from)
		/// </returns>
		public static int GetFirstUnmarkedBit(int Data, int StartIdx, int NumBits)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = Data;

				*(int*)(__InBuffer + 4) = StartIdx;

				*(int*)(__InBuffer + 8) = NumBits;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetFirstUnmarkedBit, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="Enum">
		/// - Enumeration
		/// </param>
		/// <param name="EnumeratorIndex">
		/// - Input index
		/// </param>
		/// <returns>
		/// - The value of the enumerator, or INDEX_NONE
		/// </returns>
		public static byte GetEnumeratorValueFromIndex(UEnum Enum, byte EnumeratorIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Enum?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = EnumeratorIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetEnumeratorValueFromIndex, __InBuffer, __ReturnBuffer);

				return *(byte*)__ReturnBuffer;
			}
		}

		/// <param name="Enum">
		/// - Enumeration
		/// </param>
		/// <param name="EnumeratorValue">
		/// - Value of searched enumeration
		/// </param>
		/// <returns>
		/// - name of the searched enumerator, or NAME_None
		/// </returns>
		public static FString GetEnumeratorUserFriendlyName(UEnum Enum, byte EnumeratorValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Enum?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = EnumeratorValue;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetEnumeratorUserFriendlyName, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="Enum">
		/// - Enumeration
		/// </param>
		/// <param name="EnumeratorValue">
		/// - Value of searched enumeration
		/// </param>
		/// <returns>
		/// - name of the searched enumerator, or NAME_None
		/// </returns>
		public static FName GetEnumeratorName(UEnum Enum, byte EnumeratorValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Enum?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = EnumeratorValue;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetEnumeratorName, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		/// <param name="Data">
		/// - The integer containing the bits that are being cleared
		/// </param>
		/// <param name="Index">
		/// - The bit index into the Data that we are clearing
		/// </param>
		public static void ClearBit(ref int Data, int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = Data;

				*(int*)(__InBuffer + 4) = Index;

				var __OutBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __ClearBit, __InBuffer, __OutBuffer);

				Data = *(int*)(__OutBuffer);

			}
		}

		/// <param name="Data">
		/// - The integer containing the bits that are being cleared
		/// </param>
		public static void ClearAllBits(ref int Data)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Data;

				var __OutBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __ClearAllBits, __InBuffer, __OutBuffer);

				Data = *(int*)(__OutBuffer);

			}
		}

		/// <param name="Data">
		/// - The integer containing the bits that are being tested against
		/// </param>
		/// <param name="Index">
		/// - The bit index into the Data that we are inquiring
		/// </param>
		/// <returns>
		/// - Whether the bit at index "Index" is set or not
		/// </returns>
		public static bool BitIsMarked(int Data, int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = Data;

				*(int*)(__InBuffer + 4) = Index;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __BitIsMarked, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __MarkBit = 0;

		private static uint __HasUnmarkedBit = 0;

		private static uint __HasMarkedBit = 0;

		private static uint __GetValidValue = 0;

		private static uint __GetUnmarkedBit = 0;

		private static uint __GetRandomUnmarkedBit = 0;

		private static uint __GetFirstUnmarkedBit = 0;

		private static uint __GetEnumeratorValueFromIndex = 0;

		private static uint __GetEnumeratorUserFriendlyName = 0;

		private static uint __GetEnumeratorName = 0;

		private static uint __ClearBit = 0;

		private static uint __ClearAllBits = 0;

		private static uint __BitIsMarked = 0;
	}
}