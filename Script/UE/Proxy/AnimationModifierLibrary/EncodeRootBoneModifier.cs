using Script.CoreUObject;
using Script.AnimationModifiers;
using Script.Library;

namespace Script.AnimationModifierLibrary
{
	[PathName("/Script/AnimationModifierLibrary.EncodeRootBoneModifier")]
	public partial class UEncodeRootBoneModifier : UAnimationModifier, IStaticClass
	{
		public TArray<FEncodeRootBoneWeightedBone> WeightedBoneToComputeRootPosition
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WeightedBoneToComputeRootPosition, __ReturnBuffer);

					return *(TArray<FEncodeRootBoneWeightedBone>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WeightedBoneToComputeRootPosition, __InBuffer);
				}
			}
		}

		public TArray<FEncodeRootBoneWeightedBoneAxis> WeightedBoneToComputeRootOrientation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WeightedBoneToComputeRootOrientation, __ReturnBuffer);

					return *(TArray<FEncodeRootBoneWeightedBoneAxis>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WeightedBoneToComputeRootOrientation, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimationModifierLibrary.EncodeRootBoneModifier");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __WeightedBoneToComputeRootPosition = 0;

		private static uint __WeightedBoneToComputeRootOrientation = 0;
	}
}