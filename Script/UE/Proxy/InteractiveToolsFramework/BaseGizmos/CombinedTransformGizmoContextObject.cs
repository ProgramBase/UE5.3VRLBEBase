using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.CombinedTransformGizmoContextObject")]
	public partial class UCombinedTransformGizmoContextObject : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.CombinedTransformGizmoContextObject");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}