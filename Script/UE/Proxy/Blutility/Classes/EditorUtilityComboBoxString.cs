﻿using Script.CoreUObject;
using Script.UMG;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilityComboBoxString")]
	public partial class UEditorUtilityComboBoxString : UComboBoxString, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilityComboBoxString");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}