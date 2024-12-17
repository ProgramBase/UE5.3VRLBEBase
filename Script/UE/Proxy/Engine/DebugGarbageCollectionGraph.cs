using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DebugGarbageCollectionGraph")]
	public partial class UDebugGarbageCollectionGraph : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.DebugGarbageCollectionGraph");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}