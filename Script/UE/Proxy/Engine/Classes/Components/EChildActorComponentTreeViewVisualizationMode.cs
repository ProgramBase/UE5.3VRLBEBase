using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EChildActorComponentTreeViewVisualizationMode")]
	public enum EChildActorComponentTreeViewVisualizationMode : byte
	{
		UseDefault = 0,
		ComponentOnly = 1,
		ComponentWithChildActor = 2,
		ChildActorOnly = 3,
	}
}