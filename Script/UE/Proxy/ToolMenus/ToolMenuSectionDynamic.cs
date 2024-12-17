using Script.CoreUObject;
using Script.Library;

namespace Script.ToolMenus
{
	[PathName("/Script/ToolMenus.ToolMenuSectionDynamic")]
	public partial class UToolMenuSectionDynamic : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ToolMenus.ToolMenuSectionDynamic");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void ConstructSections(UToolMenu Menu, FToolMenuContext Context)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Menu?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Context?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ConstructSections, __InBuffer);
			}
		}

		private static uint __ConstructSections = 0;
	}
}