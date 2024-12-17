using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LevelInstanceEditorPivotInterface")]
	public partial class ULevelInstanceEditorPivotInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.LevelInstanceEditorPivotInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.LevelInstanceEditorPivotInterface")]
	public interface ILevelInstanceEditorPivotInterface : IInterface
	{
	}
}