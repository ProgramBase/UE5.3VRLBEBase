using Script.CoreUObject;
using Script.Library;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.UniformScaleGizmoHandleGroup")]
	public partial class UUniformScaleGizmoHandleGroup : UGizmoHandleGroup, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ViewportInteraction.UniformScaleGizmoHandleGroup");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}