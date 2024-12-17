﻿using Script.CoreUObject;
using Script.UMG;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilityEditableTextBox")]
	public partial class UEditorUtilityEditableTextBox : UEditableTextBox, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilityEditableTextBox");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}