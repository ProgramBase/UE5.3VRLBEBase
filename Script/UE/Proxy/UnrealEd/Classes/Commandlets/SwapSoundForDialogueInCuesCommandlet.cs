﻿using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.SwapSoundForDialogueInCuesCommandlet")]
	public partial class USwapSoundForDialogueInCuesCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.SwapSoundForDialogueInCuesCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}