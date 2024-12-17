using Script.CoreUObject;

namespace Script.ConfigEditor
{
	[PathName("/Script/ConfigEditor.EConfigFileSourceControlStatus")]
	public enum EConfigFileSourceControlStatus : long
	{
		CFSCS_Unknown = 0,
		CFSCS_Writable = 1,
		CFSCS_Locked = 2,
	}
}