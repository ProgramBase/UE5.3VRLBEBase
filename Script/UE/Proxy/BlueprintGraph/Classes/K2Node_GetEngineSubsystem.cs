﻿using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_GetEngineSubsystem")]
	public partial class UK2Node_GetEngineSubsystem : UK2Node_GetSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_GetEngineSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}