using Script.CoreUObject;
using Script.Library;

namespace Script.SubobjectEditor
{
	[PathName("/Script/SubobjectEditor.SubobjectEditorMenuContext")]
	public partial class USubobjectEditorMenuContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SubobjectEditor.SubobjectEditorMenuContext");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual TArray<UObject> GetSelectedObjects()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSelectedObjects, __ReturnBuffer);

				return *(TArray<UObject>*)__ReturnBuffer;
			}
		}

		private static uint __GetSelectedObjects = 0;
	}
}