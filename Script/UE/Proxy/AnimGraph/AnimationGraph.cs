using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimationGraph")]
	public partial class UAnimationGraph : UEdGraph, IStaticClass
	{
		public FAnimGraphBlendOptions BlendOptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BlendOptions, __ReturnBuffer);

					return *(FAnimGraphBlendOptions*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BlendOptions, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimationGraph");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void GetGraphNodesOfClass(TSubclassOf<UAnimGraphNode_Base> NodeClass, ref TArray<UAnimGraphNode_Base> GraphNodes, bool bIncludeChildClasses)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = NodeClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = GraphNodes?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bIncludeChildClasses;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetGraphNodesOfClass, __InBuffer, __OutBuffer);

				GraphNodes = *(TArray<UAnimGraphNode_Base>*)(__OutBuffer);

			}
		}

		private static uint __BlendOptions = 0;

		private static uint __GetGraphNodesOfClass = 0;
	}
}