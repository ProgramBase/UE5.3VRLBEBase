using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayTagsEditor
{
	[PathName("/Script/GameplayTagsEditor.GameplayTagsK2Node_MultiCompareGameplayTagContainerSingleTags")]
	public partial class UGameplayTagsK2Node_MultiCompareGameplayTagContainerSingleTags : UGameplayTagsK2Node_MultiCompareBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayTagsEditor.GameplayTagsK2Node_MultiCompareGameplayTagContainerSingleTags");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}