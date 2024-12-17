﻿using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.BoolProperty")]
	public partial class UBoolProperty : UProperty, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.BoolProperty");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}