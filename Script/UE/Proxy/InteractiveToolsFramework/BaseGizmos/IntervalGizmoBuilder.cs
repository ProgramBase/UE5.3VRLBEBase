using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.IntervalGizmoBuilder")]
	public partial class UIntervalGizmoBuilder : UInteractiveGizmoBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.IntervalGizmoBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}