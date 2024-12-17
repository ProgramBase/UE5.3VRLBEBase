using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.HLODBuilder")]
	public partial class UHLODBuilder : UObject, IStaticClass
	{
		public UHLODBuilderSettings HLODBuilderSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HLODBuilderSettings, __ReturnBuffer);

					return *(UHLODBuilderSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HLODBuilderSettings, __InBuffer);
				}
			}
		}

		public TSubclassOf<UInstancedStaticMeshComponent> HLODInstancedStaticMeshComponentClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HLODInstancedStaticMeshComponentClass, __ReturnBuffer);

					return *(TSubclassOf<UInstancedStaticMeshComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HLODInstancedStaticMeshComponentClass, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.HLODBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __HLODBuilderSettings = 0;

		private static uint __HLODInstancedStaticMeshComponentClass = 0;
	}
}