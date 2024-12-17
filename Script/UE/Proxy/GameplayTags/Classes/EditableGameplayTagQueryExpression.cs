using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayTags
{
	[PathName("/Script/GameplayTags.EditableGameplayTagQueryExpression")]
	public partial class UEditableGameplayTagQueryExpression : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayTags.EditableGameplayTagQueryExpression");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}