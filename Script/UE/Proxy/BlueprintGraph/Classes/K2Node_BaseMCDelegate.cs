using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_BaseMCDelegate")]
	public partial class UK2Node_BaseMCDelegate : UK2Node, IStaticClass
	{
		public FMemberReference DelegateReference
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DelegateReference, __ReturnBuffer);

					return *(FMemberReference*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DelegateReference, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_BaseMCDelegate");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DelegateReference = 0;
	}
}