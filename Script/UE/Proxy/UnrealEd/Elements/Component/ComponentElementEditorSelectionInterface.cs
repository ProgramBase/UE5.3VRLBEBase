﻿using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ComponentElementEditorSelectionInterface")]
	public partial class UComponentElementEditorSelectionInterface : UComponentElementSelectionInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ComponentElementEditorSelectionInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}