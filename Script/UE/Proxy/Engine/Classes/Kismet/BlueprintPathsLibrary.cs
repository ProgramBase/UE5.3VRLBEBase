using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BlueprintPathsLibrary")]
	public partial class UBlueprintPathsLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.BlueprintPathsLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <returns>
		/// Video capture directory
		/// </returns>
		public static FString VideoCaptureDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __VideoCaptureDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="InPath">
		/// - path to validate
		/// </param>
		/// <param name="OutReason">
		/// - If validation fails, this is filled with the failure reason
		/// </param>
		/// <param name="bDidSucceed">
		/// - Whether the path could be validated
		/// </param>
		public static void ValidatePath(FString InPath, ref bool bDidSucceed, ref FText OutReason)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bDidSucceed;

				*(nint*)(__InBuffer + 9) = OutReason?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __ValidatePath, __InBuffer, __OutBuffer);

				bDidSucceed = *(bool*)(__OutBuffer);

				OutReason = *(FText*)(__OutBuffer + 1);

			}
		}

		/// <param name="Path">
		/// [out] receives the value of the path portion of the input string
		/// </param>
		/// <param name="Filename">
		/// [out] receives the value of the filename portion of the input string
		/// </param>
		/// <param name="Extension">
		/// [out] receives the value of the extension portion of the input string
		/// </param>
		public static void Split(FString InPath, ref FString PathPart, ref FString FilenamePart, ref FString ExtensionPart)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PathPart?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = FilenamePart?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ExtensionPart?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[24];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Split, __InBuffer, __OutBuffer);

				PathPart = *(FString*)(__OutBuffer);

				FilenamePart = *(FString*)(__OutBuffer + 8);

				ExtensionPart = *(FString*)(__OutBuffer + 16);

			}
		}

		/// <returns>
		/// source config directory
		/// </returns>
		public static FString SourceConfigDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __SourceConfigDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static bool ShouldSaveToUserDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __ShouldSaveToUserDir, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// shader working directory
		/// </returns>
		public static FString ShaderWorkingDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __ShaderWorkingDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="NewGameProjectFilePath">
		/// - The project file path to set.
		/// </param>
		public static void SetProjectFilePath(FString NewGameProjectFilePath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewGameProjectFilePath?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetProjectFilePath, __InBuffer);
			}
		}

		public static FString SetExtension(FString InPath, FString InNewExtension)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InNewExtension?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SetExtension, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// screenshot directory
		/// </returns>
		public static FString ScreenShotDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __ScreenShotDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// sandbox directory
		/// </returns>
		public static FString SandboxesDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __SandboxesDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Root directory.
		/// </returns>
		public static FString RootDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __RootDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static void RemoveDuplicateSlashes(FString InPath, ref FString OutPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPath?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __RemoveDuplicateSlashes, __InBuffer, __OutBuffer);

				OutPath = *(FString*)(__OutBuffer);

			}
		}

		/// <returns>
		/// game user directory
		/// </returns>
		public static FString ProjectUserDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __ProjectUserDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// saved directory
		/// </returns>
		public static FString ProjectSavedDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __ProjectSavedDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// plugins directory
		/// </returns>
		public static FString ProjectPluginsDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __ProjectPluginsDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString ProjectPersistentDownloadDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __ProjectPersistentDownloadDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// mods directory
		/// </returns>
		public static FString ProjectModsDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __ProjectModsDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// log directory
		/// </returns>
		public static FString ProjectLogDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __ProjectLogDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// intermediate directory
		/// </returns>
		public static FString ProjectIntermediateDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __ProjectIntermediateDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// base directory
		/// </returns>
		public static FString ProjectDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __ProjectDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// content directory
		/// </returns>
		public static FString ProjectContentDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __ProjectContentDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// root config directory
		/// </returns>
		public static FString ProjectConfigDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __ProjectConfigDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// log directory
		/// </returns>
		public static FString ProfilingDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __ProfilingDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// </>
		/// to TEXT("/") */
		/// <//>
		public static void NormalizeFilename(FString InPath, ref FString OutPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPath?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __NormalizeFilename, __InBuffer, __OutBuffer);

				OutPath = *(FString*)(__OutBuffer);

			}
		}

		/// </>
		/// to TEXT("/") and remove any trailing TEXT("/") if the character before that is not a TEXT("/") or a colon */
		/// <//>
		public static void NormalizeDirectoryName(FString InPath, ref FString OutPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPath?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __NormalizeDirectoryName, __InBuffer, __OutBuffer);

				OutPath = *(FString*)(__OutBuffer);

			}
		}

		/// <param name="InString">
		/// </param>
		/// <param name="InReplacementChar">
		/// </param>
		public static FString MakeValidFileName(FString InString, FString InReplacementChar = null)
		{
			unsafe
			{
				InReplacementChar ??= new FString("");

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InString?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InReplacementChar?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeValidFileName, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <Binaries>
		/// </Binaries>
		/// </>
		/// <Platform> (will ALWAYS start with ..\..\..)
		/// <//>
		public static void MakeStandardFilename(FString InPath, ref FString OutPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPath?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __MakeStandardFilename, __InBuffer, __OutBuffer);

				OutPath = *(FString*)(__OutBuffer);

			}
		}

		public static void MakePlatformFilename(FString InPath, ref FString OutPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPath?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __MakePlatformFilename, __InBuffer, __OutBuffer);

				OutPath = *(FString*)(__OutBuffer);

			}
		}

		/// <param name="InPath">
		/// Path to change to be relative to InRelativeTo
		/// </param>
		/// <param name="InRelativeTo">
		/// Path to use as the new relative base
		/// </param>
		/// <param name="InPath">
		/// New path relative to InRelativeTo
		/// </param>
		/// <returns>
		/// true if OutPath was changed to be relative
		/// </returns>
		public static bool MakePathRelativeTo(FString InPath, FString InRelativeTo, ref FString OutPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InRelativeTo?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutPath?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __MakePathRelativeTo, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutPath = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FString LaunchDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __LaunchDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="PathA">
		/// First path to check.
		/// </param>
		/// <param name="PathB">
		/// Second path to check.
		/// </param>
		/// <returns>
		/// True if both paths are the same. False otherwise.
		/// </returns>
		public static bool IsSamePath(FString PathA, FString PathB)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PathA?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PathB?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsSamePath, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsRestrictedPath(FString InPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsRestrictedPath, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsRelative(FString InPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsRelative, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if the path is set, false otherwise.
		/// </returns>
		public static bool IsProjectFilePathSet()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __IsProjectFilePathSet, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsDrive(FString InPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsDrive, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool HasProjectPersistentDownloadDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __HasProjectPersistentDownloadDir, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static TArray<FString> GetToolTipLocalizationPaths()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetToolTipLocalizationPaths, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public static TArray<FString> GetRestrictedFolderNames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetRestrictedFolderNames, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public static FString GetRelativePathToRoot()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetRelativePathToRoot, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static TArray<FString> GetPropertyNameLocalizationPaths()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetPropertyNameLocalizationPaths, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Project file path.
		/// </returns>
		public static FString GetProjectFilePath()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetProjectFilePath, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString GetPath(FString InPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPath, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString GetInvalidFileSystemChars()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetInvalidFileSystemChars, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static TArray<FString> GetGameLocalizationPaths()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetGameLocalizationPaths, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		/// <param name="bIncludeDot">
		/// if true, includes the leading dot in the result
		/// </param>
		/// <returns>
		/// the extension of this filename, or an empty string if the filename doesn't have an extension.
		/// </returns>
		public static FString GetExtension(FString InPath, bool bIncludeDot = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIncludeDot;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetExtension, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static TArray<FString> GetEngineLocalizationPaths()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetEngineLocalizationPaths, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public static TArray<FString> GetEditorLocalizationPaths()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetEditorLocalizationPaths, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public static FString GetCleanFilename(FString InPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetCleanFilename, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString GetBaseFilename(FString InPath, bool bRemovePath = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bRemovePath;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetBaseFilename, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// config directory
		/// </returns>
		public static FString GeneratedConfigDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GeneratedConfigDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString GameUserDeveloperDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GameUserDeveloperDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString GameSourceDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GameSourceDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString GameDevelopersDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GameDevelopersDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// saved directory
		/// </returns>
		public static FString GameAgnosticSavedDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GameAgnosticSavedDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static bool FileExists(FString InPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __FileExists, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FString FeaturePackDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __FeaturePackDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Plugins directory.
		/// </returns>
		public static FString EnterprisePluginsDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __EnterprisePluginsDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// FeaturePack directory.
		/// </returns>
		public static FString EnterpriseFeaturePackDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __EnterpriseFeaturePackDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// enterprise directory
		/// </returns>
		public static FString EnterpriseDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __EnterpriseDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// root user directory
		/// </returns>
		public static FString EngineVersionAgnosticUserDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __EngineVersionAgnosticUserDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// root user directory
		/// </returns>
		public static FString EngineUserDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __EngineUserDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString EngineSourceDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __EngineSourceDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Saved directory.
		/// </returns>
		public static FString EngineSavedDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __EngineSavedDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Plugins directory.
		/// </returns>
		public static FString EnginePluginsDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __EnginePluginsDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// content directory
		/// </returns>
		public static FString EngineIntermediateDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __EngineIntermediateDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// engine directory
		/// </returns>
		public static FString EngineDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __EngineDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// engine content directory
		/// </returns>
		public static FString EngineContentDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __EngineContentDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// root config directory
		/// </returns>
		public static FString EngineConfigDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __EngineConfigDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static bool DirectoryExists(FString InPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DirectoryExists, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FString DiffDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __DiffDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="Path">
		/// The file pathname.
		/// </param>
		/// <param name="Prefix">
		/// The file prefix.
		/// </param>
		/// <param name="Extension">
		/// File extension ('.' required).
		/// </param>
		public static FString CreateTempFilename(FString Path, FString Prefix = null, FString Extension = null)
		{
			unsafe
			{
				Prefix ??= new FString("");

				Extension ??= new FString(".tmp");

				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Path?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Prefix?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Extension?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateTempFilename, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="InSandboxName">
		/// The name of the sandbox.
		/// </param>
		public static FString ConvertToSandboxPath(FString InPath, FString InSandboxName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSandboxName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertToSandboxPath, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString ConvertRelativePathToFull(FString InPath, FString InBasePath = null)
		{
			unsafe
			{
				InBasePath ??= new FString("");

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InBasePath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertRelativePathToFull, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="InSandboxName">
		/// The name of the sandbox.
		/// </param>
		public static FString ConvertFromSandboxPath(FString InPath, FString InSandboxName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSandboxName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertFromSandboxPath, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString Combine(TArray<FString> InPaths)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPaths?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Combine, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static bool CollapseRelativeDirectories(FString InPath, ref FString OutPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPath?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __CollapseRelativeDirectories, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutPath = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FString CloudDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __CloudDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString ChangeExtension(FString InPath, FString InNewExtension)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InNewExtension?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ChangeExtension, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// screenshot directory
		/// </returns>
		public static FString BugItDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __BugItDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString AutomationTransientDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __AutomationTransientDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString AutomationLogDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __AutomationLogDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString AutomationDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __AutomationDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		private static uint __VideoCaptureDir = 0;

		private static uint __ValidatePath = 0;

		private static uint __Split = 0;

		private static uint __SourceConfigDir = 0;

		private static uint __ShouldSaveToUserDir = 0;

		private static uint __ShaderWorkingDir = 0;

		private static uint __SetProjectFilePath = 0;

		private static uint __SetExtension = 0;

		private static uint __ScreenShotDir = 0;

		private static uint __SandboxesDir = 0;

		private static uint __RootDir = 0;

		private static uint __RemoveDuplicateSlashes = 0;

		private static uint __ProjectUserDir = 0;

		private static uint __ProjectSavedDir = 0;

		private static uint __ProjectPluginsDir = 0;

		private static uint __ProjectPersistentDownloadDir = 0;

		private static uint __ProjectModsDir = 0;

		private static uint __ProjectLogDir = 0;

		private static uint __ProjectIntermediateDir = 0;

		private static uint __ProjectDir = 0;

		private static uint __ProjectContentDir = 0;

		private static uint __ProjectConfigDir = 0;

		private static uint __ProfilingDir = 0;

		private static uint __NormalizeFilename = 0;

		private static uint __NormalizeDirectoryName = 0;

		private static uint __MakeValidFileName = 0;

		private static uint __MakeStandardFilename = 0;

		private static uint __MakePlatformFilename = 0;

		private static uint __MakePathRelativeTo = 0;

		private static uint __LaunchDir = 0;

		private static uint __IsSamePath = 0;

		private static uint __IsRestrictedPath = 0;

		private static uint __IsRelative = 0;

		private static uint __IsProjectFilePathSet = 0;

		private static uint __IsDrive = 0;

		private static uint __HasProjectPersistentDownloadDir = 0;

		private static uint __GetToolTipLocalizationPaths = 0;

		private static uint __GetRestrictedFolderNames = 0;

		private static uint __GetRelativePathToRoot = 0;

		private static uint __GetPropertyNameLocalizationPaths = 0;

		private static uint __GetProjectFilePath = 0;

		private static uint __GetPath = 0;

		private static uint __GetInvalidFileSystemChars = 0;

		private static uint __GetGameLocalizationPaths = 0;

		private static uint __GetExtension = 0;

		private static uint __GetEngineLocalizationPaths = 0;

		private static uint __GetEditorLocalizationPaths = 0;

		private static uint __GetCleanFilename = 0;

		private static uint __GetBaseFilename = 0;

		private static uint __GeneratedConfigDir = 0;

		private static uint __GameUserDeveloperDir = 0;

		private static uint __GameSourceDir = 0;

		private static uint __GameDevelopersDir = 0;

		private static uint __GameAgnosticSavedDir = 0;

		private static uint __FileExists = 0;

		private static uint __FeaturePackDir = 0;

		private static uint __EnterprisePluginsDir = 0;

		private static uint __EnterpriseFeaturePackDir = 0;

		private static uint __EnterpriseDir = 0;

		private static uint __EngineVersionAgnosticUserDir = 0;

		private static uint __EngineUserDir = 0;

		private static uint __EngineSourceDir = 0;

		private static uint __EngineSavedDir = 0;

		private static uint __EnginePluginsDir = 0;

		private static uint __EngineIntermediateDir = 0;

		private static uint __EngineDir = 0;

		private static uint __EngineContentDir = 0;

		private static uint __EngineConfigDir = 0;

		private static uint __DirectoryExists = 0;

		private static uint __DiffDir = 0;

		private static uint __CreateTempFilename = 0;

		private static uint __ConvertToSandboxPath = 0;

		private static uint __ConvertRelativePathToFull = 0;

		private static uint __ConvertFromSandboxPath = 0;

		private static uint __Combine = 0;

		private static uint __CollapseRelativeDirectories = 0;

		private static uint __CloudDir = 0;

		private static uint __ChangeExtension = 0;

		private static uint __BugItDir = 0;

		private static uint __AutomationTransientDir = 0;

		private static uint __AutomationLogDir = 0;

		private static uint __AutomationDir = 0;
	}
}