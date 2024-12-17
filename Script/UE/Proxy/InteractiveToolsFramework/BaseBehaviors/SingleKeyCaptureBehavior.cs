using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.SingleKeyCaptureBehavior")]
	public partial class USingleKeyCaptureBehavior : UInputBehavior, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.SingleKeyCaptureBehavior");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}