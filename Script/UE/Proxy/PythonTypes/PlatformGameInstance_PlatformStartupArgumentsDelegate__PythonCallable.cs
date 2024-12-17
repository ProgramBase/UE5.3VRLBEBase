﻿using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/PlatformGameInstance_PlatformStartupArgumentsDelegate__PythonCallable.PlatformGameInstance_PlatformStartupArgumentsDelegate__PythonCallable")]
	public partial class PlatformGameInstance_PlatformStartupArgumentsDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/PlatformGameInstance_PlatformStartupArgumentsDelegate__PythonCallable.PlatformGameInstance_PlatformStartupArgumentsDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}