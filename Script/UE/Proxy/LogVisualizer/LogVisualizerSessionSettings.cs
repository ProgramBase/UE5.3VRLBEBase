using Script.CoreUObject;
using Script.Library;

namespace Script.LogVisualizer
{
	[PathName("/Script/LogVisualizer.LogVisualizerSessionSettings")]
	public partial class ULogVisualizerSessionSettings : UObject, IStaticClass
	{
		public bool bEnableGraphsVisualization
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableGraphsVisualization, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableGraphsVisualization, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LogVisualizer.LogVisualizerSessionSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bEnableGraphsVisualization = 0;
	}
}