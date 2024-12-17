using Script.CoreUObject;
using Script.Library;

namespace Script.ContentBrowser
{
	[PathName("/Script/ContentBrowser.TextFilterValueHandlers")]
	public partial class UTextFilterValueHandlers : UObject, IStaticClass
	{
		public TArray<TSoftClassPtr<UTextFilterValueHandler>> TextFilterValueHandlers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TextFilterValueHandlers, __ReturnBuffer);

					return *(TArray<TSoftClassPtr<UTextFilterValueHandler>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TextFilterValueHandlers, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ContentBrowser.TextFilterValueHandlers");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __TextFilterValueHandlers = 0;
	}
}