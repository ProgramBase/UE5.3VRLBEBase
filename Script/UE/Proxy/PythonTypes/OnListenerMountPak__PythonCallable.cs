﻿using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnListenerMountPak__PythonCallable.OnListenerMountPak__PythonCallable")]
	public partial class OnListenerMountPak__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnListenerMountPak__PythonCallable.OnListenerMountPak__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}