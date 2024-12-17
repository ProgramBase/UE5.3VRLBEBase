using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayTags
{
	[PathName("/Script/GameplayTags.EditableGameplayTagQueryExpression_NoTagsMatch")]
	public partial class UEditableGameplayTagQueryExpression_NoTagsMatch : UEditableGameplayTagQueryExpression, IStaticClass
	{
		public FGameplayTagContainer Tags
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Tags, __ReturnBuffer);

					return *(FGameplayTagContainer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Tags, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayTags.EditableGameplayTagQueryExpression_NoTagsMatch");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Tags = 0;
	}
}