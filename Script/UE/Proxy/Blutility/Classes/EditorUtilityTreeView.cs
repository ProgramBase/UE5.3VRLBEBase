﻿using Script.CoreUObject;
using Script.UMG;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilityTreeView")]
	public partial class UEditorUtilityTreeView : UTreeView, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilityTreeView");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}