using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.TwitterIntegrationBase")]
	public partial class UTwitterIntegrationBase : UPlatformInterfaceBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.TwitterIntegrationBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="URL">
		/// The URL for the twitter request
		/// </param>
		/// <param name="KeysAndValues">
		/// The extra parameters to pass to the request (request specific). Separate keys and values: < "key1", "value1", "key2", "value2" >
		/// </param>
		/// <param name="Method">
		/// The method for this request (get, post, delete)
		/// </param>
		/// <param name="AccountIndex">
		/// A user index if an account is needed, or -1 if an account isn't needed for the request
		/// </param>
		/// <returns>
		/// true the request was sent off, and a TID_RequestComplete
		/// </returns>
		public virtual bool TwitterRequest(FString URL, TArray<FString> ParamKeysAndValues, ETwitterRequestMethod RequestMethod, int AccountIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = URL?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParamKeysAndValues?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)RequestMethod;

				*(int*)(__InBuffer + 17) = AccountIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __TwitterRequest, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InitialMessage">
		/// [optional] Initial message to show
		/// </param>
		/// <param name="URL">
		/// [optional] URL to attach to the tweet
		/// </param>
		/// <param name="Picture">
		/// [optional] Name of a picture (stored locally, platform subclass will do the searching for it) to add to the tweet
		/// </param>
		/// <returns>
		/// true if a UI was displayed for the user to interact with, and a TID_TweetUIComplete will be sent
		/// </returns>
		public virtual bool ShowTweetUI(FString InitialMessage, FString URL, FString Picture)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InitialMessage?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = URL?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Picture?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ShowTweetUI, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void Init()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Init);
			}
		}

		/// <returns>
		/// The number of accounts that were authorized
		/// </returns>
		public virtual int GetNumAccounts()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumAccounts, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// the display name of the given Twitter account
		/// </returns>
		public virtual FString GetAccountName(int AccountIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = AccountIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetAccountName, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if the user is allowed to use the Tweet UI
		/// </returns>
		public virtual bool CanShowTweetUI()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __CanShowTweetUI, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if the authorization process started, and TID_AuthorizeComplete delegates will be called
		/// </returns>
		public virtual bool AuthorizeAccounts()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __AuthorizeAccounts, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __TwitterRequest = 0;

		private static uint __ShowTweetUI = 0;

		private static uint __Init = 0;

		private static uint __GetNumAccounts = 0;

		private static uint __GetAccountName = 0;

		private static uint __CanShowTweetUI = 0;

		private static uint __AuthorizeAccounts = 0;
	}
}