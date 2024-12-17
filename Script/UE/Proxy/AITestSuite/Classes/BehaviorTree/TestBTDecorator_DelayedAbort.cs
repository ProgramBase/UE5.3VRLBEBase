using Script.CoreUObject;
using Script.AIModule;
using Script.Library;

namespace Script.AITestSuite
{
	[PathName("/Script/AITestSuite.TestBTDecorator_DelayedAbort")]
	public partial class UTestBTDecorator_DelayedAbort : UBTDecorator, IStaticClass
	{
		public int DelayTicks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DelayTicks, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DelayTicks, __InBuffer);
				}
			}
		}

		public bool bOnlyOnce
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOnlyOnce, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOnlyOnce, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AITestSuite.TestBTDecorator_DelayedAbort");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DelayTicks = 0;

		private static uint __bOnlyOnce = 0;
	}
}