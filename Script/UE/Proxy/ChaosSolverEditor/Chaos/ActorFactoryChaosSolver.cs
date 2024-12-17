using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.ChaosSolverEditor
{
	[PathName("/Script/ChaosSolverEditor.ActorFactoryChaosSolver")]
	public partial class UActorFactoryChaosSolver : UActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ChaosSolverEditor.ActorFactoryChaosSolver");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}