using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraMipMapGeneration")]
	public enum ENiagaraMipMapGeneration : byte
	{
		Disabled = 0,
		PostStage = 1,
		PostSimulate = 2,
	}
}