﻿using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnNiagaraSystemFinished__PythonCallable.OnNiagaraSystemFinished__PythonCallable")]
	public partial class OnNiagaraSystemFinished__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnNiagaraSystemFinished__PythonCallable.OnNiagaraSystemFinished__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}