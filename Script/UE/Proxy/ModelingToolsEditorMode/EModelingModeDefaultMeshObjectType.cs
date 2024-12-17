using Script.CoreUObject;

namespace Script.ModelingToolsEditorMode
{
	[PathName("/Script/ModelingToolsEditorMode.EModelingModeDefaultMeshObjectType")]
	public enum EModelingModeDefaultMeshObjectType : int
	{
		StaticMeshAsset = 0,
		VolumeActor = 1,
		DynamicMeshActor = 2,
	}
}