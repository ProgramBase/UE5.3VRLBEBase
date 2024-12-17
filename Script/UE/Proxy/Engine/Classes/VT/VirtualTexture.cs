﻿using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.VirtualTexture")]
	public partial class UVirtualTexture : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.VirtualTexture");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}