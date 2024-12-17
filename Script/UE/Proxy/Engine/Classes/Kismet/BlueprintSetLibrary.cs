using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BlueprintSetLibrary")]
	public partial class UBlueprintSetLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.BlueprintSetLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void SetSetPropertyByName(UObject Object, FName PropertyName, TSet<int> Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetSetPropertyByName, __InBuffer);
			}
		}

		/// <param name="A">
		/// One set to union
		/// </param>
		/// <param name="B">
		/// Another set to union
		/// </param>
		/// <param name="Result">
		/// Set to store results in
		/// </param>
		public static void Set_Union(TSet<int> A, TSet<int> B, ref TSet<int> Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Result?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Set_Union, __InBuffer, __OutBuffer);

				Result = *(TSet<int>*)(__OutBuffer);

			}
		}

		/// <param name="A">
		/// Set
		/// </param>
		/// <param name="Result">
		/// Array
		/// </param>
		public static void Set_ToArray(TSet<int> A, ref TArray<int> Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Result?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Set_ToArray, __InBuffer, __OutBuffer);

				Result = *(TArray<int>*)(__OutBuffer);

			}
		}

		/// <param name="TargetSet">
		/// The set to remove from
		/// </param>
		/// <param name="Items">
		/// The items to remove from the set
		/// </param>
		public static void Set_RemoveItems(TSet<int> TargetSet, TArray<int> Items)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TargetSet?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Items?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __Set_RemoveItems, __InBuffer);
			}
		}

		/// <param name="TargetSet">
		/// The set to remove from
		/// </param>
		/// <param name="Item">
		/// The item to remove from the set
		/// </param>
		/// <returns>
		/// True if an item was removed (False indicates no equivalent item was present)
		/// </returns>
		public static bool Set_Remove(TSet<int> TargetSet, int Item)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = TargetSet?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Item;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Set_Remove, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TargetSet">
		/// The set to get the length of
		/// </param>
		/// <returns>
		/// The length of the set
		/// </returns>
		public static int Set_Length(TSet<int> TargetSet)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TargetSet?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Set_Length, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="TargetSet">
		/// The set to check
		/// </param>
		/// <returns>
		/// A boolean indicating if the array has any elements
		/// </returns>
		public static bool Set_IsNotEmpty(TSet<int> TargetSet)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TargetSet?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Set_IsNotEmpty, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TargetSet">
		/// The set to check
		/// </param>
		/// <returns>
		/// A boolean indicating if the array is empty
		/// </returns>
		public static bool Set_IsEmpty(TSet<int> TargetSet)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TargetSet?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Set_IsEmpty, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="A">
		/// One set to intersect
		/// </param>
		/// <param name="B">
		/// Another set to intersect
		/// </param>
		/// <param name="Result">
		/// Set to store results in
		/// </param>
		public static void Set_Intersection(TSet<int> A, TSet<int> B, ref TSet<int> Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Result?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Set_Intersection, __InBuffer, __OutBuffer);

				Result = *(TSet<int>*)(__OutBuffer);

			}
		}

		/// <param name="A">
		/// Starting set
		/// </param>
		/// <param name="B">
		/// Set of elements to remove from set A
		/// </param>
		/// <param name="Result">
		/// Set containing all elements in A that are not found in B
		/// </param>
		public static void Set_Difference(TSet<int> A, TSet<int> B, ref TSet<int> Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Result?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Set_Difference, __InBuffer, __OutBuffer);

				Result = *(TSet<int>*)(__OutBuffer);

			}
		}

		/// <param name="TargetSet">
		/// The set to search for the item
		/// </param>
		/// <param name="ItemToFind">
		/// The item to look for
		/// </param>
		/// <returns>
		/// True if the item was found within the set
		/// </returns>
		public static bool Set_Contains(TSet<int> TargetSet, int ItemToFind)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = TargetSet?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = ItemToFind;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Set_Contains, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TargetSet">
		/// The set to clear
		/// </param>
		public static void Set_Clear(TSet<int> TargetSet)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TargetSet?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __Set_Clear, __InBuffer);
			}
		}

		/// <param name="TargetSet">
		/// The set to search for the item
		/// </param>
		/// <param name="NewItems">
		/// The items to add to the set
		/// </param>
		public static void Set_AddItems(TSet<int> TargetSet, TArray<int> NewItems)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TargetSet?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewItems?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __Set_AddItems, __InBuffer);
			}
		}

		/// <param name="TargetSet">
		/// The set to add item to
		/// </param>
		/// <param name="NewItem">
		/// The item to add to the set
		/// </param>
		public static void Set_Add(TSet<int> TargetSet, int NewItem)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = TargetSet?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = NewItem;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __Set_Add, __InBuffer);
			}
		}

		private static uint __SetSetPropertyByName = 0;

		private static uint __Set_Union = 0;

		private static uint __Set_ToArray = 0;

		private static uint __Set_RemoveItems = 0;

		private static uint __Set_Remove = 0;

		private static uint __Set_Length = 0;

		private static uint __Set_IsNotEmpty = 0;

		private static uint __Set_IsEmpty = 0;

		private static uint __Set_Intersection = 0;

		private static uint __Set_Difference = 0;

		private static uint __Set_Contains = 0;

		private static uint __Set_Clear = 0;

		private static uint __Set_AddItems = 0;

		private static uint __Set_Add = 0;
	}
}