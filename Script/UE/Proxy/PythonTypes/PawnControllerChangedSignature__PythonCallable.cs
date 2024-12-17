﻿using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/PawnControllerChangedSignature__PythonCallable.PawnControllerChangedSignature__PythonCallable")]
	public partial class PawnControllerChangedSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/PawnControllerChangedSignature__PythonCallable.PawnControllerChangedSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}