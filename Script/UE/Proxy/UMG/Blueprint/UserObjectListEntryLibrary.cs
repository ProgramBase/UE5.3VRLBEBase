using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.UserObjectListEntryLibrary")]
	public partial class UUserObjectListEntryLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.UserObjectListEntryLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="UserObjectListEntry">
		/// Note: Visually not transmitted, but this defaults to "self". No need to hook up if calling internally.
		/// </param>
		public static UObject GetListItemObject(TScriptInterface<IUserObjectListEntry> UserObjectListEntry)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = UserObjectListEntry?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetListItemObject, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		private static uint __GetListItemObject = 0;
	}
}