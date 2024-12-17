﻿using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherCore
{
	[PathName("/Script/HotPatcherCore.ReleaseProxy")]
	public partial class UReleaseProxy : UHotPatcherProxyBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/HotPatcherCore.ReleaseProxy");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}