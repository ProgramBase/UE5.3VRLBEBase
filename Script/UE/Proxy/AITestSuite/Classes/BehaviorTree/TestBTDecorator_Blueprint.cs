using Script.CoreUObject;
using Script.AIModule;
using Script.Library;

namespace Script.AITestSuite
{
	[PathName("/Script/AITestSuite.TestBTDecorator_Blueprint")]
	public partial class UTestBTDecorator_Blueprint : UBTDecorator_BlueprintBase, IStaticClass
	{
		public EBPConditionType BPConditionType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BPConditionType, __ReturnBuffer);

					return *(EBPConditionType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BPConditionType, __InBuffer);
				}
			}
		}

		public int LogIndexBecomeRelevant
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LogIndexBecomeRelevant, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LogIndexBecomeRelevant, __InBuffer);
				}
			}
		}

		public int LogIndexCeaseRelevant
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LogIndexCeaseRelevant, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LogIndexCeaseRelevant, __InBuffer);
				}
			}
		}

		public int LogIndexCalculate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LogIndexCalculate, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LogIndexCalculate, __InBuffer);
				}
			}
		}

		public FName ObservingKeyName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ObservingKeyName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ObservingKeyName, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AITestSuite.TestBTDecorator_Blueprint");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __BPConditionType = 0;

		private static uint __LogIndexBecomeRelevant = 0;

		private static uint __LogIndexCeaseRelevant = 0;

		private static uint __LogIndexCalculate = 0;

		private static uint __ObservingKeyName = 0;
	}
}