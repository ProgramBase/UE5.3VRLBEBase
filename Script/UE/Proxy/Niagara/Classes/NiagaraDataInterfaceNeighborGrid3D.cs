using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDataInterfaceNeighborGrid3D")]
	public partial class UNiagaraDataInterfaceNeighborGrid3D : UNiagaraDataInterfaceGrid3D, IStaticClass
	{
		public uint MaxNeighborsPerCell
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxNeighborsPerCell, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxNeighborsPerCell, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraDataInterfaceNeighborGrid3D");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __MaxNeighborsPerCell = 0;
	}
}