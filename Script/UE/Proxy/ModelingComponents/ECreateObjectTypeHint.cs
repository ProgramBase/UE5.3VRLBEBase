using Script.CoreUObject;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.ECreateObjectTypeHint")]
	public enum ECreateObjectTypeHint : byte
	{
		Undefined = 0,
		StaticMesh = 1,
		Volume = 2,
		DynamicMeshActor = 3,
	}
}