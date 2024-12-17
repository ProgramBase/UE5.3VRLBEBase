﻿using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/InputVectorAxisHandlerDynamicSignature__PythonCallable.InputVectorAxisHandlerDynamicSignature__PythonCallable")]
	public partial class InputVectorAxisHandlerDynamicSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/InputVectorAxisHandlerDynamicSignature__PythonCallable.InputVectorAxisHandlerDynamicSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}