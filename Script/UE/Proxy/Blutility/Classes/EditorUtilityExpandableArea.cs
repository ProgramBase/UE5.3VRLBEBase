﻿using Script.CoreUObject;
using Script.UMG;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilityExpandableArea")]
	public partial class UEditorUtilityExpandableArea : UExpandableArea, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilityExpandableArea");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}