﻿using Script.CoreUObject;
using Script.AnimGraphRuntime;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimGraphNode_BlendListByBool")]
	public partial class UAnimGraphNode_BlendListByBool : UAnimGraphNode_BlendListBase, IStaticClass
	{
		public FAnimNode_BlendListByBool Node
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Node, __ReturnBuffer);

					return *(FAnimNode_BlendListByBool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Node, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimGraphNode_BlendListByBool");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Node = 0;
	}
}