﻿using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.ESetMaskConditionType")]
	public enum ESetMaskConditionType : byte
	{
		Field_Set_Always = 0,
		Field_Set_IFF_NOT_Interior = 1,
		Field_Set_IFF_NOT_Exterior = 2,
		Field_MaskCondition_Max = 3,
	}
}