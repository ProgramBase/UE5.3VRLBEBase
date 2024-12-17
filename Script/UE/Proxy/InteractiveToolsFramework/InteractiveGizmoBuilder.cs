using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.InteractiveGizmoBuilder")]
	public partial class UInteractiveGizmoBuilder : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.InteractiveGizmoBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}