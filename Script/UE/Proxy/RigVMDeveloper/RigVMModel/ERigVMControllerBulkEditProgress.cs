using Script.CoreUObject;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.ERigVMControllerBulkEditProgress")]
	public enum ERigVMControllerBulkEditProgress : long
	{
		BeginLoad = 0,
		FinishedLoad = 1,
		BeginEdit = 2,
		FinishedEdit = 3,
		Max = 4,
	}
}