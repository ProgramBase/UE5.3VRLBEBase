using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.DatasmithContentBlueprintLibrary")]
	public partial class UDatasmithContentBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DatasmithContent.DatasmithContentBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Object">
		/// The Object from which to retrieve the Datasmith User Data.
		/// </param>
		/// <param name="Key">
		/// The key to find in the Datasmith User Data.
		/// </param>
		/// <param name="bPartialMatchKey">
		/// If true, check for contains, rather than exact match.
		/// </param>
		/// <returns>
		/// The string value associated with the given key
		/// </returns>
		public static TArray<FString> GetDatasmithUserDataValuesForKey(UObject Object, FName Key, bool bPartialMatchKey = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bPartialMatchKey;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetDatasmithUserDataValuesForKey, __InBuffer, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		/// <param name="Object">
		/// The Object from which to retrieve the Datasmith User Data.
		/// </param>
		/// <param name="Key">
		/// The key to find in the Datasmith User Data.
		/// </param>
		/// <returns>
		/// The string value associated with the given key
		/// </returns>
		public static FString GetDatasmithUserDataValueForKey(UObject Object, FName Key, bool bPartialMatchKey = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bPartialMatchKey;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetDatasmithUserDataValueForKey, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="Object">
		/// The Object from which to retrieve the Datasmith User Data.
		/// </param>
		/// <param name="StringToMatch">
		/// The string to match in the values.
		/// </param>
		/// <param name="OutKeys">
		/// Output array of keys for which the associated values contain the string to match.
		/// </param>
		/// <param name="OutValues">
		/// Output array of values associated to the keys.
		/// </param>
		public static void GetDatasmithUserDataKeysAndValuesForValue(UObject Object, FString StringToMatch, ref TArray<FName> OutKeys, ref TArray<FString> OutValues)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = StringToMatch?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutKeys?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutValues?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetDatasmithUserDataKeysAndValuesForValue, __InBuffer, __OutBuffer);

				OutKeys = *(TArray<FName>*)(__OutBuffer);

				OutValues = *(TArray<FString>*)(__OutBuffer + 8);

			}
		}

		/// <param name="Object">
		/// The Object from which to retrieve the Datasmith User Data.
		/// </param>
		/// <returns>
		/// The Datasmith User Data if it exists; nullptr, otherwise
		/// </returns>
		public static UDatasmithAssetUserData GetDatasmithUserData(UObject Object)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetDatasmithUserData, __InBuffer, __ReturnBuffer);

				return *(UDatasmithAssetUserData*)__ReturnBuffer;
			}
		}

		/// <param name="Key">
		/// The key to find in the Datasmith User Data.
		/// </param>
		/// <param name="ObjectClass">
		/// Class of the object on which to filter, if specificed; otherwise there's no filtering
		/// </param>
		/// <param name="OutObjects">
		/// Output array of objects for which the Datasmith User Data match the given key.
		/// </param>
		/// <param name="OutValues">
		/// Output array of values associated with each object in OutObjects.
		/// </param>
		public static void GetAllObjectsAndValuesForKey(FName Key, TSubclassOf<UObject> ObjectClass, ref TArray<UObject> OutObjects, ref TArray<FString> OutValues)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ObjectClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutObjects?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutValues?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAllObjectsAndValuesForKey, __InBuffer, __OutBuffer);

				OutObjects = *(TArray<UObject>*)(__OutBuffer);

				OutValues = *(TArray<FString>*)(__OutBuffer + 8);

			}
		}

		/// <param name="ObjectClass">
		/// Class of the object on which to filter, if specificed; otherwise there's no filtering
		/// </param>
		/// <param name="OutUserData">
		/// Output array of Datasmith User Data.
		/// </param>
		public static void GetAllDatasmithUserData(TSubclassOf<UObject> ObjectClass, ref TArray<UDatasmithAssetUserData> OutUserData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ObjectClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutUserData?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAllDatasmithUserData, __InBuffer, __OutBuffer);

				OutUserData = *(TArray<UDatasmithAssetUserData>*)(__OutBuffer);

			}
		}

		private static uint __GetDatasmithUserDataValuesForKey = 0;

		private static uint __GetDatasmithUserDataValueForKey = 0;

		private static uint __GetDatasmithUserDataKeysAndValuesForValue = 0;

		private static uint __GetDatasmithUserData = 0;

		private static uint __GetAllObjectsAndValuesForKey = 0;

		private static uint __GetAllDatasmithUserData = 0;
	}
}