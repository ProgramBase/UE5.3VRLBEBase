using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InGameAdManager")]
	public partial class UInGameAdManager : UPlatformInterfaceBase, IStaticClass
	{
		public bool bShouldPauseWhileAdOpen
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldPauseWhileAdOpen, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldPauseWhileAdOpen, __InBuffer);
				}
			}
		}

		public TArray<FOnUserClickedBanner> ClickedBannerDelegates
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ClickedBannerDelegates, __ReturnBuffer);

					return *(TArray<FOnUserClickedBanner>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ClickedBannerDelegates, __InBuffer);
				}
			}
		}

		public TArray<FOnUserClosedAdvertisement> ClosedAdDelegates
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ClosedAdDelegates, __ReturnBuffer);

					return *(TArray<FOnUserClosedAdvertisement>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ClosedAdDelegates, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.InGameAdManager");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bShouldPauseWhileAdOpen = 0;

		private static uint __ClickedBannerDelegates = 0;

		private static uint __ClosedAdDelegates = 0;
	}
}