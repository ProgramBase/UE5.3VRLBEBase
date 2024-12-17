using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SkeletalBodySetup")]
	public partial class USkeletalBodySetup : UBodySetup, IStaticClass
	{
		public FPhysicalAnimationProfile CurrentPhysicalAnimationProfile
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentPhysicalAnimationProfile, __ReturnBuffer);

					return *(FPhysicalAnimationProfile*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentPhysicalAnimationProfile, __InBuffer);
				}
			}
		}

		public bool bSkipScaleFromAnimation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSkipScaleFromAnimation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSkipScaleFromAnimation, __InBuffer);
				}
			}
		}

		public TArray<FPhysicalAnimationProfile> PhysicalAnimationData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PhysicalAnimationData, __ReturnBuffer);

					return *(TArray<FPhysicalAnimationProfile>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PhysicalAnimationData, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SkeletalBodySetup");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CurrentPhysicalAnimationProfile = 0;

		private static uint __bSkipScaleFromAnimation = 0;

		private static uint __PhysicalAnimationData = 0;
	}
}