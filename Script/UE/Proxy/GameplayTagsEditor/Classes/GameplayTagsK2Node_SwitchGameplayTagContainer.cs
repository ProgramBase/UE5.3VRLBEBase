using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.GameplayTags;
using Script.Library;

namespace Script.GameplayTagsEditor
{
	[PathName("/Script/GameplayTagsEditor.GameplayTagsK2Node_SwitchGameplayTagContainer")]
	public partial class UGameplayTagsK2Node_SwitchGameplayTagContainer : UK2Node_Switch, IStaticClass
	{
		public TArray<FGameplayTagContainer> PinContainers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PinContainers, __ReturnBuffer);

					return *(TArray<FGameplayTagContainer>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PinContainers, __InBuffer);
				}
			}
		}

		public TArray<FName> PinNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PinNames, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PinNames, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayTagsEditor.GameplayTagsK2Node_SwitchGameplayTagContainer");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PinContainers = 0;

		private static uint __PinNames = 0;
	}
}