using Script.CoreUObject;
using Script.Library;

namespace Script.AnimationBlueprintEditor
{
	[PathName("/Script/AnimationBlueprintEditor.AnimationBlueprintToolMenuContext")]
	public partial class UAnimationBlueprintToolMenuContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimationBlueprintEditor.AnimationBlueprintToolMenuContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}