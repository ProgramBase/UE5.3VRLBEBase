using Script.CoreUObject;
using Script.Library;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.LandscapeStreamingProxy")]
	public partial class ALandscapeStreamingProxy : ALandscapeProxy, IStaticClass
	{
		public TSoftObjectPtr<ALandscape> LandscapeActorRef
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LandscapeActorRef, __ReturnBuffer);

					return *(TSoftObjectPtr<ALandscape>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LandscapeActorRef, __InBuffer);
				}
			}
		}

		public TSet<FString> OverriddenSharedProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OverriddenSharedProperties, __ReturnBuffer);

					return *(TSet<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OverriddenSharedProperties, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Landscape.LandscapeStreamingProxy");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __LandscapeActorRef = 0;

		private static uint __OverriddenSharedProperties = 0;
	}
}