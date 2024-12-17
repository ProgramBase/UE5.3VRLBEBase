using Script.CoreUObject;
using Script.Library;

namespace Script.StructUtils
{
	[PathName("/Script/StructUtils.PropertyBagMissingObject")]
	public partial class UPropertyBagMissingObject : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/StructUtils.PropertyBagMissingObject");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}