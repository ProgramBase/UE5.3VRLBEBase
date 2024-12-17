using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.ACLPluginEditor
{
	[PathName("/Script/ACLPluginEditor.AnimationCompressionLibraryDatabaseFactory")]
	public partial class UAnimationCompressionLibraryDatabaseFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ACLPluginEditor.AnimationCompressionLibraryDatabaseFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}