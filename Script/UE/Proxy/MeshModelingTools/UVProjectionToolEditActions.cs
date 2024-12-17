using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.UVProjectionToolEditActions")]
	public partial class UUVProjectionToolEditActions : UInteractiveToolPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.UVProjectionToolEditActions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void Reset()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Reset);
			}
		}

		public virtual void AutoFitAlign()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __AutoFitAlign);
			}
		}

		public virtual void AutoFit()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __AutoFit);
			}
		}

		private static uint __Reset = 0;

		private static uint __AutoFitAlign = 0;

		private static uint __AutoFit = 0;
	}
}