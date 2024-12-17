using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EFBXSceneOptionsCreateHierarchyType")]
	public enum EFBXSceneOptionsCreateHierarchyType : byte
	{
		FBXSOCHT_CreateLevelActors = 0,
		FBXSOCHT_CreateActorComponents = 1,
		FBXSOCHT_CreateBlueprint = 2,
	}
}