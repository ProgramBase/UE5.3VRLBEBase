using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.ACLPluginEditor
{
	[PathName("/Script/ACLPluginEditor.ACLDatabaseBuildCommandlet")]
	public partial class UACLDatabaseBuildCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ACLPluginEditor.ACLDatabaseBuildCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}