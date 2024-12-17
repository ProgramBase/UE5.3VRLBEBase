using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.EditMeshPolygonsToolUVActions")]
	public partial class UEditMeshPolygonsToolUVActions : UEditMeshPolygonsToolActionPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.EditMeshPolygonsToolUVActions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void PlanarProjection()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __PlanarProjection);
			}
		}

		private static uint __PlanarProjection = 0;
	}
}