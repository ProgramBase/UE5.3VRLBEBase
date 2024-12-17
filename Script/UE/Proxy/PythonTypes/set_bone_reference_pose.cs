using Script.CoreUObject;
using Script.ToolMenus;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/set_bone_reference_pose.set_bone_reference_pose")]
	public partial class set_bone_reference_pose : UToolMenuEntryScript, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/set_bone_reference_pose.set_bone_reference_pose");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}