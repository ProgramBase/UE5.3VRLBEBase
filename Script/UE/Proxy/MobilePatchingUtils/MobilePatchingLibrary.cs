using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.MobilePatchingUtils
{
	[PathName("/Script/MobilePatchingUtils.MobilePatchingLibrary")]
	public partial class UMobilePatchingLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MobilePatchingUtils.MobilePatchingLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="RemoteManifestURL">
		/// : URL from where manifest file can be downloaded. (http://my-server.com/awesomecontent.manifest)
		/// </param>
		/// <param name="CloudURL">
		/// :  URL from where content chunk data can be downloaded. (http://my-server.com/awesomecontent/clouddir)
		/// </param>
		/// <param name="InstallDirectory">
		/// : Relative directory to where downloaded content should be installed (MyContent/AwesomeContent)
		/// </param>
		/// <param name="OnSucceeded">
		/// : Callback on manifest download success. Will return object that represents remote content 
		/// </param>
		/// <param name="OnFailed">
		/// : Callback on manifest download fail. Will return error message text and error integer code
		/// </param>
		public static void RequestContent(FString RemoteManifestURL, FString CloudURL, FString InstallDirectory, FOnRequestContentSucceeded OnSucceeded, FOnRequestContentFailed OnFailed)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = RemoteManifestURL?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CloudURL?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InstallDirectory?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OnSucceeded?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = OnFailed?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RequestContent, __InBuffer);
			}
		}

		public static bool HasActiveWiFiConnection()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __HasActiveWiFiConnection, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static TArray<FString> GetSupportedPlatformNames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetSupportedPlatformNames, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public static UMobileInstalledContent GetInstalledContent(FString InstallDirectory)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InstallDirectory?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetInstalledContent, __InBuffer, __ReturnBuffer);

				return *(UMobileInstalledContent*)__ReturnBuffer;
			}
		}

		public static FString GetActiveDeviceProfileName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetActiveDeviceProfileName, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		private static uint __RequestContent = 0;

		private static uint __HasActiveWiFiConnection = 0;

		private static uint __GetSupportedPlatformNames = 0;

		private static uint __GetInstalledContent = 0;

		private static uint __GetActiveDeviceProfileName = 0;
	}
}