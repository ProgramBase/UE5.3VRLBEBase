using Script.CoreUObject;

namespace Script.Sequencer
{
	[PathName("/Script/Sequencer.ESequencerSpawnPosition")]
	public enum ESequencerSpawnPosition : byte
	{
		SSP_Origin = 0,
		SSP_PlaceInFrontOfCamera = 1,
	}
}