using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.GizmoStateTarget")]
	public partial class UGizmoStateTarget : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.GizmoStateTarget");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/InteractiveToolsFramework.GizmoStateTarget")]
	public interface IGizmoStateTarget : IInterface
	{
		 void EndUpdate();

		 void BeginUpdate();
	}
}