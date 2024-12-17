using Script.CoreUObject;
using Script.Library;
using Script.WebBrowser;

namespace Script.Bridge
{
	[PathName("/Script/Bridge.BrowserBinding")]
	public partial class UBrowserBinding : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Bridge.BrowserBinding");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void StartNodeProcess()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __StartNodeProcess);
			}
		}

		public virtual void ShowLoginDialog(FString LoginUrl, FString ResponseCodeUrl)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = LoginUrl?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ResponseCodeUrl?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ShowLoginDialog, __InBuffer);
			}
		}

		public virtual void ShowDialog(FString Type, FString Url)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Type?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Url?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ShowDialog, __InBuffer);
			}
		}

		public virtual void SendSuccess(FString Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SendSuccess, __InBuffer);
			}
		}

		public virtual void SendFailure(FString Message)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Message?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SendFailure, __InBuffer);
			}
		}

		public virtual void SaveAuthToken(FString Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SaveAuthToken, __InBuffer);
			}
		}

		public virtual void RestartNodeProcess()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RestartNodeProcess);
			}
		}

		public virtual void OpenMegascansPluginSettings()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OpenMegascansPluginSettings);
			}
		}

		public virtual void OpenExternalUrl(FString Url)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Url?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OpenExternalUrl, __InBuffer);
			}
		}

		public virtual void OnExitCallback(FWebJSFunction OnExitJSCallback)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OnExitJSCallback?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnExitCallback, __InBuffer);
			}
		}

		public virtual void OnDroppedCallback(FWebJSFunction OnDroppedJSCallback)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OnDroppedJSCallback?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnDroppedCallback, __InBuffer);
			}
		}

		public virtual void OnDropDiscardedCallback(FWebJSFunction OnDropDiscardedJSCallback)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OnDropDiscardedJSCallback?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnDropDiscardedCallback, __InBuffer);
			}
		}

		public virtual void OnBulkExportMetahumansCallback(FWebJSFunction OnBulkExportMetahumansJSCallback)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OnBulkExportMetahumansJSCallback?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnBulkExportMetahumansCallback, __InBuffer);
			}
		}

		public virtual void Logout()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Logout);
			}
		}

		public virtual FString GetProjectPath()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetProjectPath, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual FString GetAuthToken()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAuthToken, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual void ExportDataToMSPlugin(FString Data)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Data?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ExportDataToMSPlugin, __InBuffer);
			}
		}

		public virtual void DragStarted(TArray<FString> ImageUrl, TArray<FString> IDs, TArray<FString> Types)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = ImageUrl?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = IDs?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Types?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DragStarted, __InBuffer);
			}
		}

		public virtual void DialogSuccessCallback(FWebJSFunction DialogJSCallback)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DialogJSCallback?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DialogSuccessCallback, __InBuffer);
			}
		}

		public virtual void DialogFailCallback(FWebJSFunction DialogJSCallback)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DialogJSCallback?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DialogFailCallback, __InBuffer);
			}
		}

		private static uint __StartNodeProcess = 0;

		private static uint __ShowLoginDialog = 0;

		private static uint __ShowDialog = 0;

		private static uint __SendSuccess = 0;

		private static uint __SendFailure = 0;

		private static uint __SaveAuthToken = 0;

		private static uint __RestartNodeProcess = 0;

		private static uint __OpenMegascansPluginSettings = 0;

		private static uint __OpenExternalUrl = 0;

		private static uint __OnExitCallback = 0;

		private static uint __OnDroppedCallback = 0;

		private static uint __OnDropDiscardedCallback = 0;

		private static uint __OnBulkExportMetahumansCallback = 0;

		private static uint __Logout = 0;

		private static uint __GetProjectPath = 0;

		private static uint __GetAuthToken = 0;

		private static uint __ExportDataToMSPlugin = 0;

		private static uint __DragStarted = 0;

		private static uint __DialogSuccessCallback = 0;

		private static uint __DialogFailCallback = 0;
	}
}