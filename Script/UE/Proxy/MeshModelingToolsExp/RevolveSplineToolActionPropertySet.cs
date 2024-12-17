using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.RevolveSplineToolActionPropertySet")]
	public partial class URevolveSplineToolActionPropertySet : UInteractiveToolPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.RevolveSplineToolActionPropertySet");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void ResetAxis()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetAxis);
			}
		}

		private static uint __ResetAxis = 0;
	}
}