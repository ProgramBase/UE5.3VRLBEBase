using Script.CoreUObject;

namespace Script.AudioMixer
{
	[PathName("/Script/AudioMixer.ESourceManagerRenderThreadPhase")]
	public enum ESourceManagerRenderThreadPhase : long
	{
		Begin = 0,
		PumpMpscCmds = 1,
		PumpCmds = 2,
		ProcessModulators = 3,
		UpdatePendingReleaseData = 4,
		GenerateSrcAudio_WithBusses = 5,
		ComputeBusses = 6,
		GenerateSrcAudio_WithoutBusses = 7,
		UpdateBusses = 8,
		SpatialInterface_OnAllSourcesProcessed = 9,
		SourceDataOverride_OnAllSourcesProcessed = 10,
		UpdateGameThreadCopies = 11,
		Finished = 12,
	}
}