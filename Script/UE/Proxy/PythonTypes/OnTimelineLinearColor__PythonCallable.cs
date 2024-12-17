﻿using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnTimelineLinearColor__PythonCallable.OnTimelineLinearColor__PythonCallable")]
	public partial class OnTimelineLinearColor__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnTimelineLinearColor__PythonCallable.OnTimelineLinearColor__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}