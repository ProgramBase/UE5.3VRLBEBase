using Script.CoreUObject;
using Script.Library;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.StretchGizmoHandleGroup")]
	public partial class UStretchGizmoHandleGroup : UGizmoHandleGroup, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ViewportInteraction.StretchGizmoHandleGroup");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}