using Script.CoreUObject;
using Script.Library;

namespace Script.MegascansPlugin
{
	[PathName("/Script/MegascansPlugin.MetaHumanProjectUtilitiesSettings")]
	public partial class UMetaHumanProjectUtilitiesSettings : UObject, IStaticClass
	{
		public FString VersionServiceBaseUrl
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VersionServiceBaseUrl, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VersionServiceBaseUrl, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MegascansPlugin.MetaHumanProjectUtilitiesSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __VersionServiceBaseUrl = 0;
	}
}