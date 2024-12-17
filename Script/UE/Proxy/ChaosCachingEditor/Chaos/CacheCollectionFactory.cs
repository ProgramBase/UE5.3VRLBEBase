using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.ChaosCachingEditor
{
	[PathName("/Script/ChaosCachingEditor.CacheCollectionFactory")]
	public partial class UCacheCollectionFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ChaosCachingEditor.CacheCollectionFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}