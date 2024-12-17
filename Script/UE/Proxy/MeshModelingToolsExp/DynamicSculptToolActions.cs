using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.DynamicSculptToolActions")]
	public partial class UDynamicSculptToolActions : UInteractiveToolPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.DynamicSculptToolActions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void DiscardAttributes()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __DiscardAttributes);
			}
		}

		private static uint __DiscardAttributes = 0;
	}
}