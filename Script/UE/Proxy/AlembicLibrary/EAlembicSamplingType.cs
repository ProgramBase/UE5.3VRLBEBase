using Script.CoreUObject;

namespace Script.AlembicLibrary
{
	[PathName("/Script/AlembicLibrary.EAlembicSamplingType")]
	public enum EAlembicSamplingType : byte
	{
		PerFrame = 0,
		PerXFrames = 1,
		PerTimeStep = 2,
	}
}