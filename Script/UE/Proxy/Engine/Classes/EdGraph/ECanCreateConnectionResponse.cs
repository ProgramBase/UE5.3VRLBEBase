﻿using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ECanCreateConnectionResponse")]
	public enum ECanCreateConnectionResponse : long
	{
		CONNECT_RESPONSE_MAKE = 0,
		CONNECT_RESPONSE_DISALLOW = 1,
		CONNECT_RESPONSE_BREAK_OTHERS_A = 2,
		CONNECT_RESPONSE_BREAK_OTHERS_B = 3,
		CONNECT_RESPONSE_BREAK_OTHERS_AB = 4,
		CONNECT_RESPONSE_MAKE_WITH_CONVERSION_NODE = 5,
		CONNECT_RESPONSE_MAKE_WITH_PROMOTION = 6,
	}
}