using Script.CoreUObject;
using Script.Library;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.SlateWidgetStyleContainerBase")]
	public partial class USlateWidgetStyleContainerBase : UObject, IStaticClass, ISlateWidgetStyleContainerInterface
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SlateCore.SlateWidgetStyleContainerBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		private static uint __ExecuteUbergraph = 0;
	}
}