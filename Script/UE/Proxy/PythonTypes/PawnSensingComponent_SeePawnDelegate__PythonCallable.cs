﻿using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/PawnSensingComponent_SeePawnDelegate__PythonCallable.PawnSensingComponent_SeePawnDelegate__PythonCallable")]
	public partial class PawnSensingComponent_SeePawnDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/PawnSensingComponent_SeePawnDelegate__PythonCallable.PawnSensingComponent_SeePawnDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}