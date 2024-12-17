using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.CollectSurfacePathMechanic")]
	public partial class UCollectSurfacePathMechanic : UInteractionMechanic, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.CollectSurfacePathMechanic");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}