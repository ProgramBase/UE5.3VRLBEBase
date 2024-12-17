﻿using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.SoundCueGraph")]
	public partial class USoundCueGraph : UEdGraph, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioEditor.SoundCueGraph");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}