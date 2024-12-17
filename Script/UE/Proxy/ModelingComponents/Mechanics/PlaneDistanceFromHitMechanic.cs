using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.PlaneDistanceFromHitMechanic")]
	public partial class UPlaneDistanceFromHitMechanic : UInteractionMechanic, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.PlaneDistanceFromHitMechanic");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}