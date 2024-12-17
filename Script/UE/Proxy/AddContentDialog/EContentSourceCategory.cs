using Script.CoreUObject;

namespace Script.AddContentDialog
{
	[PathName("/Script/AddContentDialog.EContentSourceCategory")]
	public enum EContentSourceCategory : long
	{
		BlueprintFeature = 0,
		CodeFeature = 1,
		EnterpriseFeature = 2,
		Content = 3,
		EnterpriseContent = 4,
		SharedPack = 5,
		Unknown = 6,
	}
}