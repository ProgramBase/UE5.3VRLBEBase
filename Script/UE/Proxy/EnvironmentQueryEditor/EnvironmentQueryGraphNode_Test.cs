using Script.CoreUObject;
using Script.Library;

namespace Script.EnvironmentQueryEditor
{
	[PathName("/Script/EnvironmentQueryEditor.EnvironmentQueryGraphNode_Test")]
	public partial class UEnvironmentQueryGraphNode_Test : UEnvironmentQueryGraphNode, IStaticClass
	{
		public float TestWeightPct
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TestWeightPct, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TestWeightPct, __InBuffer);
				}
			}
		}

		public bool bHasNamedWeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHasNamedWeight, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHasNamedWeight, __InBuffer);
				}
			}
		}

		public bool bTestEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bTestEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bTestEnabled, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnvironmentQueryEditor.EnvironmentQueryGraphNode_Test");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __TestWeightPct = 0;

		private static uint __bHasNamedWeight = 0;

		private static uint __bTestEnabled = 0;
	}
}