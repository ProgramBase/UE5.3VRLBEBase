using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.AnimationModifiers
{
	[PathName("/Script/AnimationModifiers.AnimationModifierSettings")]
	public partial class UAnimationModifierSettings : UDeveloperSettings, IStaticClass
	{
		public TArray<TSubclassOf<UAnimationModifier>> DefaultAnimationModifiers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultAnimationModifiers, __ReturnBuffer);

					return *(TArray<TSubclassOf<UAnimationModifier>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultAnimationModifiers, __InBuffer);
				}
			}
		}

		public bool bApplyAnimationModifiersOnImport
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bApplyAnimationModifiersOnImport, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bApplyAnimationModifiersOnImport, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimationModifiers.AnimationModifierSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DefaultAnimationModifiers = 0;

		private static uint __bApplyAnimationModifiersOnImport = 0;
	}
}