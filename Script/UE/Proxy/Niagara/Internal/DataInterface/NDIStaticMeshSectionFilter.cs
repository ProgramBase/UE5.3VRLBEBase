using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NDIStaticMeshSectionFilter")]
	public partial class FNDIStaticMeshSectionFilter : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NDIStaticMeshSectionFilter");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNDIStaticMeshSectionFilter() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNDIStaticMeshSectionFilter() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNDIStaticMeshSectionFilter A, FNDIStaticMeshSectionFilter B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNDIStaticMeshSectionFilter A, FNDIStaticMeshSectionFilter B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNDIStaticMeshSectionFilter;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<int> AllowedMaterialSlots
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AllowedMaterialSlots, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AllowedMaterialSlots, __InBuffer);
				}
			}
		}

		private static uint __AllowedMaterialSlots = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}