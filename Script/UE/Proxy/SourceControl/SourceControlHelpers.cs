using Script.CoreUObject;
using Script.Library;
using Script.SourceControl.SourceControlHelpers;

namespace Script.SourceControl
{
	[PathName("/Script/SourceControl.SourceControlHelpers")]
	public partial class USourceControlHelpers : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SourceControl.SourceControlHelpers");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <note>
		/// Blocks until action is complete.
		/// </note>
		/// <param name="InFiles">
		/// Files or directories to sync - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
		/// </param>
		/// <param name="bSilent">
		/// if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
		/// </param>
		/// <returns>
		/// true if succeeded, false if failed and can call LastErrorMsg() for more info.
		/// </returns>
		public static bool SyncFiles(TArray<FString> InFiles, bool bSilent = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InFiles?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSilent;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SyncFiles, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Blocks until action is complete.
		/// </note>
		/// <param name="InFile">
		/// The file or directory to sync - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
		/// </param>
		/// <param name="bSilent">
		/// if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
		/// </param>
		/// <returns>
		/// true if succeeded, false if failed and can call LastErrorMsg() for more info.
		/// </returns>
		public static bool SyncFile(FString InFile, bool bSilent = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InFile?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSilent;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SyncFile, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Blocks until action is complete.
		/// </note>
		/// <param name="InFiles">
		/// Files to check out - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
		/// </param>
		/// <param name="bSilent">
		/// if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
		/// </param>
		/// <returns>
		/// true if succeeded, false if failed and can call LastErrorMsg() for more info.
		/// </returns>
		public static bool RevertUnchangedFiles(TArray<FString> InFiles, bool bSilent = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InFiles?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSilent;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RevertUnchangedFiles, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Blocks until action is complete.
		/// </note>
		/// <param name="InFile">
		/// File to check out - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
		/// </param>
		/// <param name="bSilent">
		/// if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
		/// </param>
		/// <returns>
		/// true if succeeded, false if failed and can call LastErrorMsg() for more info.
		/// </returns>
		public static bool RevertUnchangedFile(FString InFile, bool bSilent = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InFile?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSilent;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RevertUnchangedFile, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Blocks until action is complete.
		/// </note>
		/// <param name="InFiles">
		/// Files to revert - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
		/// </param>
		/// <param name="bSilent">
		/// if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
		/// </param>
		/// <returns>
		/// true if succeeded, false if failed and can call LastErrorMsg() for more info.
		/// </returns>
		public static bool RevertFiles(TArray<FString> InFiles, bool bSilent = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InFiles?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSilent;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RevertFiles, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Blocks until action is complete.
		/// </note>
		/// <param name="InFile">
		/// The file to revert - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
		/// </param>
		/// <param name="bSilent">
		/// if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
		/// </param>
		/// <returns>
		/// true if succeeded, false if failed and can call LastErrorMsg() for more info.
		/// </returns>
		public static bool RevertFile(FString InFile, bool bSilent = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InFile?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSilent;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RevertFile, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InPackagesToRevert">
		/// The packages to revert
		/// </param>
		/// <param name="bRevertAll">
		/// Whether to revert all files
		/// </param>
		/// <param name="bReloadWorld">
		/// Reload the world
		/// </param>
		/// <returns>
		/// true if succeeded.
		/// </returns>
		public static bool RevertAndReloadPackages(TArray<FString> InPackagesToRevert, bool bRevertAll = false, bool bReloadWorld = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InPackagesToRevert?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bRevertAll;

				*(bool*)(__InBuffer + 9) = bReloadWorld;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RevertAndReloadPackages, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Blocks until action is complete.
		/// </note>
		/// <param name="InFile">
		/// The file to query - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
		/// </param>
		/// <param name="bSilent">
		/// if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
		/// </param>
		/// <returns>
		/// Source control state - see USourceControlState. It will have bIsValid set to false if
		/// it could not have its values set.
		/// </returns>
		public static FSourceControlState QueryFileState(FString InFile, bool bSilent = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InFile?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSilent;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __QueryFileState, __InBuffer, __ReturnBuffer);

				return *(FSourceControlState*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Blocks until action is complete.
		/// </note>
		/// <param name="InFile">
		/// The file to delete - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
		/// </param>
		/// <param name="bSilent">
		/// if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
		/// </param>
		/// <returns>
		/// true if succeeded, false if failed and can call LastErrorMsg() for more info.
		/// </returns>
		public static bool MarkFilesForDelete(TArray<FString> InFiles, bool bSilent = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InFiles?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSilent;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __MarkFilesForDelete, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Blocks until action is complete.
		/// </note>
		/// <param name="InFiles">
		/// Files to check out - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
		/// </param>
		/// <param name="bSilent">
		/// if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
		/// </param>
		/// <returns>
		/// true if succeeded, false if failed and can call LastErrorMsg() for more info.
		/// </returns>
		public static bool MarkFilesForAdd(TArray<FString> InFiles, bool bSilent = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InFiles?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSilent;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __MarkFilesForAdd, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Blocks until action is complete.
		/// </note>
		/// <param name="InFile">
		/// The file to delete - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
		/// </param>
		/// <param name="bSilent">
		/// if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
		/// </param>
		/// <returns>
		/// true if succeeded, false if failed and can call LastErrorMsg() for more info.
		/// </returns>
		public static bool MarkFileForDelete(FString InFile, bool bSilent = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InFile?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSilent;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __MarkFileForDelete, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Blocks until action is complete.
		/// </note>
		/// <param name="InFile">
		/// The file to add - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
		/// </param>
		/// <param name="bSilent">
		/// if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
		/// </param>
		/// <returns>
		/// true if succeeded, false if failed and can call LastErrorMsg() for more info.
		/// </returns>
		public static bool MarkFileForAdd(FString InFile, bool bSilent = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InFile?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSilent;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __MarkFileForAdd, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FText LastErrorMsg()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __LastErrorMsg, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if enabled, false if not
		/// </returns>
		public static bool IsEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __IsEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if source control is available, false if it is not
		/// </returns>
		public static bool IsAvailable()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __IsAvailable, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// the name of the current source control provider. If one is not set then "None" is returned.
		/// </returns>
		public static FString CurrentProvider()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __CurrentProvider, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Blocks until action is complete.
		/// </note>
		/// <param name="InSourceFile">
		/// Source file string to copy from - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
		/// </param>
		/// <param name="InDestFile">
		/// Source file string to copy to - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard). If package, then uses same extension as source file.
		/// </param>
		/// <param name="bSilent">
		/// if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
		/// </param>
		/// <returns>
		/// true if succeeded, false if failed and can call LastErrorMsg() for more info.
		/// </returns>
		public static bool CopyFile(FString InSourceFile, FString InDestFile, bool bSilent = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InSourceFile?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InDestFile?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSilent;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CopyFile, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Blocks until action is complete.
		/// </note>
		/// <param name="InFiles">
		/// The files to check out/add - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
		/// </param>
		/// <param name="bSilent">
		/// if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
		/// </param>
		/// <returns>
		/// true if succeeded, false if failed and can call LastErrorMsg() for more info.
		/// </returns>
		public static bool CheckOutOrAddFiles(TArray<FString> InFiles, bool bSilent = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InFiles?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSilent;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckOutOrAddFiles, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Blocks until action is complete.
		/// </note>
		/// <param name="InFile">
		/// The file to check out/add - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
		/// </param>
		/// <param name="bSilent">
		/// if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
		/// </param>
		/// <returns>
		/// true if succeeded, false if failed and can call LastErrorMsg() for more info.
		/// </returns>
		public static bool CheckOutOrAddFile(FString InFile, bool bSilent = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InFile?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSilent;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckOutOrAddFile, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Blocks until action is complete.
		/// </note>
		/// <param name="InFiles">
		/// Files to check out - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
		/// </param>
		/// <param name="bSilent">
		/// if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
		/// </param>
		/// <returns>
		/// true if succeeded, false if failed and can call LastErrorMsg() for more info.
		/// </returns>
		public static bool CheckOutFiles(TArray<FString> InFiles, bool bSilent = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InFiles?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSilent;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckOutFiles, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Blocks until action is complete.
		/// </note>
		/// <param name="InFile">
		/// The file to check out - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
		/// </param>
		/// <param name="bSilent">
		/// if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
		/// </param>
		/// <returns>
		/// true if succeeded, false if failed and can call LastErrorMsg() for more info.
		/// </returns>
		public static bool CheckOutFile(FString InFile, bool bSilent = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InFile?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSilent;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckOutFile, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Blocks until action is complete.
		/// </note>
		/// <param name="InFiles">
		/// Files to check out - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
		/// </param>
		/// <param name="InDescription">
		/// Description for check in
		/// </param>
		/// <param name="bSilent">
		/// if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
		/// </param>
		/// <param name="bKeepCheckedOut">
		/// Keep files checked-out after checking in. This is helpful for maintaining "ownership" of files if further operations are needed.
		/// </param>
		/// <returns>
		/// true if succeeded, false if failed and can call LastErrorMsg() for more info.
		/// </returns>
		public static bool CheckInFiles(TArray<FString> InFiles, FString InDescription, bool bSilent = false, bool bKeepCheckedOut = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = InFiles?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InDescription?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSilent;

				*(bool*)(__InBuffer + 17) = bKeepCheckedOut;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckInFiles, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Blocks until action is complete.
		/// </note>
		/// <param name="InFile">
		/// The file to check in - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
		/// </param>
		/// <param name="InDescription">
		/// Description for check in
		/// </param>
		/// <param name="bSilent">
		/// if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
		/// </param>
		/// <param name="bKeepCheckedOut">
		/// Keep files checked-out after checking in. This is helpful for maintaining "ownership" of files if further operations are needed.
		/// </param>
		/// <returns>
		/// true if succeeded, false if failed and can call LastErrorMsg() for more info.
		/// </returns>
		public static bool CheckInFile(FString InFile, FString InDescription, bool bSilent = false, bool bKeepCheckedOut = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = InFile?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InDescription?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSilent;

				*(bool*)(__InBuffer + 17) = bKeepCheckedOut;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckInFile, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="FileStateCallback">
		/// Source control state - see USourceControlState. It will have bIsValid set to false if it could not have its values set.
		/// </param>
		/// <param name="InFile">
		/// The file to query - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
		/// </param>
		/// <param name="bSilent">
		/// if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
		/// </param>
		public static void AsyncQueryFileState(FQueryFileStateDelegate FileStateCallback, FString InFile, bool bSilent = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = FileStateCallback?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InFile?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSilent;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AsyncQueryFileState, __InBuffer);
			}
		}

		private static uint __SyncFiles = 0;

		private static uint __SyncFile = 0;

		private static uint __RevertUnchangedFiles = 0;

		private static uint __RevertUnchangedFile = 0;

		private static uint __RevertFiles = 0;

		private static uint __RevertFile = 0;

		private static uint __RevertAndReloadPackages = 0;

		private static uint __QueryFileState = 0;

		private static uint __MarkFilesForDelete = 0;

		private static uint __MarkFilesForAdd = 0;

		private static uint __MarkFileForDelete = 0;

		private static uint __MarkFileForAdd = 0;

		private static uint __LastErrorMsg = 0;

		private static uint __IsEnabled = 0;

		private static uint __IsAvailable = 0;

		private static uint __CurrentProvider = 0;

		private static uint __CopyFile = 0;

		private static uint __CheckOutOrAddFiles = 0;

		private static uint __CheckOutOrAddFile = 0;

		private static uint __CheckOutFiles = 0;

		private static uint __CheckOutFile = 0;

		private static uint __CheckInFiles = 0;

		private static uint __CheckInFile = 0;

		private static uint __AsyncQueryFileState = 0;
	}
}