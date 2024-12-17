using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EBeamTaperMethod")]
	public enum EBeamTaperMethod : byte
	{
		PEBTM_None = 0,
		PEBTM_Full = 1,
		PEBTM_Partial = 2,
	}
}