using Script.CoreUObject;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.AsyncEditorWaitForGameWorld")]
	public partial class UAsyncEditorWaitForGameWorld : UEditorUtilityBlueprintAsyncActionBase, IStaticClass
	{
		public FAsyncEditorWaitForGameWorldEvent Complete
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Complete, __ReturnBuffer);

					return *(FAsyncEditorWaitForGameWorldEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Complete, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.AsyncEditorWaitForGameWorld");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UAsyncEditorWaitForGameWorld AsyncWaitForGameWorld(int Index = 0, bool Server = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = Index;

				*(bool*)(__InBuffer + 4) = Server;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AsyncWaitForGameWorld, __InBuffer, __ReturnBuffer);

				return *(UAsyncEditorWaitForGameWorld*)__ReturnBuffer;
			}
		}

		private static uint __Complete = 0;

		private static uint __AsyncWaitForGameWorld = 0;
	}
}