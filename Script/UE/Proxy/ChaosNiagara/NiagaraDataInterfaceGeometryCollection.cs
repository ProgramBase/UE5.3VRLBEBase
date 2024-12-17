using Script.CoreUObject;
using Script.Niagara;
using Script.GeometryCollectionEngine;
using Script.Library;

namespace Script.ChaosNiagara
{
	[PathName("/Script/ChaosNiagara.NiagaraDataInterfaceGeometryCollection")]
	public partial class UNiagaraDataInterfaceGeometryCollection : UNiagaraDataInterface, IStaticClass
	{
		public AGeometryCollectionActor GeometryCollectionActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GeometryCollectionActor, __ReturnBuffer);

					return *(AGeometryCollectionActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GeometryCollectionActor, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ChaosNiagara.NiagaraDataInterfaceGeometryCollection");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __GeometryCollectionActor = 0;
	}
}