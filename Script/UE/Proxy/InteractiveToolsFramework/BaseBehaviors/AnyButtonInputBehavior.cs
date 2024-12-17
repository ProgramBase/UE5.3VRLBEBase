using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.AnyButtonInputBehavior")]
	public partial class UAnyButtonInputBehavior : UInputBehavior, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.AnyButtonInputBehavior");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}