using Script.CoreUObject;
using Script.Library;

namespace Script.AnimationSharing
{
	[PathName("/Script/AnimationSharing.AnimationSharingSetup")]
	public partial class UAnimationSharingSetup : UObject, IStaticClass
	{
		public TArray<FPerSkeletonAnimationSharingSetup> SkeletonSetups
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SkeletonSetups, __ReturnBuffer);

					return *(TArray<FPerSkeletonAnimationSharingSetup>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SkeletonSetups, __InBuffer);
				}
			}
		}

		public FAnimationSharingScalability ScalabilitySettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ScalabilitySettings, __ReturnBuffer);

					return *(FAnimationSharingScalability*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ScalabilitySettings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimationSharing.AnimationSharingSetup");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SkeletonSetups = 0;

		private static uint __ScalabilitySettings = 0;
	}
}