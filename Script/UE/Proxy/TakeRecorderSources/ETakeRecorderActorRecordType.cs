using Script.CoreUObject;

namespace Script.TakeRecorderSources
{
	[PathName("/Script/TakeRecorderSources.ETakeRecorderActorRecordType")]
	public enum ETakeRecorderActorRecordType : byte
	{
		Possessable = 0,
		Spawnable = 1,
		ProjectDefault = 2,
	}
}