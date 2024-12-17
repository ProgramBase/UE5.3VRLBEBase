using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.GizmoClickMultiTarget")]
	public partial class UGizmoClickMultiTarget : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.GizmoClickMultiTarget");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/InteractiveToolsFramework.GizmoClickMultiTarget")]
	public interface IGizmoClickMultiTarget : IInterface
	{
		 void UpdateInteractingState(bool bInteracting, uint InPartIdentifier);

		 void UpdateHoverState(bool bHovering, uint InPartIdentifier);

		 void UpdateHittableState(bool bHittable, uint InPartIdentifier);
	}
}