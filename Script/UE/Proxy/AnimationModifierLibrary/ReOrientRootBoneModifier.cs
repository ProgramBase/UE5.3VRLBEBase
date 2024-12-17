using Script.CoreUObject;
using Script.AnimationModifiers;
using Script.Library;

namespace Script.AnimationModifierLibrary
{
	[PathName("/Script/AnimationModifierLibrary.ReOrientRootBoneModifier")]
	public partial class UReOrientRootBoneModifier : UAnimationModifier, IStaticClass
	{
		public FRotator Rotator
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Rotator, __ReturnBuffer);

					return *(FRotator*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Rotator, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimationModifierLibrary.ReOrientRootBoneModifier");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Rotator = 0;
	}
}