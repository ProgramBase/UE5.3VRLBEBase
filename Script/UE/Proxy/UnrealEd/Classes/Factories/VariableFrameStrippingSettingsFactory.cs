﻿using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.VariableFrameStrippingSettingsFactory")]
	public partial class UVariableFrameStrippingSettingsFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.VariableFrameStrippingSettingsFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}