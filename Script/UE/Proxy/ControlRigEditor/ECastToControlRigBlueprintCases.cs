using Script.CoreUObject;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.ECastToControlRigBlueprintCases")]
	public enum ECastToControlRigBlueprintCases : byte
	{
		CastSucceeded = 0,
		CastFailed = 1,
	}
}