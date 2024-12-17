using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BlueprintMapLibrary")]
	public partial class UBlueprintMapLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.BlueprintMapLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void SetMapPropertyByName(UObject Object, FName PropertyName, TMap<int, int> Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetMapPropertyByName, __InBuffer);
			}
		}

		/// <param name="TargetMap">
		/// The map to get the list of values from
		/// </param>
		/// <param name="Values">
		/// All values present in the map
		/// </param>
		public static void Map_Values(TMap<int, int> TargetMap, ref TArray<int> Values)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TargetMap?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Values?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Map_Values, __InBuffer, __OutBuffer);

				Values = *(TArray<int>*)(__OutBuffer);

			}
		}

		/// <param name="TargetMap">
		/// The map to remove the key and its associated value from
		/// </param>
		/// <param name="Key">
		/// The key that will be used to look the value up
		/// </param>
		/// <returns>
		/// True if an item was removed (False indicates nothing in the map uses the provided key)
		/// </returns>
		public static bool Map_Remove(TMap<int, int> TargetMap, int Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = TargetMap?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Key;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Map_Remove, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TargetMap">
		/// The map in question
		/// </param>
		/// <returns>
		/// The number of entries in the map
		/// </returns>
		public static int Map_Length(TMap<int, int> TargetMap)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TargetMap?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Map_Length, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="TargetMap">
		/// The map to get the list of keys from
		/// </param>
		/// <param name="Keys">
		/// All keys present in the map
		/// </param>
		public static void Map_Keys(TMap<int, int> TargetMap, ref TArray<int> Keys)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TargetMap?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Keys?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Map_Keys, __InBuffer, __OutBuffer);

				Keys = *(TArray<int>*)(__OutBuffer);

			}
		}

		/// <param name="TargetMap">
		/// The map to check
		/// </param>
		/// <returns>
		/// A boolean indicating if the map has any entires
		/// </returns>
		public static bool Map_IsNotEmpty(TMap<int, int> TargetMap)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TargetMap?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Map_IsNotEmpty, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TargetMap">
		/// The map to check
		/// </param>
		/// <returns>
		/// A boolean indicating if the map has any entires
		/// </returns>
		public static bool Map_IsEmpty(TMap<int, int> TargetMap)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TargetMap?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Map_IsEmpty, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TargetMap">
		/// The map to perform the lookup on
		/// </param>
		/// <param name="Key">
		/// The key that will be used to look the value up
		/// </param>
		/// <param name="Value">
		/// The value associated with the key, default constructed if key was not found
		/// </param>
		/// <returns>
		/// True if an item was found (False indicates nothing in the map uses the provided key)
		/// </returns>
		public static bool Map_Find(TMap<int, int> TargetMap, int Key, ref int Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TargetMap?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Key;

				*(int*)(__InBuffer + 12) = Value;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __Map_Find, __InBuffer, __OutBuffer, __ReturnBuffer);

				Value = *(int*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TargetMap">
		/// The map to perform the lookup on
		/// </param>
		/// <param name="Key">
		/// The key that will be used to lookup
		/// </param>
		/// <returns>
		/// True if an item was found (False indicates nothing in the map uses the provided key)
		/// </returns>
		public static bool Map_Contains(TMap<int, int> TargetMap, int Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = TargetMap?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Key;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Map_Contains, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TargetMap">
		/// The map to clear
		/// </param>
		public static void Map_Clear(TMap<int, int> TargetMap)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TargetMap?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __Map_Clear, __InBuffer);
			}
		}

		/// <param name="TargetMap">
		/// The map to add the key and value to
		/// </param>
		/// <param name="Key">
		/// The key that will be used to look the value up
		/// </param>
		/// <param name="Value">
		/// The value to be retrieved later
		/// </param>
		public static void Map_Add(TMap<int, int> TargetMap, int Key, int Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TargetMap?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Key;

				*(int*)(__InBuffer + 12) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __Map_Add, __InBuffer);
			}
		}

		private static uint __SetMapPropertyByName = 0;

		private static uint __Map_Values = 0;

		private static uint __Map_Remove = 0;

		private static uint __Map_Length = 0;

		private static uint __Map_Keys = 0;

		private static uint __Map_IsNotEmpty = 0;

		private static uint __Map_IsEmpty = 0;

		private static uint __Map_Find = 0;

		private static uint __Map_Contains = 0;

		private static uint __Map_Clear = 0;

		private static uint __Map_Add = 0;
	}
}