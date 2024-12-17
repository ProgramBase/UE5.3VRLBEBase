using Script.CoreUObject;
using Script.Library;

namespace Script.ToolMenus
{
	[PathName("/Script/ToolMenus.ToolMenuContextExtensions")]
	public partial class UToolMenuContextExtensions : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ToolMenus.ToolMenuContextExtensions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UObject FindByClass(FToolMenuContext Context, TSubclassOf<UObject> InClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FindByClass, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		private static uint __FindByClass = 0;
	}
}