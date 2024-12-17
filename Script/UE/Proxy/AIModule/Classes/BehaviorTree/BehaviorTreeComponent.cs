using Script.CoreUObject;
using Script.Library;
using Script.GameplayTags;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BehaviorTreeComponent")]
	public partial class UBehaviorTreeComponent : UBrainComponent, IStaticClass
	{
		public TArray<UBTNode> NodeInstances
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NodeInstances, __ReturnBuffer);

					return *(TArray<UBTNode>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NodeInstances, __InBuffer);
				}
			}
		}

		public UBehaviorTree DefaultBehaviorTreeAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultBehaviorTreeAsset, __ReturnBuffer);

					return *(UBehaviorTree*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultBehaviorTreeAsset, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BehaviorTreeComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetDynamicSubtree(FGameplayTag InjectTag, UBehaviorTree BehaviorAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InjectTag?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BehaviorAsset?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDynamicSubtree, __InBuffer);
			}
		}

		/// <returns>
		/// the cooldown tag end time, 0.0f if CooldownTag is not found */
		/// </returns>
		public virtual double GetTagCooldownEndTime(FGameplayTag CooldownTag)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = CooldownTag?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetTagCooldownEndTime, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public virtual void AddCooldownTagDuration(FGameplayTag CooldownTag, float CooldownDuration, bool bAddToExistingDuration)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = CooldownTag?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = CooldownDuration;

				*(bool*)(__InBuffer + 12) = bAddToExistingDuration;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddCooldownTagDuration, __InBuffer);
			}
		}

		private static uint __NodeInstances = 0;

		private static uint __DefaultBehaviorTreeAsset = 0;

		private static uint __SetDynamicSubtree = 0;

		private static uint __GetTagCooldownEndTime = 0;

		private static uint __AddCooldownTagDuration = 0;
	}
}