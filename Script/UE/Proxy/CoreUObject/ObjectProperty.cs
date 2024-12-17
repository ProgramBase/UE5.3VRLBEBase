﻿using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.ObjectProperty")]
	public partial class UObjectProperty : UObjectPropertyBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.ObjectProperty");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}