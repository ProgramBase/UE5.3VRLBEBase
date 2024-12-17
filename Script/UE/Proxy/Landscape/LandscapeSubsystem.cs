﻿using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.LandscapeSubsystem")]
	public partial class ULandscapeSubsystem : UTickableWorldSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Landscape.LandscapeSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}