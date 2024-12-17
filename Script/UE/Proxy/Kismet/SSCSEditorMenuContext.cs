﻿using Script.CoreUObject;
using Script.Library;

namespace Script.Kismet
{
	[PathName("/Script/Kismet.SSCSEditorMenuContext")]
	public partial class USSCSEditorMenuContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Kismet.SSCSEditorMenuContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}