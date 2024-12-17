using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.EditorScriptingUtilities
{
	[PathName("/Script/EditorScriptingUtilities.EditorDialogLibrary")]
	public partial class UEditorDialogLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorScriptingUtilities.EditorDialogLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Title">
		/// The title of the created dialog window
		/// </param>
		/// <param name="Message">
		/// Text of the message to show
		/// </param>
		/// <param name="InIniSettingName">
		/// The name of the entry in the INI where the state of the "Disable this warning" check box is stored
		/// </param>
		/// <param name="InIniSettingFileNameOverride">
		/// The name of the INI where the state of the InIniSettingName flag is stored (defaults to GEditorPerProjectIni)
		/// </param>
		/// <param name="bDefaultValue">
		/// If the warning is suppressed, the function will log and return DefaultValue
		/// </param>
		/// <returns>
		/// The result of the users decision, or DefaultValue if suppressed.
		/// </returns>
		public static bool ShowSuppressableWarningDialog(FText Title, FText Message, FString InIniSettingName, FString InIniSettingFileNameOverride = null, bool bDefaultValue = true)
		{
			unsafe
			{
				InIniSettingFileNameOverride ??= new FString("");

				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = Title?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Message?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InIniSettingName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InIniSettingFileNameOverride?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bDefaultValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ShowSuppressableWarningDialog, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Title">
		/// The title of the created dialog window
		/// </param>
		/// <param name="InOutObjects">
		/// Array of object instances which are supposed to be viewed
		/// </param>
		/// <param name="Options">
		/// Optional settings to customize the look of the details view
		/// </param>
		/// <returns>
		/// The result of the users decision, true=Ok, false=Cancel, or false if running in unattended mode.
		/// </returns>
		public static bool ShowObjectsDetailsView(FText Title, TArray<UObject> InOutObjects, FEditorDialogLibraryObjectDetailsViewOptions Options = null)
		{
			unsafe
			{
				Options ??= new FEditorDialogLibraryObjectDetailsViewOptions();

				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Title?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InOutObjects?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Options?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ShowObjectsDetailsView, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Title">
		/// The title of the created dialog window
		/// </param>
		/// <param name="InOutObject">
		/// Object instance of ClassOfObject which is supposed to be viewed
		/// </param>
		/// <param name="Options">
		/// Optional settings to customize the look of the details view
		/// </param>
		/// <returns>
		/// The result of the users decision, true=Ok, false=Cancel, or false if running in unattended mode.
		/// </returns>
		public static bool ShowObjectDetailsView(FText Title, UObject InOutObject, FEditorDialogLibraryObjectDetailsViewOptions Options = null)
		{
			unsafe
			{
				Options ??= new FEditorDialogLibraryObjectDetailsViewOptions();

				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Title?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InOutObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Options?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ShowObjectDetailsView, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Title">
		/// The title of the created dialog window
		/// </param>
		/// <param name="Message">
		/// Text of the message to show
		/// </param>
		/// <param name="MessageType">
		/// Specifies which buttons the dialog should have
		/// </param>
		/// <param name="DefaultValue">
		/// If the application is Unattended, the function will log and return DefaultValue
		/// </param>
		/// <param name="MessageCategory">
		/// The category of the message (affects the icon used)
		/// </param>
		/// <returns>
		/// The result of the users decision, or DefaultValue if running in unattended mode.
		/// </returns>
		public static EAppReturnType ShowMessage(FText Title, FText Message, EAppMsgType MessageType, EAppReturnType DefaultValue = EAppReturnType.No, EAppMsgCategory MessageCategory = EAppMsgCategory.Warning)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = Title?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Message?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)MessageType;

				*(byte*)(__InBuffer + 17) = (byte)DefaultValue;

				*(byte*)(__InBuffer + 18) = (byte)MessageCategory;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ShowMessage, __InBuffer, __ReturnBuffer);

				return *(EAppReturnType*)__ReturnBuffer;
			}
		}

		private static uint __ShowSuppressableWarningDialog = 0;

		private static uint __ShowObjectsDetailsView = 0;

		private static uint __ShowObjectDetailsView = 0;

		private static uint __ShowMessage = 0;
	}
}