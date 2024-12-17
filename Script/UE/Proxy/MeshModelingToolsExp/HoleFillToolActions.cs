using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.HoleFillToolActions")]
	public partial class UHoleFillToolActions : UInteractiveToolPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.HoleFillToolActions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SelectAll()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SelectAll);
			}
		}

		public virtual void Clear()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Clear);
			}
		}

		private static uint __SelectAll = 0;

		private static uint __Clear = 0;
	}
}