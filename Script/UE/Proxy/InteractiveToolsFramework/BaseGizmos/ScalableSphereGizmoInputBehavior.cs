using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.ScalableSphereGizmoInputBehavior")]
	public partial class UScalableSphereGizmoInputBehavior : UAnyButtonInputBehavior, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.ScalableSphereGizmoInputBehavior");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}