using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.EditMeshPolygonsToolCancelAction")]
	public partial class UEditMeshPolygonsToolCancelAction : UEditMeshPolygonsToolActionPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.EditMeshPolygonsToolCancelAction");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void Done()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Done);
			}
		}

		private static uint __Done = 0;
	}
}