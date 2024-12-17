using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ActorElementEditorWorldInterface")]
	public partial class UActorElementEditorWorldInterface : UActorElementWorldInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ActorElementEditorWorldInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}