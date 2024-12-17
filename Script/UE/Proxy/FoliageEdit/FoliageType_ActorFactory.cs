using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.FoliageEdit
{
	[PathName("/Script/FoliageEdit.FoliageType_ActorFactory")]
	public partial class UFoliageType_ActorFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FoliageEdit.FoliageType_ActorFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}