using Script.CoreUObject;

namespace Script.DetailCustomizations
{
	[PathName("/Script/DetailCustomizations.EMaterialImportMethod")]
	public enum EMaterialImportMethod : long
	{
		CreateNewMaterials = 0,
		CreateNewInstancedMaterials = 1,
		DoNotCreateMaterialString = 2,
	}
}