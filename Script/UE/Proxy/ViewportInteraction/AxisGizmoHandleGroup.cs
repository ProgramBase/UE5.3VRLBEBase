using Script.CoreUObject;
using Script.Library;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.AxisGizmoHandleGroup")]
	public partial class UAxisGizmoHandleGroup : UGizmoHandleGroup, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ViewportInteraction.AxisGizmoHandleGroup");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}