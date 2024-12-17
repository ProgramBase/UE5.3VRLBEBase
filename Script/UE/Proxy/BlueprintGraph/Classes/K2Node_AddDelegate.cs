﻿using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_AddDelegate")]
	public partial class UK2Node_AddDelegate : UK2Node_BaseMCDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_AddDelegate");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}