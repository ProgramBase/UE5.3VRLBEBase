using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.FlibPakHelper")]
	public partial class UFlibPakHelper : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/HotPatcherRuntime.FlibPakHelper");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static bool UnMountPak(FString PakPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PakPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __UnMountPak, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool ScanPlatformDirectory(FString InRelativePath, bool bIncludeFile, bool bIncludeDir, bool bRecursively, ref TArray<FString> OutResault)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = InRelativePath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIncludeFile;

				*(bool*)(__InBuffer + 9) = bIncludeDir;

				*(bool*)(__InBuffer + 10) = bRecursively;

				*(nint*)(__InBuffer + 11) = OutResault?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __ScanPlatformDirectory, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutResault = *(TArray<FString>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static TArray<FString> ScanExtenPakFiles()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __ScanExtenPakFiles, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public static bool ScanExtenFilesInDirectory(FString InRelativePath, FString InExtenPostfix, bool InRecursively, ref TArray<FString> OutFiles)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = InRelativePath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InExtenPostfix?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = InRecursively;

				*(nint*)(__InBuffer + 17) = OutFiles?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __ScanExtenFilesInDirectory, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutFiles = *(TArray<FString>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static TArray<FString> ScanAllVersionDescribleFiles()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __ScanAllVersionDescribleFiles, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public static void ReloadShaderbytecode()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __ReloadShaderbytecode);
			}
		}

		public static bool OpenPSO(FString Name)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __OpenPSO, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool MountPak(FString PakPath, int PakOrder, FString InMountPoint = null)
		{
			unsafe
			{
				InMountPoint ??= new FString("");

				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = PakPath?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = PakOrder;

				*(nint*)(__InBuffer + 12) = InMountPoint?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __MountPak, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void LoadShaderLibrary(FString ScanShaderLibs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ScanShaderLibs?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __LoadShaderLibrary, __InBuffer);
			}
		}

		public static bool LoadShaderbytecodeInDefaultDir(FString LibraryName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LibraryName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __LoadShaderbytecodeInDefaultDir, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool LoadShaderbytecode(FString LibraryName, FString LibraryDir, bool bNative = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = LibraryName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LibraryDir?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bNative;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __LoadShaderbytecode, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void LoadHotPatcherAllShaderLibrarys()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __LoadHotPatcherAllShaderLibrarys);
			}
		}

		public static bool LoadAssetRegistry(FString LibraryName, FString LibraryDir)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = LibraryName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LibraryDir?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __LoadAssetRegistry, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static int GetPakOrderByPakPath(FString PakFile)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PakFile?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPakOrderByPakPath, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static TArray<FString> GetAllMountedPaks()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetAllMountedPaks, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public static void ExecMountPak(FString InPakPath, int InPakOrder, FString InMountPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = InPakPath?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InPakOrder;

				*(nint*)(__InBuffer + 12) = InMountPoint?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ExecMountPak, __InBuffer);
			}
		}

		public static bool CreateFileByBytes(FString InFile, TArray<byte> InBytes, int InWriteFlag = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = InFile?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InBytes?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = InWriteFlag;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateFileByBytes, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void CloseShaderbytecode(FString LibraryName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LibraryName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __CloseShaderbytecode, __InBuffer);
			}
		}

		private static uint __UnMountPak = 0;

		private static uint __ScanPlatformDirectory = 0;

		private static uint __ScanExtenPakFiles = 0;

		private static uint __ScanExtenFilesInDirectory = 0;

		private static uint __ScanAllVersionDescribleFiles = 0;

		private static uint __ReloadShaderbytecode = 0;

		private static uint __OpenPSO = 0;

		private static uint __MountPak = 0;

		private static uint __LoadShaderLibrary = 0;

		private static uint __LoadShaderbytecodeInDefaultDir = 0;

		private static uint __LoadShaderbytecode = 0;

		private static uint __LoadHotPatcherAllShaderLibrarys = 0;

		private static uint __LoadAssetRegistry = 0;

		private static uint __GetPakOrderByPakPath = 0;

		private static uint __GetAllMountedPaks = 0;

		private static uint __ExecMountPak = 0;

		private static uint __CreateFileByBytes = 0;

		private static uint __CloseShaderbytecode = 0;
	}
}