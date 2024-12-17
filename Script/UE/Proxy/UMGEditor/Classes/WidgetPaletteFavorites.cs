using Script.CoreUObject;
using Script.Library;

namespace Script.UMGEditor
{
	[PathName("/Script/UMGEditor.WidgetPaletteFavorites")]
	public partial class UWidgetPaletteFavorites : UObject, IStaticClass
	{
		public TArray<FString> Favorites
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Favorites, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Favorites, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMGEditor.WidgetPaletteFavorites");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Favorites = 0;
	}
}