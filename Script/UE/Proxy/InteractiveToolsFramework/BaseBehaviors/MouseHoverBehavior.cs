using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.MouseHoverBehavior")]
	public partial class UMouseHoverBehavior : UInputBehavior, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.MouseHoverBehavior");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}