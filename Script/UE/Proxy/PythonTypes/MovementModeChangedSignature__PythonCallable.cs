﻿using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/MovementModeChangedSignature__PythonCallable.MovementModeChangedSignature__PythonCallable")]
	public partial class MovementModeChangedSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/MovementModeChangedSignature__PythonCallable.MovementModeChangedSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}