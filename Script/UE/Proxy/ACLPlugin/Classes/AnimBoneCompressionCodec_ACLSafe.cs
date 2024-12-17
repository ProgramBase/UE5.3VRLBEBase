using Script.CoreUObject;
using Script.Library;

namespace Script.ACLPlugin
{
	[PathName("/Script/ACLPlugin.AnimBoneCompressionCodec_ACLSafe")]
	public partial class UAnimBoneCompressionCodec_ACLSafe : UAnimBoneCompressionCodec_ACLBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ACLPlugin.AnimBoneCompressionCodec_ACLSafe");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}