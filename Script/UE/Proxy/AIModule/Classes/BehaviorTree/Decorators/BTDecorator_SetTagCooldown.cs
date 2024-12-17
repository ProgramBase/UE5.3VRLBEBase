using Script.CoreUObject;
using Script.GameplayTags;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BTDecorator_SetTagCooldown")]
	public partial class UBTDecorator_SetTagCooldown : UBTDecorator, IStaticClass
	{
		public FGameplayTag CooldownTag
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CooldownTag, __ReturnBuffer);

					return *(FGameplayTag*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CooldownTag, __InBuffer);
				}
			}
		}

		public float CooldownDuration
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CooldownDuration, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CooldownDuration, __InBuffer);
				}
			}
		}

		public bool bAddToExistingDuration
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAddToExistingDuration, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAddToExistingDuration, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BTDecorator_SetTagCooldown");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CooldownTag = 0;

		private static uint __CooldownDuration = 0;

		private static uint __bAddToExistingDuration = 0;
	}
}