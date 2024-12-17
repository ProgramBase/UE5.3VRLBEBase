using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.CombinedTransformGizmoBuilder")]
	public partial class UCombinedTransformGizmoBuilder : UInteractiveGizmoBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.CombinedTransformGizmoBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}