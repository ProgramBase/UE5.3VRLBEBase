using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.K2Node_TransitionRuleGetter")]
	public partial class UK2Node_TransitionRuleGetter : UK2Node, IStaticClass
	{
		public ETransitionGetter GetterType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GetterType, __ReturnBuffer);

					return *(ETransitionGetter*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GetterType, __InBuffer);
				}
			}
		}

		public UAnimGraphNode_Base AssociatedAnimAssetPlayerNode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AssociatedAnimAssetPlayerNode, __ReturnBuffer);

					return *(UAnimGraphNode_Base*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AssociatedAnimAssetPlayerNode, __InBuffer);
				}
			}
		}

		public UAnimStateNode AssociatedStateNode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AssociatedStateNode, __ReturnBuffer);

					return *(UAnimStateNode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AssociatedStateNode, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.K2Node_TransitionRuleGetter");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __GetterType = 0;

		private static uint __AssociatedAnimAssetPlayerNode = 0;

		private static uint __AssociatedStateNode = 0;
	}
}