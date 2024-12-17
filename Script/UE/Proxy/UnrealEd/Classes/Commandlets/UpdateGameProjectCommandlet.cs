﻿using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.UpdateGameProjectCommandlet")]
	public partial class UUpdateGameProjectCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.UpdateGameProjectCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}