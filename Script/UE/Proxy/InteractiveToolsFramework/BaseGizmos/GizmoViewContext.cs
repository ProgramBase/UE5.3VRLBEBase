using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.GizmoViewContext")]
	public partial class UGizmoViewContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.GizmoViewContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}