using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.ToolTargetManager")]
	public partial class UToolTargetManager : UObject, IStaticClass
	{
		public TArray<UToolTargetFactory> Factories
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Factories, __ReturnBuffer);

					return *(TArray<UToolTargetFactory>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Factories, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.ToolTargetManager");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Factories = 0;
	}
}