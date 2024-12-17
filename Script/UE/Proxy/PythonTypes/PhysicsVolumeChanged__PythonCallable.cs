﻿using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/PhysicsVolumeChanged__PythonCallable.PhysicsVolumeChanged__PythonCallable")]
	public partial class PhysicsVolumeChanged__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/PhysicsVolumeChanged__PythonCallable.PhysicsVolumeChanged__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}