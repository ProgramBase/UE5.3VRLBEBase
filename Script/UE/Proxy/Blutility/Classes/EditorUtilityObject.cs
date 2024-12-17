using Script.CoreUObject;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilityObject")]
	public partial class UEditorUtilityObject : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilityObject");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void Run()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __Run);
			}
		}

		private static uint __Run = 0;
	}
}