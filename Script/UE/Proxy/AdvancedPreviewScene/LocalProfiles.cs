using Script.CoreUObject;
using Script.Library;

namespace Script.AdvancedPreviewScene
{
	[PathName("/Script/AdvancedPreviewScene.LocalProfiles")]
	public partial class ULocalProfiles : UObject, IStaticClass
	{
		public TArray<FPreviewSceneProfile> Profiles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Profiles, __ReturnBuffer);

					return *(TArray<FPreviewSceneProfile>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Profiles, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AdvancedPreviewScene.LocalProfiles");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Profiles = 0;
	}
}