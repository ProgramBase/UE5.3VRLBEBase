using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.Library;

namespace Script.GameplayTagsEditor
{
	[PathName("/Script/GameplayTagsEditor.GameplayTagsK2Node_LiteralGameplayTag")]
	public partial class UGameplayTagsK2Node_LiteralGameplayTag : UK2Node, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayTagsEditor.GameplayTagsK2Node_LiteralGameplayTag");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}