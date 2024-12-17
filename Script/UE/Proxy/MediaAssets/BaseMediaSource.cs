using Script.CoreUObject;
using Script.Library;

namespace Script.MediaAssets
{
	[PathName("/Script/MediaAssets.BaseMediaSource")]
	public partial class UBaseMediaSource : UMediaSource, IStaticClass
	{
		public TMap<FString, FName> PlatformPlayerNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlatformPlayerNames, __ReturnBuffer);

					return *(TMap<FString, FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlatformPlayerNames, __InBuffer);
				}
			}
		}

		public FName PlayerName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerName, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MediaAssets.BaseMediaSource");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PlatformPlayerNames = 0;

		private static uint __PlayerName = 0;
	}
}