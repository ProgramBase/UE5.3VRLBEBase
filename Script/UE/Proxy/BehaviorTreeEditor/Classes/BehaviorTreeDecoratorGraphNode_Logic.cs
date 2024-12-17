using Script.CoreUObject;
using Script.Library;

namespace Script.BehaviorTreeEditor
{
	[PathName("/Script/BehaviorTreeEditor.BehaviorTreeDecoratorGraphNode_Logic")]
	public partial class UBehaviorTreeDecoratorGraphNode_Logic : UBehaviorTreeDecoratorGraphNode, IStaticClass
	{
		public EDecoratorLogicMode LogicMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LogicMode, __ReturnBuffer);

					return *(EDecoratorLogicMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LogicMode, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BehaviorTreeEditor.BehaviorTreeDecoratorGraphNode_Logic");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __LogicMode = 0;
	}
}