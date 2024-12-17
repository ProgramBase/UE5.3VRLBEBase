using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.AxisPositionGizmoBuilder")]
	public partial class UAxisPositionGizmoBuilder : UInteractiveGizmoBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.AxisPositionGizmoBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}