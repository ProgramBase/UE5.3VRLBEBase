using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.LocalMouseHoverBehavior")]
	public partial class ULocalMouseHoverBehavior : UMouseHoverBehavior, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.LocalMouseHoverBehavior");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}