using Script.CoreUObject;
using Script.Library;

namespace Script.AnimationEditor
{
	[PathName("/Script/AnimationEditor.AnimationToolMenuContext")]
	public partial class UAnimationToolMenuContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimationEditor.AnimationToolMenuContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}