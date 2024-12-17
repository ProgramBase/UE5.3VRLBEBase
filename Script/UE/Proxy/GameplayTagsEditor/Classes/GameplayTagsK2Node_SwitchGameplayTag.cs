using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.GameplayTags;
using Script.Library;

namespace Script.GameplayTagsEditor
{
	[PathName("/Script/GameplayTagsEditor.GameplayTagsK2Node_SwitchGameplayTag")]
	public partial class UGameplayTagsK2Node_SwitchGameplayTag : UK2Node_Switch, IStaticClass
	{
		public TArray<FGameplayTag> PinTags
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PinTags, __ReturnBuffer);

					return *(TArray<FGameplayTag>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PinTags, __InBuffer);
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayTagsEditor.GameplayTagsK2Node_SwitchGameplayTag");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PinTags = 0;

		private static uint __PinNames = 0;
	}
}