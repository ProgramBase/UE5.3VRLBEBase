using Script.CoreUObject;

namespace Script.Persona
{
	[PathName("/Script/Persona.EAnalysisSpace")]
	public enum EAnalysisSpace : byte
	{
		World = 0,
		Fixed = 1,
		Changing = 2,
		Moving = 3,
	}
}