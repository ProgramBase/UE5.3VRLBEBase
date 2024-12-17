using Script.CoreUObject;
using Script.AIModule;
using Script.Library;

namespace Script.AITestSuite
{
	[PathName("/Script/AITestSuite.MockAI_BT")]
	public partial class UMockAI_BT : UMockAI, IStaticClass
	{
		public UBehaviorTreeComponent BTComp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BTComp, __ReturnBuffer);

					return *(UBehaviorTreeComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BTComp, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AITestSuite.MockAI_BT");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __BTComp = 0;
	}
}