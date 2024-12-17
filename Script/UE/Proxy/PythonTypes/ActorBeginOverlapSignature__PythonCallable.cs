﻿using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ActorBeginOverlapSignature__PythonCallable.ActorBeginOverlapSignature__PythonCallable")]
	public partial class ActorBeginOverlapSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ActorBeginOverlapSignature__PythonCallable.ActorBeginOverlapSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}