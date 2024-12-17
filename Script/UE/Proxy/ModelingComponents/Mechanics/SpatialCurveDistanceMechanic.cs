using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.SpatialCurveDistanceMechanic")]
	public partial class USpatialCurveDistanceMechanic : UInteractionMechanic, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.SpatialCurveDistanceMechanic");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}