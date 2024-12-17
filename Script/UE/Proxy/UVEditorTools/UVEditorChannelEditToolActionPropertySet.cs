using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.UVEditorChannelEditToolActionPropertySet")]
	public partial class UUVEditorChannelEditToolActionPropertySet : UInteractiveToolPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.UVEditorChannelEditToolActionPropertySet");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void Apply()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Apply);
			}
		}

		private static uint __Apply = 0;
	}
}