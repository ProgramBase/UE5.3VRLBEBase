﻿using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ActorFactoryExponentialHeightFog")]
	public partial class UActorFactoryExponentialHeightFog : UActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ActorFactoryExponentialHeightFog");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}