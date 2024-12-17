using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.UserListEntryLibrary")]
	public partial class UUserListEntryLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.UserListEntryLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="UserListEntry">
		/// Note: Visually not transmitted, but this defaults to "self". No need to hook up if calling internally.
		/// </param>
		public static bool IsListItemSelected(TScriptInterface<IUserListEntry> UserListEntry)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = UserListEntry?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsListItemSelected, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="UserListEntry">
		/// Note: Visually not transmitted, but this defaults to "self". No need to hook up if calling internally.
		/// </param>
		public static bool IsListItemExpanded(TScriptInterface<IUserListEntry> UserListEntry)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = UserListEntry?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsListItemExpanded, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="UserListEntry">
		/// Note: Visually not transmitted, but this defaults to "self". No need to hook up if calling internally.
		/// </param>
		public static UListViewBase GetOwningListView(TScriptInterface<IUserListEntry> UserListEntry)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = UserListEntry?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetOwningListView, __InBuffer, __ReturnBuffer);

				return *(UListViewBase*)__ReturnBuffer;
			}
		}

		private static uint __IsListItemSelected = 0;

		private static uint __IsListItemExpanded = 0;

		private static uint __GetOwningListView = 0;
	}
}