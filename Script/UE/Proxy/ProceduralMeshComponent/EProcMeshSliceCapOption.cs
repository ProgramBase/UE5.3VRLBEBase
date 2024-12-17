using Script.CoreUObject;

namespace Script.ProceduralMeshComponent
{
	[PathName("/Script/ProceduralMeshComponent.EProcMeshSliceCapOption")]
	public enum EProcMeshSliceCapOption : byte
	{
		NoCap = 0,
		CreateNewSectionForCap = 1,
		UseLastSectionForCap = 2,
	}
}