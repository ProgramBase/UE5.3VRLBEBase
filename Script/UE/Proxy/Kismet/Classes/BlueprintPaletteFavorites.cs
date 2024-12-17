using Script.CoreUObject;
using Script.Library;

namespace Script.Kismet
{
	[PathName("/Script/Kismet.BlueprintPaletteFavorites")]
	public partial class UBlueprintPaletteFavorites : UObject, IStaticClass
	{
		public TArray<FString> CustomFavorites
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CustomFavorites, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CustomFavorites, __InBuffer);
				}
			}
		}

		public TArray<FFavoritedBlueprintPaletteItem> CurrentFavorites
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentFavorites, __ReturnBuffer);

					return *(TArray<FFavoritedBlueprintPaletteItem>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentFavorites, __InBuffer);
				}
			}
		}

		public FString CurrentProfile
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentProfile, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentProfile, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Kismet.BlueprintPaletteFavorites");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CustomFavorites = 0;

		private static uint __CurrentFavorites = 0;

		private static uint __CurrentProfile = 0;
	}
}