﻿using Script.CoreUObject;

namespace Script.OnlineSubsystem
{
	[PathName("/Script/OnlineSubsystem.EMPMatchOutcome")]
	public enum EMPMatchOutcome : byte
	{
		None = 0,
		Quit = 1,
		Won = 2,
		Lost = 3,
		Tied = 4,
		TimeExpired = 5,
		First = 6,
		Second = 7,
		Third = 8,
		Fourth = 9,
	}
}