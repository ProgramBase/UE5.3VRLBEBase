﻿using Script.CoreUObject;
using Script.Library;

namespace Script.BehaviorTreeEditor
{
	[PathName("/Script/BehaviorTreeEditor.BehaviorTreeGraphNode_SubtreeTask")]
	public partial class UBehaviorTreeGraphNode_SubtreeTask : UBehaviorTreeGraphNode_Task, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BehaviorTreeEditor.BehaviorTreeGraphNode_SubtreeTask");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}