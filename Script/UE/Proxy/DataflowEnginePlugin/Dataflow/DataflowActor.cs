using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.DataflowEnginePlugin
{
	[PathName("/Script/DataflowEnginePlugin.DataflowActor")]
	public partial class ADataflowActor : AActor, IStaticClass
	{
		public UDataflowComponent DataflowComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DataflowComponent, __ReturnBuffer);

					return *(UDataflowComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DataflowComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DataflowEnginePlugin.DataflowActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DataflowComponent = 0;
	}
}