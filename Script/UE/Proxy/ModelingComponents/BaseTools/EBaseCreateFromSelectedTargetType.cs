using Script.CoreUObject;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.EBaseCreateFromSelectedTargetType")]
	public enum EBaseCreateFromSelectedTargetType : int
	{
		NewObject = 0,
		FirstInputObject = 1,
		LastInputObject = 2,
	}
}