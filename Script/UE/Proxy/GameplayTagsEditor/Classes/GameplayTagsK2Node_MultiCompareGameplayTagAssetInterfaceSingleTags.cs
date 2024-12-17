using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayTagsEditor
{
	[PathName("/Script/GameplayTagsEditor.GameplayTagsK2Node_MultiCompareGameplayTagAssetInterfaceSingleTags")]
	public partial class UGameplayTagsK2Node_MultiCompareGameplayTagAssetInterfaceSingleTags : UGameplayTagsK2Node_MultiCompareBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayTagsEditor.GameplayTagsK2Node_MultiCompareGameplayTagAssetInterfaceSingleTags");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}