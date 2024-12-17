using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimCompressedCurveIndexedName")]
	public partial class FAnimCompressedCurveIndexedName : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimCompressedCurveIndexedName");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimCompressedCurveIndexedName() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnimCompressedCurveIndexedName() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnimCompressedCurveIndexedName A, FAnimCompressedCurveIndexedName B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimCompressedCurveIndexedName A, FAnimCompressedCurveIndexedName B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimCompressedCurveIndexedName;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName CurveName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CurveName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CurveName, __InBuffer);
				}
			}
		}

		private static uint __CurveName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}