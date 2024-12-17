using Script.CoreUObject;
using Script.AnimationModifiers;
using Script.AnimationBlueprintLibrary;
using Script.Library;

namespace Script.AnimationModifierLibrary
{
	[PathName("/Script/AnimationModifierLibrary.CopyBonesModifier")]
	public partial class UCopyBonesModifier : UAnimationModifier, IStaticClass
	{
		public TArray<FBoneReferencePair> BonePairs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BonePairs, __ReturnBuffer);

					return *(TArray<FBoneReferencePair>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BonePairs, __InBuffer);
				}
			}
		}

		public EAnimPoseSpaces BonePoseSpace
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BonePoseSpace, __ReturnBuffer);

					return *(EAnimPoseSpaces*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BonePoseSpace, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimationModifierLibrary.CopyBonesModifier");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __BonePairs = 0;

		private static uint __BonePoseSpace = 0;
	}
}