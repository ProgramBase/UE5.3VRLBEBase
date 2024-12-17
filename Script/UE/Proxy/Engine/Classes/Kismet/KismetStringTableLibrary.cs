using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.KismetStringTableLibrary")]
	public partial class UKismetStringTableLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.KismetStringTableLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static bool IsRegisteredTableId(FName TableId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TableId?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsRegisteredTableId, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsRegisteredTableEntry(FName TableId, FString Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TableId?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsRegisteredTableEntry, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FString GetTableNamespace(FName TableId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TableId?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetTableNamespace, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString GetTableEntrySourceString(FName TableId, FString Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TableId?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetTableEntrySourceString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString GetTableEntryMetaData(FName TableId, FString Key, FName MetaDataId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = TableId?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = MetaDataId?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetTableEntryMetaData, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static TArray<FName> GetRegisteredStringTables()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetRegisteredStringTables, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		public static TArray<FName> GetMetaDataIdsFromStringTableEntry(FName TableId, FString Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TableId?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMetaDataIdsFromStringTableEntry, __InBuffer, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		public static TArray<FString> GetKeysFromStringTable(FName TableId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TableId?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetKeysFromStringTable, __InBuffer, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		private static uint __IsRegisteredTableId = 0;

		private static uint __IsRegisteredTableEntry = 0;

		private static uint __GetTableNamespace = 0;

		private static uint __GetTableEntrySourceString = 0;

		private static uint __GetTableEntryMetaData = 0;

		private static uint __GetRegisteredStringTables = 0;

		private static uint __GetMetaDataIdsFromStringTableEntry = 0;

		private static uint __GetKeysFromStringTable = 0;
	}
}