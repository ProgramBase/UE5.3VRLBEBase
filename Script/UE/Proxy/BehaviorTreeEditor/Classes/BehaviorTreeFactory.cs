﻿using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.BehaviorTreeEditor
{
	[PathName("/Script/BehaviorTreeEditor.BehaviorTreeFactory")]
	public partial class UBehaviorTreeFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BehaviorTreeEditor.BehaviorTreeFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}