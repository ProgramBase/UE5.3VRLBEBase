using Script.CoreUObject;
using Script.GameplayTags;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BTTask_RunBehaviorDynamic")]
	public partial class UBTTask_RunBehaviorDynamic : UBTTaskNode, IStaticClass
	{
		public FGameplayTag InjectionTag
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InjectionTag, __ReturnBuffer);

					return *(FGameplayTag*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InjectionTag, __InBuffer);
				}
			}
		}

		public UBehaviorTree DefaultBehaviorAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultBehaviorAsset, __ReturnBuffer);

					return *(UBehaviorTree*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultBehaviorAsset, __InBuffer);
				}
			}
		}

		public UBehaviorTree BehaviorAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BehaviorAsset, __ReturnBuffer);

					return *(UBehaviorTree*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BehaviorAsset, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BTTask_RunBehaviorDynamic");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __InjectionTag = 0;

		private static uint __DefaultBehaviorAsset = 0;

		private static uint __BehaviorAsset = 0;
	}
}