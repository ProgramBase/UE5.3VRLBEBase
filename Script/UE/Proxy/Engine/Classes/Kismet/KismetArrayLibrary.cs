using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.KismetArrayLibrary")]
	public partial class UKismetArrayLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.KismetArrayLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void SetArrayPropertyByName(UObject Object, FName PropertyName, TArray<int> Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetArrayPropertyByName, __InBuffer);
			}
		}

		/// <param name="TargetArray">
		/// The array to filter from
		/// </param>
		/// <param name="FilterClass">
		/// The Actor sub-class type that acts as the filter, only objects derived from it will be returned.
		/// </param>
		/// <returns>
		/// An array containing only those objects which are derived from the class specified.
		/// </returns>
		public static void FilterArray(TArray<AActor> TargetArray, TSubclassOf<AActor> FilterClass, ref TArray<AActor> FilteredArray)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FilterClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = FilteredArray?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __FilterArray, __InBuffer, __OutBuffer);

				FilteredArray = *(TArray<AActor>*)(__OutBuffer);

			}
		}

		/// <param name="TargetArray">
		/// The array to perform the operation on
		/// </param>
		/// <param name="FirstIndex">
		/// The index of one element to be swapped
		/// </param>
		/// <param name="SecondIndex">
		/// The index of the other element to be swapped
		/// </param>
		public static void Array_Swap(TArray<int> TargetArray, int FirstIndex, int SecondIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = FirstIndex;

				*(int*)(__InBuffer + 12) = SecondIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __Array_Swap, __InBuffer);
			}
		}

		/// <param name="TargetArray">
		/// The array to shuffle
		/// </param>
		/// <param name="RandomStream">
		/// The random stream
		/// </param>
		public static void Array_ShuffleFromStream(TArray<int> TargetArray, ref FRandomStream RandomStream)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = RandomStream?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Array_ShuffleFromStream, __InBuffer, __OutBuffer);

				RandomStream = *(FRandomStream*)(__OutBuffer);

			}
		}

		/// <param name="TargetArray">
		/// The array to shuffle
		/// </param>
		public static void Array_Shuffle(TArray<int> TargetArray)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __Array_Shuffle, __InBuffer);
			}
		}

		/// <param name="TargetArray">
		/// The array to perform the operation on
		/// </param>
		/// <param name="Index">
		/// The index to assign the item to
		/// </param>
		/// <param name="Item">
		/// The item to assign to the index of the array
		/// </param>
		/// <param name="bSizeToFit">
		/// If true, the array will expand if Index is greater than the current size of the array
		/// </param>
		public static void Array_Set(TArray<int> TargetArray, int Index, int Item, bool bSizeToFit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Index;

				*(int*)(__InBuffer + 12) = Item;

				*(bool*)(__InBuffer + 16) = bSizeToFit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __Array_Set, __InBuffer);
			}
		}

		/// <param name="TargetArray">
		/// The array to reverse
		/// </param>
		public static void Array_Reverse(TArray<int> TargetArray)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __Array_Reverse, __InBuffer);
			}
		}

		/// <param name="TargetArray">
		/// The array to resize
		/// </param>
		/// <param name="Size">
		/// The new size of the array
		/// </param>
		public static void Array_Resize(TArray<int> TargetArray, int Size)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Size;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __Array_Resize, __InBuffer);
			}
		}

		/// <param name="TargetArray">
		/// The array to remove from
		/// </param>
		/// <param name="Item">
		/// The item to remove from the array
		/// </param>
		/// <returns>
		/// True if one or more items were removed
		/// </returns>
		public static bool Array_RemoveItem(TArray<int> TargetArray, int Item)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Item;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Array_RemoveItem, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TargetArray">
		/// The array to remove from
		/// </param>
		/// <param name="IndexToRemove">
		/// The index into the array to remove from
		/// </param>
		public static void Array_Remove(TArray<int> TargetArray, int IndexToRemove)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = IndexToRemove;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __Array_Remove, __InBuffer);
			}
		}

		/// <param name="TargetArray">
		/// The array
		/// </param>
		/// <param name="RandomStream">
		/// The random stream
		/// </param>
		/// <param name="OutItem">
		/// The random item from this array
		/// </param>
		/// <param name="OutIndex">
		/// The index of random item (will be -1 if array is empty)
		/// </param>
		public static void Array_RandomFromStream(TArray<int> TargetArray, ref FRandomStream RandomStream, ref int OutItem, ref int OutIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = RandomStream?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = OutItem;

				*(int*)(__InBuffer + 20) = OutIndex;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Array_RandomFromStream, __InBuffer, __OutBuffer);

				RandomStream = *(FRandomStream*)(__OutBuffer);

				OutItem = *(int*)(__OutBuffer + 8);

				OutIndex = *(int*)(__OutBuffer + 12);

			}
		}

		/// <param name="TargetArray">
		/// The array
		/// </param>
		/// <param name="OutItem">
		/// The random item from this array
		/// </param>
		/// <param name="OutIndex">
		/// The index of random item (will be -1 if array is empty)
		/// </param>
		public static void Array_Random(TArray<int> TargetArray, ref int OutItem, ref int OutIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = OutItem;

				*(int*)(__InBuffer + 12) = OutIndex;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Array_Random, __InBuffer, __OutBuffer);

				OutItem = *(int*)(__OutBuffer);

				OutIndex = *(int*)(__OutBuffer + 4);

			}
		}

		/// <param name="TargetArray">
		/// The array to get the length of
		/// </param>
		/// <returns>
		/// The length of the array
		/// </returns>
		public static int Array_Length(TArray<int> TargetArray)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Array_Length, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="TargetArray">
		/// The array to perform the operation on
		/// </param>
		/// <returns>
		/// The last valid index of the array
		/// </returns>
		public static int Array_LastIndex(TArray<int> TargetArray)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Array_LastIndex, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="TargetArray">
		/// Array to use for the IsValidIndex test
		/// </param>
		/// <param name="IndexToTest">
		/// The Index, that we want to test for being valid
		/// </param>
		/// <returns>
		/// True if the Index is Valid, i.e. greater than or equal to zero, and less than the number of elements in TargetArray.
		/// </returns>
		public static bool Array_IsValidIndex(TArray<int> TargetArray, int IndexToTest)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = IndexToTest;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Array_IsValidIndex, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TargetArray">
		/// The array to check
		/// </param>
		/// <returns>
		/// A boolean indicating if the array has any elements
		/// </returns>
		public static bool Array_IsNotEmpty(TArray<int> TargetArray)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Array_IsNotEmpty, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TargetArray">
		/// The array to check
		/// </param>
		/// <returns>
		/// A boolean indicating if the array is empty
		/// </returns>
		public static bool Array_IsEmpty(TArray<int> TargetArray)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Array_IsEmpty, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TargetArray">
		/// The array to insert into
		/// </param>
		/// <param name="NewItem">
		/// The item to insert into the array
		/// </param>
		/// <param name="Index">
		/// The index at which to insert the item into the array
		/// </param>
		public static void Array_Insert(TArray<int> TargetArray, int NewItem, int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = NewItem;

				*(int*)(__InBuffer + 12) = Index;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __Array_Insert, __InBuffer);
			}
		}

		/// <param name="ArrayA">
		/// One of the arrays to compare
		/// </param>
		/// <param name="ArrayB">
		/// The other array to compare
		/// </param>
		/// <returns>
		/// Whether the two arrays are identical
		/// </returns>
		public static bool Array_Identical(TArray<int> ArrayA, TArray<int> ArrayB)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ArrayA?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ArrayB?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Array_Identical, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TargetArray">
		/// The array to get an item from
		/// </param>
		/// <param name="Index">
		/// The index in the array to get an item from
		/// </param>
		/// <returns>
		/// A copy of the item stored at the index
		/// </returns>
		public static void Array_Get(TArray<int> TargetArray, int Index, ref int Item)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Index;

				*(int*)(__InBuffer + 12) = Item;

				var __OutBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Array_Get, __InBuffer, __OutBuffer);

				Item = *(int*)(__OutBuffer);

			}
		}

		/// <param name="TargetArray">
		/// The array to search for the item
		/// </param>
		/// <param name="ItemToFind">
		/// The item to look for
		/// </param>
		/// <returns>
		/// The index the item was found at, or -1 if not found
		/// </returns>
		public static int Array_Find(TArray<int> TargetArray, int ItemToFind)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = ItemToFind;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Array_Find, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="TargetArray">
		/// The array to search for the item
		/// </param>
		/// <param name="ItemToFind">
		/// The item to look for
		/// </param>
		/// <returns>
		/// True if the item was found within the array
		/// </returns>
		public static bool Array_Contains(TArray<int> TargetArray, int ItemToFind)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = ItemToFind;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Array_Contains, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TargetArray">
		/// The array to clear
		/// </param>
		public static void Array_Clear(TArray<int> TargetArray)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __Array_Clear, __InBuffer);
			}
		}

		/// <param name="TargetArray">
		/// The array to add the source array to
		/// </param>
		/// <param name="SourceArray">
		/// The array to add to the target array
		/// </param>
		public static void Array_Append(TArray<int> TargetArray, TArray<int> SourceArray)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SourceArray?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __Array_Append, __InBuffer);
			}
		}

		/// <param name="TargetArray">
		/// The array to add item to
		/// </param>
		/// <param name="NewItem">
		/// The item to add to the array
		/// </param>
		/// <returns>
		/// The index of the newly added item, or INDEX_NONE if the item is already present in the array
		/// </returns>
		public static int Array_AddUnique(TArray<int> TargetArray, int NewItem)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = NewItem;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Array_AddUnique, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="TargetArray">
		/// The array to add item to
		/// </param>
		/// <param name="NewItem">
		/// The item to add to the array
		/// </param>
		/// <returns>
		/// The index of the newly added item
		/// </returns>
		public static int Array_Add(TArray<int> TargetArray, int NewItem)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = TargetArray?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = NewItem;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Array_Add, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __SetArrayPropertyByName = 0;

		private static uint __FilterArray = 0;

		private static uint __Array_Swap = 0;

		private static uint __Array_ShuffleFromStream = 0;

		private static uint __Array_Shuffle = 0;

		private static uint __Array_Set = 0;

		private static uint __Array_Reverse = 0;

		private static uint __Array_Resize = 0;

		private static uint __Array_RemoveItem = 0;

		private static uint __Array_Remove = 0;

		private static uint __Array_RandomFromStream = 0;

		private static uint __Array_Random = 0;

		private static uint __Array_Length = 0;

		private static uint __Array_LastIndex = 0;

		private static uint __Array_IsValidIndex = 0;

		private static uint __Array_IsNotEmpty = 0;

		private static uint __Array_IsEmpty = 0;

		private static uint __Array_Insert = 0;

		private static uint __Array_Identical = 0;

		private static uint __Array_Get = 0;

		private static uint __Array_Find = 0;

		private static uint __Array_Contains = 0;

		private static uint __Array_Clear = 0;

		private static uint __Array_Append = 0;

		private static uint __Array_AddUnique = 0;

		private static uint __Array_Add = 0;
	}
}