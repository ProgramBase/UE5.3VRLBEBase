namespace Script.CoreUObject
{
	public enum ESpawnActorNameMode : byte
	{
		Required_Fatal = 0,
		Required_ErrorAndReturnNull = 1,
		Required_ReturnNull = 2,
		Requested = 3
	}
}