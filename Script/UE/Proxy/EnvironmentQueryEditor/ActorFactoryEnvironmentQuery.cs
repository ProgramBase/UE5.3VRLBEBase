using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.EnvironmentQueryEditor
{
	[PathName("/Script/EnvironmentQueryEditor.ActorFactoryEnvironmentQuery")]
	public partial class UActorFactoryEnvironmentQuery : UActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnvironmentQueryEditor.ActorFactoryEnvironmentQuery");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}