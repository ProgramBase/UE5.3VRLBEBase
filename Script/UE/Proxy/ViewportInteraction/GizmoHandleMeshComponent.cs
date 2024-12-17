using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.GizmoHandleMeshComponent")]
	public partial class UGizmoHandleMeshComponent : UStaticMeshComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ViewportInteraction.GizmoHandleMeshComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}