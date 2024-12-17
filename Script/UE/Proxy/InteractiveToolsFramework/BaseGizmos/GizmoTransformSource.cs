using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.GizmoTransformSource")]
	public partial class UGizmoTransformSource : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.GizmoTransformSource");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/InteractiveToolsFramework.GizmoTransformSource")]
	public interface IGizmoTransformSource : IInterface
	{
		 void SetTransform(FTransform NewTransform);

		 FTransform GetTransform();
	}
}