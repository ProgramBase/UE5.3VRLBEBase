﻿using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/Widget_GenerateWidgetForObject__PythonCallable.Widget_GenerateWidgetForObject__PythonCallable")]
	public partial class Widget_GenerateWidgetForObject__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/Widget_GenerateWidgetForObject__PythonCallable.Widget_GenerateWidgetForObject__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}