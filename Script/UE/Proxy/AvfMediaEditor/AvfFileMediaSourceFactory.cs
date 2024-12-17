﻿using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.AvfMediaEditor
{
	[PathName("/Script/AvfMediaEditor.AvfFileMediaSourceFactory")]
	public partial class UAvfFileMediaSourceFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AvfMediaEditor.AvfFileMediaSourceFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}