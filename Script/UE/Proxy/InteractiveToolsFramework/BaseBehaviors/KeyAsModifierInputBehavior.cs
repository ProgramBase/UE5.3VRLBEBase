using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.KeyAsModifierInputBehavior")]
	public partial class UKeyAsModifierInputBehavior : UInputBehavior, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.KeyAsModifierInputBehavior");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}