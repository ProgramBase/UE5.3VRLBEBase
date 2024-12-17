using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.ChaosCachingEditor
{
	[PathName("/Script/ChaosCachingEditor.ActorFactoryCacheManager")]
	public partial class UActorFactoryCacheManager : UActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ChaosCachingEditor.ActorFactoryCacheManager");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}