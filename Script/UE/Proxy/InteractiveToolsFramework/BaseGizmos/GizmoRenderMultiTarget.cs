using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.GizmoRenderMultiTarget")]
	public partial class UGizmoRenderMultiTarget : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.GizmoRenderMultiTarget");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/InteractiveToolsFramework.GizmoRenderMultiTarget")]
	public interface IGizmoRenderMultiTarget : IInterface
	{
		 void UpdateVisibilityState(bool bVisible, uint InPartIdentifier);
	}
}