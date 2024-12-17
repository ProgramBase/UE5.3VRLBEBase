﻿using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_EditorPropertyAccessBase")]
	public partial class UK2Node_EditorPropertyAccessBase : UK2Node_CallFunction, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_EditorPropertyAccessBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}