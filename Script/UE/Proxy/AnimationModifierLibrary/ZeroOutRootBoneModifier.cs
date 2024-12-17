using Script.CoreUObject;
using Script.AnimationModifiers;
using Script.Library;

namespace Script.AnimationModifierLibrary
{
	[PathName("/Script/AnimationModifierLibrary.ZeroOutRootBoneModifier")]
	public partial class UZeroOutRootBoneModifier : UAnimationModifier, IStaticClass
	{
		public bool bClipStartFramesWithNoMotion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bClipStartFramesWithNoMotion, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bClipStartFramesWithNoMotion, __InBuffer);
				}
			}
		}

		public bool bClipEndFramesWithNoMotion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bClipEndFramesWithNoMotion, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bClipEndFramesWithNoMotion, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimationModifierLibrary.ZeroOutRootBoneModifier");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bClipStartFramesWithNoMotion = 0;

		private static uint __bClipEndFramesWithNoMotion = 0;
	}
}