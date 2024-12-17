﻿using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnTakeRecorderCancelled__PythonCallable.OnTakeRecorderCancelled__PythonCallable")]
	public partial class OnTakeRecorderCancelled__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnTakeRecorderCancelled__PythonCallable.OnTakeRecorderCancelled__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}