using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ExposedValueCopyRecord")]
	public partial class FExposedValueCopyRecord : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ExposedValueCopyRecord");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FExposedValueCopyRecord() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FExposedValueCopyRecord() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FExposedValueCopyRecord A, FExposedValueCopyRecord B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FExposedValueCopyRecord A, FExposedValueCopyRecord B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FExposedValueCopyRecord;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int CopyIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CopyIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CopyIndex, __InBuffer);
				}
			}
		}

		public EPostCopyOperation PostCopyOperation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PostCopyOperation, __ReturnBuffer);

					return *(EPostCopyOperation*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PostCopyOperation, __InBuffer);
				}
			}
		}

		private static uint __CopyIndex = 0;

		private static uint __PostCopyOperation = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}