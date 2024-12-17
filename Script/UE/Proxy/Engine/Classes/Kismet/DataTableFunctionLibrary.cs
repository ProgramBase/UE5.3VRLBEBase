using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DataTableFunctionLibrary")]
	public partial class UDataTableFunctionLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.DataTableFunctionLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void GetDataTableRowNames(UDataTable Table, ref TArray<FName> OutRowNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Table?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutRowNames?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetDataTableRowNames, __InBuffer, __OutBuffer);

				OutRowNames = *(TArray<FName>*)(__OutBuffer);

			}
		}

		public static bool GetDataTableRowFromName(UDataTable Table, FName RowName, ref FTableRowBase OutRow)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Table?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = RowName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutRow?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetDataTableRowFromName, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutRow = *(FTableRowBase*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static TArray<FString> GetDataTableColumnAsString(UDataTable DataTable, FName PropertyName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = DataTable?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetDataTableColumnAsString, __InBuffer, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		/// <param name="JSONString">
		/// The Data that representing the contents of a JSON file.
		/// </param>
		/// <returns>
		/// True if the operation succeeds, check the log for errors if it didn't succeed.
		/// </returns>
		public static bool FillDataTableFromJSONString(UDataTable DataTable, FString JSONString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = DataTable?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = JSONString?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __FillDataTableFromJSONString, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="JSONFilePath">
		/// The file path of the JSON file.
		/// </param>
		/// <returns>
		/// True if the operation succeeds, check the log for errors if it didn't succeed.
		/// </returns>
		public static bool FillDataTableFromJSONFile(UDataTable DataTable, FString JSONFilePath, UScriptStruct ImportRowStruct = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = DataTable?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = JSONFilePath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ImportRowStruct?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __FillDataTableFromJSONFile, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="CSVString">
		/// The Data that representing the contents of a CSV file.
		/// </param>
		/// <returns>
		/// True if the operation succeeds, check the log for errors if it didn't succeed.
		/// </returns>
		public static bool FillDataTableFromCSVString(UDataTable DataTable, FString CSVString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = DataTable?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CSVString?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __FillDataTableFromCSVString, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="CSVFilePath">
		/// The file path of the CSV file.
		/// </param>
		/// <returns>
		/// True if the operation succeeds, check the log for errors if it didn't succeed.
		/// </returns>
		public static bool FillDataTableFromCSVFile(UDataTable DataTable, FString CSVFilePath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = DataTable?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CSVFilePath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __FillDataTableFromCSVFile, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void EvaluateCurveTableRow(UCurveTable CurveTable, FName RowName, float InXY, ref EEvaluateCurveTableResult OutResult, ref float OutXY, FString ContextString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = CurveTable?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = RowName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = InXY;

				*(byte*)(__InBuffer + 20) = (byte)OutResult;

				*(float*)(__InBuffer + 21) = OutXY;

				*(nint*)(__InBuffer + 25) = ContextString?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[5];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __EvaluateCurveTableRow, __InBuffer, __OutBuffer);

				OutResult = *(EEvaluateCurveTableResult*)(__OutBuffer);

				OutXY = *(float*)(__OutBuffer + 1);

			}
		}

		public static bool DoesDataTableRowExist(UDataTable Table, FName RowName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Table?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = RowName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DoesDataTableRowExist, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void AddDataTableRow(UDataTable DataTable, FName RowName, FTableRowBase RowData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = DataTable?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = RowName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = RowData?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AddDataTableRow, __InBuffer);
			}
		}

		private static uint __GetDataTableRowNames = 0;

		private static uint __GetDataTableRowFromName = 0;

		private static uint __GetDataTableColumnAsString = 0;

		private static uint __FillDataTableFromJSONString = 0;

		private static uint __FillDataTableFromJSONFile = 0;

		private static uint __FillDataTableFromCSVString = 0;

		private static uint __FillDataTableFromCSVFile = 0;

		private static uint __EvaluateCurveTableRow = 0;

		private static uint __DoesDataTableRowExist = 0;

		private static uint __AddDataTableRow = 0;
	}
}