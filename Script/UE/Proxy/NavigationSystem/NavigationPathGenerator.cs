﻿using Script.CoreUObject;
using Script.Library;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.NavigationPathGenerator")]
	public partial class UNavigationPathGenerator : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NavigationSystem.NavigationPathGenerator");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/NavigationSystem.NavigationPathGenerator")]
	public interface INavigationPathGenerator : IInterface
	{
	}
}