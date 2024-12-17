﻿using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.DialogueVoiceFactory")]
	public partial class UDialogueVoiceFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioEditor.DialogueVoiceFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}