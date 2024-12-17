using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.IndexedCurve")]
	public partial class FIndexedCurve : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.IndexedCurve");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FIndexedCurve() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FIndexedCurve() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FIndexedCurve A, FIndexedCurve B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FIndexedCurve A, FIndexedCurve B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FIndexedCurve;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FKeyHandleMap KeyHandlesToIndices
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __KeyHandlesToIndices, __ReturnBuffer);

					return *(FKeyHandleMap*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __KeyHandlesToIndices, __InBuffer);
				}
			}
		}

		private static uint __KeyHandlesToIndices = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}