﻿using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnSamplePlaybackProgress__PythonCallable.OnSamplePlaybackProgress__PythonCallable")]
	public partial class OnSamplePlaybackProgress__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnSamplePlaybackProgress__PythonCallable.OnSamplePlaybackProgress__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}