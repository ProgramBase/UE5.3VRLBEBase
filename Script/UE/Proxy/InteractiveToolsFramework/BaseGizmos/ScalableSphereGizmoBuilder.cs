using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.ScalableSphereGizmoBuilder")]
	public partial class UScalableSphereGizmoBuilder : UInteractiveGizmoBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.ScalableSphereGizmoBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}