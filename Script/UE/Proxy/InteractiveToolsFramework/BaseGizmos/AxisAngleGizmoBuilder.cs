using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.AxisAngleGizmoBuilder")]
	public partial class UAxisAngleGizmoBuilder : UInteractiveGizmoBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.AxisAngleGizmoBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}