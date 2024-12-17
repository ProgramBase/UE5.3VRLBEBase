using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.GizmoClickTarget")]
	public partial class UGizmoClickTarget : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.GizmoClickTarget");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/InteractiveToolsFramework.GizmoClickTarget")]
	public interface IGizmoClickTarget : IInterface
	{
		 void UpdateInteractingState(bool bInteracting);

		 void UpdateHoverState(bool bHovering);
	}
}