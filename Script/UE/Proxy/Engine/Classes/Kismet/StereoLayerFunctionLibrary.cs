using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.StereoLayerFunctionLibrary")]
	public partial class UStereoLayerFunctionLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.StereoLayerFunctionLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void ShowSplashScreen()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __ShowSplashScreen);
			}
		}

		/// <param name="Texture">
		/// (in) A texture to be used for the splash. B8R8G8A8 format.
		/// </param>
		/// <param name="Scale">
		/// (in) Scale multiplier of the splash screen.
		/// </param>
		/// <param name="Offset">
		/// (in) Position in UE Units to offset the Splash Screen by
		/// </param>
		/// <param name="ShowLoadingMovie">
		/// (in) Whether the splash screen presents loading movies.
		/// </param>
		public static void SetSplashScreen(UTexture Texture, FVector2D Scale = null, FVector Offset = null, bool bShowLoadingMovie = false, bool bShowOnSet = false)
		{
			unsafe
			{
				Scale ??= new FVector2D(1.000000, 1.000000);

				Offset ??= new FVector(0.000000, 0.000000, 0.000000);

				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = Texture?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Scale?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Offset?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bShowLoadingMovie;

				*(bool*)(__InBuffer + 25) = bShowOnSet;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetSplashScreen, __InBuffer);
			}
		}

		public static void HideSplashScreen()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __HideSplashScreen);
			}
		}

		public static void EnableAutoLoadingSplashScreen(bool InAutoShowEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = InAutoShowEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __EnableAutoLoadingSplashScreen, __InBuffer);
			}
		}

		private static uint __ShowSplashScreen = 0;

		private static uint __SetSplashScreen = 0;

		private static uint __HideSplashScreen = 0;

		private static uint __EnableAutoLoadingSplashScreen = 0;
	}
}