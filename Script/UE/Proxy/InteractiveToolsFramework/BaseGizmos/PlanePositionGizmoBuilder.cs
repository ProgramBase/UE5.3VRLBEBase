using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.PlanePositionGizmoBuilder")]
	public partial class UPlanePositionGizmoBuilder : UInteractiveGizmoBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.PlanePositionGizmoBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}