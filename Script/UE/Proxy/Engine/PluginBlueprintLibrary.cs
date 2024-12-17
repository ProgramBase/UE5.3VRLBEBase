using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PluginBlueprintLibrary")]
	public partial class UPluginBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PluginBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="PluginName">
		/// - Name of the plugin
		/// </param>
		/// <returns>
		/// true if the named plugin is mounted, or false otherwise
		/// </returns>
		public static bool IsPluginMounted(FString PluginName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PluginName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsPluginMounted, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="PluginName">
		/// - Name of the plugin
		/// </param>
		/// <param name="OutVersionName">
		/// - Version name of the plugin, if found
		/// </param>
		/// <returns>
		/// true if the named plugin was found and the plugin's version
		/// name was stored in OutVersionName, or false otherwise
		/// </returns>
		public static bool GetPluginVersionName(FString PluginName, ref FString OutVersionName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PluginName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutVersionName?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetPluginVersionName, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutVersionName = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="PluginName">
		/// - Name of the plugin
		/// </param>
		/// <param name="OutVersion">
		/// - Version number of the plugin, if found
		/// </param>
		/// <returns>
		/// true if the named plugin was found and the plugin's version
		/// number was stored in OutVersion, or false otherwise
		/// </returns>
		public static bool GetPluginVersion(FString PluginName, ref int OutVersion)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = PluginName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = OutVersion;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetPluginVersion, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutVersion = *(int*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="ObjectPath">
		/// - Path to the object
		/// </param>
		/// <param name="OutPluginName">
		/// - Name of the plugin containing the object, if found
		/// </param>
		/// <returns>
		/// true if the object is contained within a plugin and the plugin
		/// name was stored in OutPluginName, or false otherwise
		/// </returns>
		public static bool GetPluginNameForObjectPath(FSoftObjectPath ObjectPath, ref FString OutPluginName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ObjectPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPluginName?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetPluginNameForObjectPath, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutPluginName = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="PluginName">
		/// - Name of the plugin
		/// </param>
		/// <param name="OutAssetPath">
		/// - Virtual root path for the plugin's assets, if found
		/// </param>
		/// <returns>
		/// true if the named plugin was found and the plugin's virtual
		/// root path was stored in OutAssetPath, or false otherwise
		/// </returns>
		public static bool GetPluginMountedAssetPath(FString PluginName, ref FString OutAssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PluginName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutAssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetPluginMountedAssetPath, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutAssetPath = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="PluginName">
		/// - Name of the plugin
		/// </param>
		/// <param name="OutVirtualPath">
		/// - Editor custom virtual path of the plugin, if found
		/// </param>
		/// <returns>
		/// true if the named plugin was found and the plugin's editor
		/// custom virtual path was stored in OutVirtualPath, or false otherwise
		/// </returns>
		public static bool GetPluginEditorCustomVirtualPath(FString PluginName, ref FString OutVirtualPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PluginName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutVirtualPath?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetPluginEditorCustomVirtualPath, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutVirtualPath = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="PluginName">
		/// - Name of the plugin
		/// </param>
		/// <param name="OutFilePath">
		/// - Filesystem path to the plugin's descriptor, if found
		/// </param>
		/// <returns>
		/// true if the named plugin was found and the plugin descriptor
		/// filesystem path was stored in OutFilePath, or false otherwise
		/// </returns>
		public static bool GetPluginDescriptorFilePath(FString PluginName, ref FString OutFilePath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PluginName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutFilePath?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetPluginDescriptorFilePath, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutFilePath = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="PluginName">
		/// - Name of the plugin
		/// </param>
		/// <param name="OutDescription">
		/// - Description of the plugin, if found
		/// </param>
		/// <returns>
		/// true if the named plugin was found and the plugin's description
		/// was stored in OutDescription, or false otherwise
		/// </returns>
		public static bool GetPluginDescription(FString PluginName, ref FString OutDescription)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PluginName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutDescription?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetPluginDescription, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutDescription = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="PluginName">
		/// - Name of the plugin
		/// </param>
		/// <param name="OutContentDir">
		/// - Filesystem path to the plugin's content directory, if found
		/// </param>
		/// <returns>
		/// true if the named plugin was found and the plugin content
		/// directory filesystem path was stored in OutContentDir, or false otherwise
		/// </returns>
		public static bool GetPluginContentDir(FString PluginName, ref FString OutContentDir)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PluginName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutContentDir?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetPluginContentDir, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutContentDir = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="PluginName">
		/// - Name of the plugin
		/// </param>
		/// <param name="OutBaseDir">
		/// - Filesystem path to the plugin's base directory, if found
		/// </param>
		/// <returns>
		/// true if the named plugin was found and the plugin base directory
		/// filesystem path was stored in OutBaseDir, or false otherwise
		/// </returns>
		public static bool GetPluginBaseDir(FString PluginName, ref FString OutBaseDir)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PluginName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutBaseDir?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetPluginBaseDir, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutBaseDir = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The names of all enabled plugins.
		/// </returns>
		public static TArray<FString> GetEnabledPluginNames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetEnabledPluginNames, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The additional project filesystem plugin search paths.
		/// </returns>
		public static TArray<FString> GetAdditionalProjectPluginSearchPaths()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetAdditionalProjectPluginSearchPaths, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The additional filesystem plugin search paths.
		/// </returns>
		public static TArray<FString> GetAdditionalPluginSearchPaths()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetAdditionalPluginSearchPaths, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		private static uint __IsPluginMounted = 0;

		private static uint __GetPluginVersionName = 0;

		private static uint __GetPluginVersion = 0;

		private static uint __GetPluginNameForObjectPath = 0;

		private static uint __GetPluginMountedAssetPath = 0;

		private static uint __GetPluginEditorCustomVirtualPath = 0;

		private static uint __GetPluginDescriptorFilePath = 0;

		private static uint __GetPluginDescription = 0;

		private static uint __GetPluginContentDir = 0;

		private static uint __GetPluginBaseDir = 0;

		private static uint __GetEnabledPluginNames = 0;

		private static uint __GetAdditionalProjectPluginSearchPaths = 0;

		private static uint __GetAdditionalPluginSearchPaths = 0;
	}
}