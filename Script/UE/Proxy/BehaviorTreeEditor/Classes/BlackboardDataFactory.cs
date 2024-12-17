﻿using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.BehaviorTreeEditor
{
	[PathName("/Script/BehaviorTreeEditor.BlackboardDataFactory")]
	public partial class UBlackboardDataFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BehaviorTreeEditor.BlackboardDataFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}