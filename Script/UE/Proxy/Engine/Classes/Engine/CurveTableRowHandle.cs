using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CurveTableRowHandle")]
	public partial class FCurveTableRowHandle : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.CurveTableRowHandle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCurveTableRowHandle() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCurveTableRowHandle() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCurveTableRowHandle A, FCurveTableRowHandle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCurveTableRowHandle A, FCurveTableRowHandle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCurveTableRowHandle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UCurveTable CurveTable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CurveTable, __ReturnBuffer);

					return *(UCurveTable*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CurveTable, __InBuffer);
				}
			}
		}

		public FName RowName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RowName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RowName, __InBuffer);
				}
			}
		}

		private static uint __CurveTable = 0;

		private static uint __RowName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}