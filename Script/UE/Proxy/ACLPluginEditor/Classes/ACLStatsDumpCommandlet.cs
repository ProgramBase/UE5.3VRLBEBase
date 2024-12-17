using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.ACLPluginEditor
{
	[PathName("/Script/ACLPluginEditor.ACLStatsDumpCommandlet")]
	public partial class UACLStatsDumpCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ACLPluginEditor.ACLStatsDumpCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}