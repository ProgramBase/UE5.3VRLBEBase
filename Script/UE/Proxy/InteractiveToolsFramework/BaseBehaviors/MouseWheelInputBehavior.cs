using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.MouseWheelInputBehavior")]
	public partial class UMouseWheelInputBehavior : UAnyButtonInputBehavior, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.MouseWheelInputBehavior");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}