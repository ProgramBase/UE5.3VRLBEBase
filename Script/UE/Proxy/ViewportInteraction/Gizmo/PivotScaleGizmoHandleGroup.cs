using Script.CoreUObject;
using Script.Library;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.PivotScaleGizmoHandleGroup")]
	public partial class UPivotScaleGizmoHandleGroup : UAxisGizmoHandleGroup, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ViewportInteraction.PivotScaleGizmoHandleGroup");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}