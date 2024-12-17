using Script.CoreUObject;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.EModelingComponentsPlaneVisualizationMode")]
	public enum EModelingComponentsPlaneVisualizationMode : byte
	{
		SimpleGrid = 0,
		HierarchicalGrid = 1,
		FixedScreenAreaGrid = 2,
	}
}