using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.K2Node_AnimNodeReference")]
	public partial class UK2Node_AnimNodeReference : UK2Node, IStaticClass
	{
		public FName Tag
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Tag, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Tag, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.K2Node_AnimNodeReference");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Tag = 0;
	}
}