﻿using Script.CoreUObject;

namespace Script.Slate
{
	[PathName("/Script/Slate.EListItemAlignment")]
	public enum EListItemAlignment : byte
	{
		EvenlyDistributed = 0,
		EvenlySize = 1,
		EvenlyWide = 2,
		LeftAligned = 3,
		RightAligned = 4,
		CenterAligned = 5,
		Fill = 6,
	}
}