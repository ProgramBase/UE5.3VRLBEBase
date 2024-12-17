using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AnimationModifiers
{
	[PathName("/Script/AnimationModifiers.AnimationModifiersAssetUserData")]
	public partial class UAnimationModifiersAssetUserData : UAssetUserData, IStaticClass
	{
		public TArray<UAnimationModifier> AnimationModifierInstances
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimationModifierInstances, __ReturnBuffer);

					return *(TArray<UAnimationModifier>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimationModifierInstances, __InBuffer);
				}
			}
		}

		public TMap<FSoftObjectPath, UAnimationModifier> AppliedModifiers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AppliedModifiers, __ReturnBuffer);

					return *(TMap<FSoftObjectPath, UAnimationModifier>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AppliedModifiers, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimationModifiers.AnimationModifiersAssetUserData");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __AnimationModifierInstances = 0;

		private static uint __AppliedModifiers = 0;
	}
}