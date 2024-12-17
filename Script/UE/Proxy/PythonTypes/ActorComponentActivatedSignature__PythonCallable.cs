﻿using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ActorComponentActivatedSignature__PythonCallable.ActorComponentActivatedSignature__PythonCallable")]
	public partial class ActorComponentActivatedSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ActorComponentActivatedSignature__PythonCallable.ActorComponentActivatedSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}