using Script.CoreUObject;
using Script.Library;

namespace Script.ContentBrowser
{
	[PathName("/Script/ContentBrowser.TextFilterKeyValueHandlers")]
	public partial class UTextFilterKeyValueHandlers : UObject, IStaticClass
	{
		public TArray<FTextFilterKeyValueHandlerEntry> TextFilterKeyValueHandlers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TextFilterKeyValueHandlers, __ReturnBuffer);

					return *(TArray<FTextFilterKeyValueHandlerEntry>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TextFilterKeyValueHandlers, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ContentBrowser.TextFilterKeyValueHandlers");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __TextFilterKeyValueHandlers = 0;
	}
}